using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XUserSummary
{
    public string? User { get; set; }

    public decimal? Statements { get; set; }

    public decimal? StatementLatency { get; set; }

    public decimal StatementAvgLatency { get; set; }

    public decimal? TableScans { get; set; }

    public decimal? FileIos { get; set; }

    public decimal? FileIoLatency { get; set; }

    public decimal? CurrentConnections { get; set; }

    public decimal? TotalConnections { get; set; }

    public long UniqueHosts { get; set; }

    public decimal? CurrentMemory { get; set; }

    public decimal? TotalMemoryAllocated { get; set; }
}
