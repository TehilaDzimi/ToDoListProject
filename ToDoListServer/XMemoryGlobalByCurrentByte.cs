using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XMemoryGlobalByCurrentByte
{
    public string EventName { get; set; } = null!;

    public long CurrentCount { get; set; }

    public long CurrentAlloc { get; set; }

    public decimal CurrentAvgAlloc { get; set; }

    public long HighCount { get; set; }

    public long HighAlloc { get; set; }

    public decimal HighAvgAlloc { get; set; }
}
