using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class UserSummary
{
    public string? User { get; set; }

    public decimal? Statements { get; set; }

    public string? StatementLatency { get; set; }

    public string? StatementAvgLatency { get; set; }

    public decimal? TableScans { get; set; }

    public decimal? FileIos { get; set; }

    public string? FileIoLatency { get; set; }

    public decimal? CurrentConnections { get; set; }

    public decimal? TotalConnections { get; set; }

    public long UniqueHosts { get; set; }

    public string? CurrentMemory { get; set; }

    public string? TotalMemoryAllocated { get; set; }
}
