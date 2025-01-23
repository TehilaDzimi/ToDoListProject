using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class MemoryByThreadByCurrentByte
{
    public ulong ThreadId { get; set; }

    public string? User { get; set; }

    public decimal? CurrentCountUsed { get; set; }

    public string? CurrentAllocated { get; set; }

    public string? CurrentAvgAlloc { get; set; }

    public string? CurrentMaxAlloc { get; set; }

    public string? TotalAllocated { get; set; }
}
