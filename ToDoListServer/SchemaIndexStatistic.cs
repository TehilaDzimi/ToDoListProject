using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SchemaIndexStatistic
{
    public string? TableSchema { get; set; }

    public string? TableName { get; set; }

    public string? IndexName { get; set; }

    public ulong RowsSelected { get; set; }

    public string? SelectLatency { get; set; }

    public ulong RowsInserted { get; set; }

    public string? InsertLatency { get; set; }

    public ulong RowsUpdated { get; set; }

    public string? UpdateLatency { get; set; }

    public ulong RowsDeleted { get; set; }

    public string? DeleteLatency { get; set; }
}
