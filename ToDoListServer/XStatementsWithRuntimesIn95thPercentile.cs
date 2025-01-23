using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XStatementsWithRuntimesIn95thPercentile
{
    public string? Query { get; set; }

    public string? Db { get; set; }

    public string FullScan { get; set; } = null!;

    public ulong ExecCount { get; set; }

    public ulong ErrCount { get; set; }

    public ulong WarnCount { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong MaxLatency { get; set; }

    public ulong AvgLatency { get; set; }

    public ulong RowsSent { get; set; }

    public decimal RowsSentAvg { get; set; }

    public ulong RowsExamined { get; set; }

    public decimal RowsExaminedAvg { get; set; }

    public DateTime FirstSeen { get; set; }

    public DateTime LastSeen { get; set; }

    public string? Digest { get; set; }
}
