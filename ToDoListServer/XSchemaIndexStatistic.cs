using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XSchemaIndexStatistic
{
    public string? TableSchema { get; set; }

    public string? TableName { get; set; }

    public string? IndexName { get; set; }

    public ulong RowsSelected { get; set; }

    public ulong SelectLatency { get; set; }

    public ulong RowsInserted { get; set; }

    public ulong InsertLatency { get; set; }

    public ulong RowsUpdated { get; set; }

    public ulong UpdateLatency { get; set; }

    public ulong RowsDeleted { get; set; }

    public ulong DeleteLatency { get; set; }
}
