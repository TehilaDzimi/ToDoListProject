using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class LatestFileIo
{
    public string? Thread { get; set; }

    public string? File { get; set; }

    public string? Latency { get; set; }

    public string Operation { get; set; } = null!;

    public string? Requested { get; set; }
}
