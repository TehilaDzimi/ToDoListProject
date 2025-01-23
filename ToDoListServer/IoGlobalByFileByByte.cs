using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class IoGlobalByFileByByte
{
    public string? File { get; set; }

    public ulong CountRead { get; set; }

    public string? TotalRead { get; set; }

    public string? AvgRead { get; set; }

    public ulong CountWrite { get; set; }

    public string? TotalWritten { get; set; }

    public string? AvgWrite { get; set; }

    public string? Total { get; set; }

    public decimal WritePct { get; set; }
}
