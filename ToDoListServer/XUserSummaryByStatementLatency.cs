using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XUserSummaryByStatementLatency
{
    public string? User { get; set; }

    public decimal? Total { get; set; }

    public decimal? TotalLatency { get; set; }

    public decimal? MaxLatency { get; set; }

    public decimal? LockLatency { get; set; }

    public decimal? CpuLatency { get; set; }

    public decimal? RowsSent { get; set; }

    public decimal? RowsExamined { get; set; }

    public decimal? RowsAffected { get; set; }

    public decimal? FullScans { get; set; }
}
