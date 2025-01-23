using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SchemaTableLockWait
{
    public string? ObjectSchema { get; set; }

    public string? ObjectName { get; set; }

    public ulong WaitingThreadId { get; set; }

    public ulong? WaitingPid { get; set; }

    public string? WaitingAccount { get; set; }

    public string WaitingLockType { get; set; } = null!;

    public string WaitingLockDuration { get; set; } = null!;

    public string? WaitingQuery { get; set; }

    public long? WaitingQuerySecs { get; set; }

    public ulong? WaitingQueryRowsAffected { get; set; }

    public ulong? WaitingQueryRowsExamined { get; set; }

    public ulong BlockingThreadId { get; set; }

    public ulong? BlockingPid { get; set; }

    public string? BlockingAccount { get; set; }

    public string BlockingLockType { get; set; } = null!;

    public string BlockingLockDuration { get; set; } = null!;

    public string? SqlKillBlockingQuery { get; set; }

    public string? SqlKillBlockingConnection { get; set; }
}
