using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XIoGlobalByFileByByte
{
    public string File { get; set; } = null!;

    public ulong CountRead { get; set; }

    public long TotalRead { get; set; }

    public decimal AvgRead { get; set; }

    public ulong CountWrite { get; set; }

    public long TotalWritten { get; set; }

    public decimal AvgWrite { get; set; }

    public long Total { get; set; }

    public decimal WritePct { get; set; }
}
