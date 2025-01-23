using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class WaitClassesGlobalByAvgLatency
{
    public string? EventClass { get; set; }

    public decimal? Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? MinLatency { get; set; }

    public string? AvgLatency { get; set; }

    public string? MaxLatency { get; set; }
}
