using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XLatestFileIo
{
    public string? Thread { get; set; }

    public string? File { get; set; }

    public ulong? Latency { get; set; }

    public string Operation { get; set; } = null!;

    public long? Requested { get; set; }
}
