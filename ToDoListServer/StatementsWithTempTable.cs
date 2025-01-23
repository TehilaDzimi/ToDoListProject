using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class StatementsWithTempTable
{
    public string? Query { get; set; }

    public string? Db { get; set; }

    public ulong ExecCount { get; set; }

    public string? TotalLatency { get; set; }

    public ulong MemoryTmpTables { get; set; }

    public ulong DiskTmpTables { get; set; }

    public decimal AvgTmpTablesPerQuery { get; set; }

    public decimal TmpTablesToDiskPct { get; set; }

    public DateTime FirstSeen { get; set; }

    public DateTime LastSeen { get; set; }

    public string? Digest { get; set; }
}
