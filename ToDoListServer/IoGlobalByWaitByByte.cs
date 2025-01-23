using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class IoGlobalByWaitByByte
{
    public string? EventName { get; set; }

    public ulong Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? MinLatency { get; set; }

    public string? AvgLatency { get; set; }

    public string? MaxLatency { get; set; }

    public ulong CountRead { get; set; }

    public string? TotalRead { get; set; }

    public string? AvgRead { get; set; }

    public ulong CountWrite { get; set; }

    public string? TotalWritten { get; set; }

    public string? AvgWritten { get; set; }

    public string? TotalRequested { get; set; }
}
