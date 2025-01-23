using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class IoGlobalByFileByLatency
{
    public string? File { get; set; }

    public ulong Total { get; set; }

    public string? TotalLatency { get; set; }

    public ulong CountRead { get; set; }

    public string? ReadLatency { get; set; }

    public ulong CountWrite { get; set; }

    public string? WriteLatency { get; set; }

    public ulong CountMisc { get; set; }

    public string? MiscLatency { get; set; }
}
