using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class WaitsGlobalByLatency
{
    public string Events { get; set; } = null!;

    public ulong Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? AvgLatency { get; set; }

    public string? MaxLatency { get; set; }
}
