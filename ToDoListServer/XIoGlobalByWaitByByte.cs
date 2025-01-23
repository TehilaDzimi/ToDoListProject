using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XIoGlobalByWaitByByte
{
    public string? EventName { get; set; }

    public ulong Total { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong MinLatency { get; set; }

    public ulong AvgLatency { get; set; }

    public ulong MaxLatency { get; set; }

    public ulong CountRead { get; set; }

    public long TotalRead { get; set; }

    public decimal AvgRead { get; set; }

    public ulong CountWrite { get; set; }

    public long TotalWritten { get; set; }

    public decimal AvgWritten { get; set; }

    public long TotalRequested { get; set; }
}
