using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class UserSummaryByStatementLatency
{
    public string? User { get; set; }

    public decimal? Total { get; set; }

    public string? TotalLatency { get; set; }

    public string? MaxLatency { get; set; }

    public string? LockLatency { get; set; }

    public string? CpuLatency { get; set; }

    public decimal? RowsSent { get; set; }

    public decimal? RowsExamined { get; set; }

    public decimal? RowsAffected { get; set; }

    public decimal? FullScans { get; set; }
}
