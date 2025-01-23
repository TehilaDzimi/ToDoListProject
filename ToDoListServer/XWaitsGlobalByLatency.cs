using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XWaitsGlobalByLatency
{
    public string Events { get; set; } = null!;

    public ulong Total { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong AvgLatency { get; set; }

    public ulong MaxLatency { get; set; }
}
