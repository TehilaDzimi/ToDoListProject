using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XStatementAnalysis
{
    public string? Query { get; set; }

    public string? Db { get; set; }

    public string FullScan { get; set; } = null!;

    public ulong ExecCount { get; set; }

    public ulong ExecSecondaryCount { get; set; }

    public ulong ErrCount { get; set; }

    public ulong WarnCount { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong MaxLatency { get; set; }

    public ulong AvgLatency { get; set; }

    public ulong LockLatency { get; set; }

    public ulong CpuLatency { get; set; }

    public ulong RowsSent { get; set; }

    public decimal RowsSentAvg { get; set; }

    public ulong RowsExamined { get; set; }

    public decimal RowsExaminedAvg { get; set; }

    public ulong RowsAffected { get; set; }

    public decimal RowsAffectedAvg { get; set; }

    public ulong TmpTables { get; set; }

    public ulong TmpDiskTables { get; set; }

    public ulong RowsSorted { get; set; }

    public ulong SortMergePasses { get; set; }

    public ulong MaxControlledMemory { get; set; }

    public ulong MaxTotalMemory { get; set; }

    public string? Digest { get; set; }

    public DateTime FirstSeen { get; set; }

    public DateTime LastSeen { get; set; }
}
