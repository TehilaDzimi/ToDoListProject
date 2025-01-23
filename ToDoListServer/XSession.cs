using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XSession
{
    public ulong ThdId { get; set; }

    public ulong? ConnId { get; set; }

    public string? User { get; set; }

    public string? Db { get; set; }

    public string? Command { get; set; }

    public string? State { get; set; }

    public long? Time { get; set; }

    public string? CurrentStatement { get; set; }

    public string? ExecutionEngine { get; set; }

    public ulong? StatementLatency { get; set; }

    public decimal? Progress { get; set; }

    public ulong? LockLatency { get; set; }

    public ulong? CpuLatency { get; set; }

    public ulong? RowsExamined { get; set; }

    public ulong? RowsSent { get; set; }

    public ulong? RowsAffected { get; set; }

    public ulong? TmpTables { get; set; }

    public ulong? TmpDiskTables { get; set; }

    public string FullScan { get; set; } = null!;

    public string? LastStatement { get; set; }

    public ulong? LastStatementLatency { get; set; }

    public decimal? CurrentMemory { get; set; }

    public string? LastWait { get; set; }

    public string? LastWaitLatency { get; set; }

    public string? Source { get; set; }

    public ulong? TrxLatency { get; set; }

    public string? TrxState { get; set; }

    public string? TrxAutocommit { get; set; }

    public string? Pid { get; set; }

    public string? ProgramName { get; set; }
}
