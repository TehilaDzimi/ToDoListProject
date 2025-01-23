using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class MemoryByHostByCurrentByte
{
    public string? Host { get; set; }

    public decimal? CurrentCountUsed { get; set; }

    public string? CurrentAllocated { get; set; }

    public string? CurrentAvgAlloc { get; set; }

    public string? CurrentMaxAlloc { get; set; }

    public string? TotalAllocated { get; set; }
}
