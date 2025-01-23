using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class MemoryGlobalByCurrentByte
{
    public string EventName { get; set; } = null!;

    public long CurrentCount { get; set; }

    public string? CurrentAlloc { get; set; }

    public string? CurrentAvgAlloc { get; set; }

    public long HighCount { get; set; }

    public string? HighAlloc { get; set; }

    public string? HighAvgAlloc { get; set; }
}
