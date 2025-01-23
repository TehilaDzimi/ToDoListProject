using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XIoGlobalByFileByLatency
{
    public string File { get; set; } = null!;

    public ulong Total { get; set; }

    public ulong TotalLatency { get; set; }

    public ulong CountRead { get; set; }

    public ulong ReadLatency { get; set; }

    public ulong CountWrite { get; set; }

    public ulong WriteLatency { get; set; }

    public ulong CountMisc { get; set; }

    public ulong MiscLatency { get; set; }
}
