using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SchemaObjectOverview
{
    public string? Db { get; set; }

    public string? ObjectType { get; set; }

    public long Count { get; set; }
}
