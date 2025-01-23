using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XHostSummaryByStage
{
    public string? Host { get; set; }

    public string EventName { get; set; } = null!;

    public ulong Total { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong AvgLatency { get; set; }
}
