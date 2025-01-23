using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XStatementsWithSorting
{
    public string? Query { get; set; }

    public string? Db { get; set; }

    public ulong ExecCount { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong SortMergePasses { get; set; }

    public decimal AvgSortMerges { get; set; }

    public ulong SortsUsingScans { get; set; }

    public ulong SortUsingRange { get; set; }

    public ulong RowsSorted { get; set; }

    public decimal AvgRowsSorted { get; set; }

    public DateTime FirstSeen { get; set; }

    public DateTime LastSeen { get; set; }

    public string? Digest { get; set; }
}
