using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class StatementsWithFullTableScan
{
    public string? Query { get; set; }

    public string? Db { get; set; }

    public ulong ExecCount { get; set; }

    public string? TotalLatency { get; set; }

    public ulong NoIndexUsedCount { get; set; }

    public ulong NoGoodIndexUsedCount { get; set; }

    public decimal NoIndexUsedPct { get; set; }

    public ulong RowsSent { get; set; }

    public ulong RowsExamined { get; set; }

    public decimal? RowsSentAvg { get; set; }

    public decimal? RowsExaminedAvg { get; set; }

    public DateTime FirstSeen { get; set; }

    public DateTime LastSeen { get; set; }

    public string? Digest { get; set; }
}
