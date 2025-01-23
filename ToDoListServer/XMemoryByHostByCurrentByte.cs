using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XMemoryByHostByCurrentByte
{
    public string? Host { get; set; }

    public decimal? CurrentCountUsed { get; set; }

    public decimal? CurrentAllocated { get; set; }

    public decimal CurrentAvgAlloc { get; set; }

    public long? CurrentMaxAlloc { get; set; }

    public decimal? TotalAllocated { get; set; }
}
