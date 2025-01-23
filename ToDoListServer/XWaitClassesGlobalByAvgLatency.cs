using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XWaitClassesGlobalByAvgLatency
{
    public string? EventClass { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalLatency { get; set; }

    public ulong? MinLatency { get; set; }

    public decimal AvgLatency { get; set; }

    public ulong? MaxLatency { get; set; }
}
