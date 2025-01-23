using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.ComponentModel.DataAnnotations.Schema;

var builder = WebApplication.CreateBuilder(args);

// הוספת DbContext לשירותים עם חיבור למסד הנתונים
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("ToDoDB"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ToDoDB"))
    ));

// הוספת Swagger לתיעוד ה-API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Items API", Version = "v1" });
});

// הגדרת CORS - פתוח לכל מקורות
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// הצגת Swagger רק בסביבת פיתוח
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Items API V1");
        c.RoutePrefix = string.Empty; // הצגת Swagger בדף הראשי
    });
}

// טיפול בשגיאות כלליות
app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        var exception = context.Features.Get<Microsoft.AspNetCore.Diagnostics.IExceptionHandlerFeature>()?.Error;
        var response = new 
        { 
            Error = exception?.Message, 
            InnerException = exception?.InnerException?.Message 
        };
        context.Response.StatusCode = 500;
        await context.Response.WriteAsJsonAsync(response);
    });
});

// הפעלת HTTPS ו-CORS
app.UseHttpsRedirection();
app.UseCors();

// Routes עבור פעולות CRUD לטבלת Items
app.MapGet("/items", async (ApplicationDbContext dbContext) =>
{
    var items = await dbContext.Items
        .Select(item => new 
        {
            item.Id,
            Name = item.Name ?? "שם לא זמין", // אם Name הוא null, תן ערך ברירת מחדל
            IsComplete = item.IsComplete ?? false // אם IsComplete הוא null, תן ערך ברירת מחדל
        })
        .ToListAsync();
    return Results.Ok(items);
})
.WithName("GetAllItems");

app.MapPost("/items", async (ApplicationDbContext dbContext, Items item) =>
{
    dbContext.Items.Add(item);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/items/{item.Id}", item);
})
.WithName("CreateItem");

app.MapPut("/items/{id}", async (ApplicationDbContext dbContext, int id, Items item) =>
{
    var existingItem = await dbContext.Items.FindAsync(id);  // חיפוש הפריט לפי ה-ID
    if (existingItem == null)
    {
        return Results.NotFound();  // אם לא נמצא, מחזיר 404
    }

    // עדכון השדות בפריט הקיים
    existingItem.Name = item.Name ?? existingItem.Name; // עדכון רק אם יש ערך חדש
    existingItem.IsComplete = item.IsComplete ?? existingItem.IsComplete; // עדכון רק אם יש ערך חדש
    await dbContext.SaveChangesAsync();  // שמירת השינויים במסד הנתונים
    return Results.Ok(existingItem);  // מחזיר את הפריט המעודכן
})
.WithName("UpdateItem");

app.MapDelete("/items/{id}", async (ApplicationDbContext dbContext, int id) =>
{
    var item = await dbContext.Items.FindAsync(id);
    if (item == null)
    {
        return Results.NotFound();
    }

    dbContext.Items.Remove(item);
    await dbContext.SaveChangesAsync();
    return Results.NoContent();
})
.WithName("DeleteItem");

app.Run();

// מודל ה-Item
[Table("Items")] // מפנה לטבלה Items במסד הנתונים
public class Items
{
    public int Id { get; set; }
    public string? Name { get; set; }  // אפשר ערך null
    public bool? IsComplete { get; set; }  // אפשר ערך null
}

// DbContext שמנהל את מסד הנתונים
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Items> Items { get; set; }
}
