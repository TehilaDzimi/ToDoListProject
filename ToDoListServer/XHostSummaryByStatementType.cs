using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XHostSummaryByStatementType
{
    public string? Host { get; set; }

    public string? Statement { get; set; }

    public ulong Total { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong MaxLatency { get; set; }

    public ulong LockLatency { get; set; }

    public ulong CpuLatency { get; set; }

    public ulong RowsSent { get; set; }

    public ulong RowsExamined { get; set; }

    public ulong RowsAffected { get; set; }

    public ulong FullScans { get; set; }
}
