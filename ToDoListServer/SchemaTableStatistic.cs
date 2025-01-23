using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SchemaTableStatistic
{
    public string? TableSchema { get; set; }

    public string? TableName { get; set; }

    public string? TotalLatency { get; set; }

    public ulong RowsFetched { get; set; }

    public string? FetchLatency { get; set; }

    public ulong RowsInserted { get; set; }

    public string? InsertLatency { get; set; }

    public ulong RowsUpdated { get; set; }

    public string? UpdateLatency { get; set; }

    public ulong RowsDeleted { get; set; }

    public string? DeleteLatency { get; set; }

    public decimal? IoReadRequests { get; set; }

    public string? IoRead { get; set; }

    public string? IoReadLatency { get; set; }

    public decimal? IoWriteRequests { get; set; }

    public string? IoWrite { get; set; }

    public string? IoWriteLatency { get; set; }

    public decimal? IoMiscRequests { get; set; }

    public string? IoMiscLatency { get; set; }
}
