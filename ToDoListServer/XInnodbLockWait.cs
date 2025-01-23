using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XInnodbLockWait
{
    public DateTime? WaitStarted { get; set; }

    public TimeOnly? WaitAge { get; set; }

    public long? WaitAgeSecs { get; set; }

    public string? LockedTable { get; set; }

    public string? LockedTableSchema { get; set; }

    public string? LockedTableName { get; set; }

    public string? LockedTablePartition { get; set; }

    public string? LockedTableSubpartition { get; set; }

    public string? LockedIndex { get; set; }

    public string LockedType { get; set; } = null!;

    public ulong WaitingTrxId { get; set; }

    public DateTime WaitingTrxStarted { get; set; }

    public TimeOnly? WaitingTrxAge { get; set; }

    public ulong WaitingTrxRowsLocked { get; set; }

    public ulong WaitingTrxRowsModified { get; set; }

    public ulong WaitingPid { get; set; }

    public string? WaitingQuery { get; set; }

    public string WaitingLockId { get; set; } = null!;

    public string WaitingLockMode { get; set; } = null!;

    public ulong BlockingTrxId { get; set; }

    public ulong BlockingPid { get; set; }

    public string? BlockingQuery { get; set; }

    public string BlockingLockId { get; set; } = null!;

    public string BlockingLockMode { get; set; } = null!;

    public DateTime BlockingTrxStarted { get; set; }

    public TimeOnly? BlockingTrxAge { get; set; }

    public ulong BlockingTrxRowsLocked { get; set; }

    public ulong BlockingTrxRowsModified { get; set; }

    public string SqlKillBlockingQuery { get; set; } = null!;

    public string SqlKillBlockingConnection { get; set; } = null!;
}
