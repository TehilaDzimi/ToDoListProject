using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class StatementsWithErrorsOrWarning
{
    public string? Query { get; set; }

    public string? Db { get; set; }

    public ulong ExecCount { get; set; }

    public ulong Errors { get; set; }

    public decimal ErrorPct { get; set; }

    public ulong Warnings { get; set; }

    public decimal WarningPct { get; set; }

    public DateTime FirstSeen { get; set; }

    public DateTime LastSeen { get; set; }

    public string? Digest { get; set; }
}
