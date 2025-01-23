using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class WaitsByHostByLatency
{
    public string? Host { get; set; }

    public string Event { get; set; } = null!;

    public ulong Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? AvgLatency { get; set; }

    public string? MaxLatency { get; set; }
}
