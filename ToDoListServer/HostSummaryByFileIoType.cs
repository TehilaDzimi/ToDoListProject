using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class HostSummaryByFileIoType
{
    public string? Host { get; set; }

    public string EventName { get; set; } = null!;

    public ulong Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? MaxLatency { get; set; }
}
