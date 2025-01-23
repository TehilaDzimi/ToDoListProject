using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class HostSummaryByStatementType
{
    public string? Host { get; set; }

    public string? Statement { get; set; }

    public ulong Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? MaxLatency { get; set; }

    public string? LockLatency { get; set; }

    public string? CpuLatency { get; set; }

    public ulong RowsSent { get; set; }

    public ulong RowsExamined { get; set; }

    public ulong RowsAffected { get; set; }

    public ulong FullScans { get; set; }
}
