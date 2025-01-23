using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XInnodbBufferStatsBySchema
{
    public string? ObjectSchema { get; set; }

    public decimal? Allocated { get; set; }

    public decimal? Data { get; set; }

    public long Pages { get; set; }

    public long PagesHashed { get; set; }

    public long PagesOld { get; set; }

    public decimal RowsCached { get; set; }
}
