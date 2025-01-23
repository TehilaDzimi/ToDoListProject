using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XHostSummaryByFileIoType
{
    public string? Host { get; set; }

    public string EventName { get; set; } = null!;

    public ulong Total { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong MaxLatency { get; set; }
}
