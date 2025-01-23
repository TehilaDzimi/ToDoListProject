using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SchemaRedundantIndex
{
    public string? TableSchema { get; set; }

    public string? TableName { get; set; }

    public string? RedundantIndexName { get; set; }

    public string? RedundantIndexColumns { get; set; }

    public int? RedundantIndexNonUnique { get; set; }

    public string? DominantIndexName { get; set; }

    public string? DominantIndexColumns { get; set; }

    public int? DominantIndexNonUnique { get; set; }

    public int SubpartExists { get; set; }

    public string? SqlDropIndex { get; set; }
}
