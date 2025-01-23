using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class UserSummaryByFileIoType
{
    public string? User { get; set; }

    public string EventName { get; set; } = null!;

    public ulong Total { get; set; }

    public string? Latency { get; set; }

    public string? MaxLatency { get; set; }
}
