using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XUserSummaryByFileIoType
{
    public string? User { get; set; }

    public string EventName { get; set; } = null!;

    public ulong Total { get; set; }

    public ulong Latency { get; set; }

    public ulong MaxLatency { get; set; }
}
