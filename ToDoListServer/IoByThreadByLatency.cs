using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class IoByThreadByLatency
{
    public string? User { get; set; }

    public decimal? Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? MinLatency { get; set; }

    public string? AvgLatency { get; set; }

    public string? MaxLatency { get; set; }

    public ulong ThreadId { get; set; }

    public ulong? ProcesslistId { get; set; }
}
