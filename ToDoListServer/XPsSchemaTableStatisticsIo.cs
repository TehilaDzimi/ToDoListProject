using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XPsSchemaTableStatisticsIo
{
    public string? TableSchema { get; set; }

    public string? TableName { get; set; }

    public decimal? CountRead { get; set; }

    public decimal? SumNumberOfBytesRead { get; set; }

    public decimal? SumTimerRead { get; set; }

    public decimal? CountWrite { get; set; }

    public decimal? SumNumberOfBytesWrite { get; set; }

    public decimal? SumTimerWrite { get; set; }

    public decimal? CountMisc { get; set; }

    public decimal? SumTimerMisc { get; set; }
}
