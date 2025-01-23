using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace TodoApi;

public partial class ToDoDbContext : DbContext
{
    public ToDoDbContext()
    {
    }

    public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HostSummary> HostSummaries { get; set; }

    public virtual DbSet<HostSummaryByFileIo> HostSummaryByFileIos { get; set; }

    public virtual DbSet<HostSummaryByFileIoType> HostSummaryByFileIoTypes { get; set; }

    public virtual DbSet<HostSummaryByStage> HostSummaryByStages { get; set; }

    public virtual DbSet<HostSummaryByStatementLatency> HostSummaryByStatementLatencies { get; set; }

    public virtual DbSet<HostSummaryByStatementType> HostSummaryByStatementTypes { get; set; }

    public virtual DbSet<InnodbBufferStatsBySchema> InnodbBufferStatsBySchemas { get; set; }

    public virtual DbSet<InnodbBufferStatsByTable> InnodbBufferStatsByTables { get; set; }

    public virtual DbSet<InnodbLockWait> InnodbLockWaits { get; set; }

    public virtual DbSet<IoByThreadByLatency> IoByThreadByLatencies { get; set; }

    public virtual DbSet<IoGlobalByFileByByte> IoGlobalByFileByBytes { get; set; }

    public virtual DbSet<IoGlobalByFileByLatency> IoGlobalByFileByLatencies { get; set; }

    public virtual DbSet<IoGlobalByWaitByByte> IoGlobalByWaitByBytes { get; set; }

    public virtual DbSet<IoGlobalByWaitByLatency> IoGlobalByWaitByLatencies { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<LatestFileIo> LatestFileIos { get; set; }

    public virtual DbSet<MemoryByHostByCurrentByte> MemoryByHostByCurrentBytes { get; set; }

    public virtual DbSet<MemoryByThreadByCurrentByte> MemoryByThreadByCurrentBytes { get; set; }

    public virtual DbSet<MemoryByUserByCurrentByte> MemoryByUserByCurrentBytes { get; set; }

    public virtual DbSet<MemoryGlobalByCurrentByte> MemoryGlobalByCurrentBytes { get; set; }

    public virtual DbSet<MemoryGlobalTotal> MemoryGlobalTotals { get; set; }

    public virtual DbSet<Metric> Metrics { get; set; }

    public virtual DbSet<Processlist> Processlists { get; set; }

    public virtual DbSet<PsCheckLostInstrumentation> PsCheckLostInstrumentations { get; set; }

    public virtual DbSet<SchemaAutoIncrementColumn> SchemaAutoIncrementColumns { get; set; }

    public virtual DbSet<SchemaIndexStatistic> SchemaIndexStatistics { get; set; }

    public virtual DbSet<SchemaObjectOverview> SchemaObjectOverviews { get; set; }

    public virtual DbSet<SchemaRedundantIndex> SchemaRedundantIndexes { get; set; }

    public virtual DbSet<SchemaTableLockWait> SchemaTableLockWaits { get; set; }

    public virtual DbSet<SchemaTableStatistic> SchemaTableStatistics { get; set; }

    public virtual DbSet<SchemaTableStatisticsWithBuffer> SchemaTableStatisticsWithBuffers { get; set; }

    public virtual DbSet<SchemaTablesWithFullTableScan> SchemaTablesWithFullTableScans { get; set; }

    public virtual DbSet<SchemaUnusedIndex> SchemaUnusedIndexes { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<SessionSslStatus> SessionSslStatuses { get; set; }

    public virtual DbSet<StatementAnalysis> StatementAnalyses { get; set; }

    public virtual DbSet<StatementsWithErrorsOrWarning> StatementsWithErrorsOrWarnings { get; set; }

    public virtual DbSet<StatementsWithFullTableScan> StatementsWithFullTableScans { get; set; }

    public virtual DbSet<StatementsWithRuntimesIn95thPercentile> StatementsWithRuntimesIn95thPercentiles { get; set; }

    public virtual DbSet<StatementsWithSorting> StatementsWithSortings { get; set; }

    public virtual DbSet<StatementsWithTempTable> StatementsWithTempTables { get; set; }

    public virtual DbSet<SysConfig> SysConfigs { get; set; }

    public virtual DbSet<UserSummary> UserSummaries { get; set; }

    public virtual DbSet<UserSummaryByFileIo> UserSummaryByFileIos { get; set; }

    public virtual DbSet<UserSummaryByFileIoType> UserSummaryByFileIoTypes { get; set; }

    public virtual DbSet<UserSummaryByStage> UserSummaryByStages { get; set; }

    public virtual DbSet<UserSummaryByStatementLatency> UserSummaryByStatementLatencies { get; set; }

    public virtual DbSet<UserSummaryByStatementType> UserSummaryByStatementTypes { get; set; }

    public virtual DbSet<Version> Versions { get; set; }

    public virtual DbSet<WaitClassesGlobalByAvgLatency> WaitClassesGlobalByAvgLatencies { get; set; }

    public virtual DbSet<WaitClassesGlobalByLatency> WaitClassesGlobalByLatencies { get; set; }

    public virtual DbSet<WaitsByHostByLatency> WaitsByHostByLatencies { get; set; }

    public virtual DbSet<WaitsByUserByLatency> WaitsByUserByLatencies { get; set; }

    public virtual DbSet<WaitsGlobalByLatency> WaitsGlobalByLatencies { get; set; }

    public virtual DbSet<XHostSummary> XHostSummaries { get; set; }

    public virtual DbSet<XHostSummaryByFileIo> XHostSummaryByFileIos { get; set; }

    public virtual DbSet<XHostSummaryByFileIoType> XHostSummaryByFileIoTypes { get; set; }

    public virtual DbSet<XHostSummaryByStage> XHostSummaryByStages { get; set; }

    public virtual DbSet<XHostSummaryByStatementLatency> XHostSummaryByStatementLatencies { get; set; }

    public virtual DbSet<XHostSummaryByStatementType> XHostSummaryByStatementTypes { get; set; }

    public virtual DbSet<XInnodbBufferStatsBySchema> XInnodbBufferStatsBySchemas { get; set; }

    public virtual DbSet<XInnodbBufferStatsByTable> XInnodbBufferStatsByTables { get; set; }

    public virtual DbSet<XInnodbLockWait> XInnodbLockWaits { get; set; }

    public virtual DbSet<XIoByThreadByLatency> XIoByThreadByLatencies { get; set; }

    public virtual DbSet<XIoGlobalByFileByByte> XIoGlobalByFileByBytes { get; set; }

    public virtual DbSet<XIoGlobalByFileByLatency> XIoGlobalByFileByLatencies { get; set; }

    public virtual DbSet<XIoGlobalByWaitByByte> XIoGlobalByWaitByBytes { get; set; }

    public virtual DbSet<XIoGlobalByWaitByLatency> XIoGlobalByWaitByLatencies { get; set; }

    public virtual DbSet<XLatestFileIo> XLatestFileIos { get; set; }

    public virtual DbSet<XMemoryByHostByCurrentByte> XMemoryByHostByCurrentBytes { get; set; }

    public virtual DbSet<XMemoryByThreadByCurrentByte> XMemoryByThreadByCurrentBytes { get; set; }

    public virtual DbSet<XMemoryByUserByCurrentByte> XMemoryByUserByCurrentBytes { get; set; }

    public virtual DbSet<XMemoryGlobalByCurrentByte> XMemoryGlobalByCurrentBytes { get; set; }

    public virtual DbSet<XMemoryGlobalTotal> XMemoryGlobalTotals { get; set; }

    public virtual DbSet<XProcesslist> XProcesslists { get; set; }

    public virtual DbSet<XPsDigest95thPercentileByAvgU> XPsDigest95thPercentileByAvgUs { get; set; }

    public virtual DbSet<XPsDigestAvgLatencyDistribution> XPsDigestAvgLatencyDistributions { get; set; }

    public virtual DbSet<XPsSchemaTableStatisticsIo> XPsSchemaTableStatisticsIos { get; set; }

    public virtual DbSet<XSchemaFlattenedKey> XSchemaFlattenedKeys { get; set; }

    public virtual DbSet<XSchemaIndexStatistic> XSchemaIndexStatistics { get; set; }

    public virtual DbSet<XSchemaTableLockWait> XSchemaTableLockWaits { get; set; }

    public virtual DbSet<XSchemaTableStatistic> XSchemaTableStatistics { get; set; }

    public virtual DbSet<XSchemaTableStatisticsWithBuffer> XSchemaTableStatisticsWithBuffers { get; set; }

    public virtual DbSet<XSchemaTablesWithFullTableScan> XSchemaTablesWithFullTableScans { get; set; }

    public virtual DbSet<XSession> XSessions { get; set; }

    public virtual DbSet<XStatementAnalysis> XStatementAnalyses { get; set; }

    public virtual DbSet<XStatementsWithErrorsOrWarning> XStatementsWithErrorsOrWarnings { get; set; }

    public virtual DbSet<XStatementsWithFullTableScan> XStatementsWithFullTableScans { get; set; }

    public virtual DbSet<XStatementsWithRuntimesIn95thPercentile> XStatementsWithRuntimesIn95thPercentiles { get; set; }

    public virtual DbSet<XStatementsWithSorting> XStatementsWithSortings { get; set; }

    public virtual DbSet<XStatementsWithTempTable> XStatementsWithTempTables { get; set; }

    public virtual DbSet<XUserSummary> XUserSummaries { get; set; }

    public virtual DbSet<XUserSummaryByFileIo> XUserSummaryByFileIos { get; set; }

    public virtual DbSet<XUserSummaryByFileIoType> XUserSummaryByFileIoTypes { get; set; }

    public virtual DbSet<XUserSummaryByStage> XUserSummaryByStages { get; set; }

    public virtual DbSet<XUserSummaryByStatementLatency> XUserSummaryByStatementLatencies { get; set; }

    public virtual DbSet<XUserSummaryByStatementType> XUserSummaryByStatementTypes { get; set; }

    public virtual DbSet<XWaitClassesGlobalByAvgLatency> XWaitClassesGlobalByAvgLatencies { get; set; }

    public virtual DbSet<XWaitClassesGlobalByLatency> XWaitClassesGlobalByLatencies { get; set; }

    public virtual DbSet<XWaitsByHostByLatency> XWaitsByHostByLatencies { get; set; }

    public virtual DbSet<XWaitsByUserByLatency> XWaitsByUserByLatencies { get; set; }

    public virtual DbSet<XWaitsGlobalByLatency> XWaitsGlobalByLatencies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("name=ToDoDB", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.40-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<HostSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("host_summary");

            entity.Property(e => e.CurrentConnections)
                .HasPrecision(41)
                .HasColumnName("current_connections");
            entity.Property(e => e.CurrentMemory)
                .HasMaxLength(11)
                .HasColumnName("current_memory")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FileIoLatency)
                .HasMaxLength(11)
                .HasColumnName("file_io_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FileIos)
                .HasPrecision(64)
                .HasColumnName("file_ios");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.StatementAvgLatency)
                .HasMaxLength(11)
                .HasColumnName("statement_avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.StatementLatency)
                .HasMaxLength(11)
                .HasColumnName("statement_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Statements)
                .HasPrecision(64)
                .HasColumnName("statements");
            entity.Property(e => e.TableScans).HasColumnName("table_scans");
            entity.Property(e => e.TotalConnections)
                .HasPrecision(41)
                .HasColumnName("total_connections");
            entity.Property(e => e.TotalMemoryAllocated)
                .HasMaxLength(11)
                .HasColumnName("total_memory_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UniqueUsers).HasColumnName("unique_users");
        });

        modelBuilder.Entity<HostSummaryByFileIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("host_summary_by_file_io");

            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.IoLatency)
                .HasMaxLength(11)
                .HasColumnName("io_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Ios)
                .HasPrecision(42)
                .HasColumnName("ios");
        });

        modelBuilder.Entity<HostSummaryByFileIoType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("host_summary_by_file_io_type");

            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<HostSummaryByStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("host_summary_by_stages");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<HostSummaryByStatementLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("host_summary_by_statement_latency");

            entity.Property(e => e.CpuLatency)
                .HasMaxLength(11)
                .HasColumnName("cpu_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FullScans)
                .HasPrecision(43)
                .HasColumnName("full_scans");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.LockLatency)
                .HasMaxLength(11)
                .HasColumnName("lock_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.RowsAffected)
                .HasPrecision(42)
                .HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined)
                .HasPrecision(42)
                .HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent)
                .HasPrecision(42)
                .HasColumnName("rows_sent");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<HostSummaryByStatementType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("host_summary_by_statement_type");

            entity.Property(e => e.CpuLatency)
                .HasMaxLength(11)
                .HasColumnName("cpu_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FullScans).HasColumnName("full_scans");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.LockLatency)
                .HasMaxLength(11)
                .HasColumnName("lock_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Statement)
                .HasMaxLength(128)
                .HasColumnName("statement");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<InnodbBufferStatsBySchema>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("innodb_buffer_stats_by_schema");

            entity.Property(e => e.Allocated)
                .HasMaxLength(11)
                .HasColumnName("allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Data)
                .HasMaxLength(11)
                .HasColumnName("data")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ObjectSchema)
                .HasColumnType("text")
                .HasColumnName("object_schema")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Pages).HasColumnName("pages");
            entity.Property(e => e.PagesHashed).HasColumnName("pages_hashed");
            entity.Property(e => e.PagesOld).HasColumnName("pages_old");
            entity.Property(e => e.RowsCached)
                .HasPrecision(45)
                .HasColumnName("rows_cached");
        });

        modelBuilder.Entity<InnodbBufferStatsByTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("innodb_buffer_stats_by_table");

            entity.Property(e => e.Allocated)
                .HasMaxLength(11)
                .HasColumnName("allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Data)
                .HasMaxLength(11)
                .HasColumnName("data")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ObjectName)
                .HasColumnType("text")
                .HasColumnName("object_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ObjectSchema)
                .HasColumnType("text")
                .HasColumnName("object_schema")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Pages).HasColumnName("pages");
            entity.Property(e => e.PagesHashed).HasColumnName("pages_hashed");
            entity.Property(e => e.PagesOld).HasColumnName("pages_old");
            entity.Property(e => e.RowsCached)
                .HasPrecision(45)
                .HasColumnName("rows_cached");
        });

        modelBuilder.Entity<InnodbLockWait>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("innodb_lock_waits");

            entity.Property(e => e.BlockingLockId)
                .HasMaxLength(128)
                .HasColumnName("blocking_lock_id");
            entity.Property(e => e.BlockingLockMode)
                .HasMaxLength(32)
                .HasColumnName("blocking_lock_mode");
            entity.Property(e => e.BlockingPid).HasColumnName("blocking_pid");
            entity.Property(e => e.BlockingQuery).HasColumnName("blocking_query");
            entity.Property(e => e.BlockingTrxAge)
                .HasColumnType("time")
                .HasColumnName("blocking_trx_age");
            entity.Property(e => e.BlockingTrxId).HasColumnName("blocking_trx_id");
            entity.Property(e => e.BlockingTrxRowsLocked).HasColumnName("blocking_trx_rows_locked");
            entity.Property(e => e.BlockingTrxRowsModified).HasColumnName("blocking_trx_rows_modified");
            entity.Property(e => e.BlockingTrxStarted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("blocking_trx_started");
            entity.Property(e => e.LockedIndex)
                .HasMaxLength(64)
                .HasColumnName("locked_index");
            entity.Property(e => e.LockedTable)
                .HasColumnType("mediumtext")
                .HasColumnName("locked_table");
            entity.Property(e => e.LockedTableName)
                .HasMaxLength(64)
                .HasColumnName("locked_table_name");
            entity.Property(e => e.LockedTablePartition)
                .HasMaxLength(64)
                .HasColumnName("locked_table_partition");
            entity.Property(e => e.LockedTableSchema)
                .HasMaxLength(64)
                .HasColumnName("locked_table_schema");
            entity.Property(e => e.LockedTableSubpartition)
                .HasMaxLength(64)
                .HasColumnName("locked_table_subpartition");
            entity.Property(e => e.LockedType)
                .HasMaxLength(32)
                .HasColumnName("locked_type");
            entity.Property(e => e.SqlKillBlockingConnection)
                .HasMaxLength(27)
                .HasDefaultValueSql("''")
                .HasColumnName("sql_kill_blocking_connection");
            entity.Property(e => e.SqlKillBlockingQuery)
                .HasMaxLength(33)
                .HasDefaultValueSql("''")
                .HasColumnName("sql_kill_blocking_query");
            entity.Property(e => e.WaitAge)
                .HasColumnType("time")
                .HasColumnName("wait_age");
            entity.Property(e => e.WaitAgeSecs).HasColumnName("wait_age_secs");
            entity.Property(e => e.WaitStarted)
                .HasColumnType("datetime")
                .HasColumnName("wait_started");
            entity.Property(e => e.WaitingLockId)
                .HasMaxLength(128)
                .HasColumnName("waiting_lock_id");
            entity.Property(e => e.WaitingLockMode)
                .HasMaxLength(32)
                .HasColumnName("waiting_lock_mode");
            entity.Property(e => e.WaitingPid).HasColumnName("waiting_pid");
            entity.Property(e => e.WaitingQuery).HasColumnName("waiting_query");
            entity.Property(e => e.WaitingTrxAge)
                .HasColumnType("time")
                .HasColumnName("waiting_trx_age");
            entity.Property(e => e.WaitingTrxId).HasColumnName("waiting_trx_id");
            entity.Property(e => e.WaitingTrxRowsLocked).HasColumnName("waiting_trx_rows_locked");
            entity.Property(e => e.WaitingTrxRowsModified).HasColumnName("waiting_trx_rows_modified");
            entity.Property(e => e.WaitingTrxStarted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("waiting_trx_started");
        });

        modelBuilder.Entity<IoByThreadByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("io_by_thread_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MinLatency)
                .HasMaxLength(11)
                .HasColumnName("min_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ProcesslistId).HasColumnName("processlist_id");
            entity.Property(e => e.ThreadId).HasColumnName("thread_id");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<IoGlobalByFileByByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("io_global_by_file_by_bytes");

            entity.Property(e => e.AvgRead)
                .HasMaxLength(11)
                .HasColumnName("avg_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AvgWrite)
                .HasMaxLength(11)
                .HasColumnName("avg_write")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.File)
                .HasMaxLength(512)
                .HasColumnName("file");
            entity.Property(e => e.Total)
                .HasMaxLength(11)
                .HasColumnName("total")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalRead)
                .HasMaxLength(11)
                .HasColumnName("total_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalWritten)
                .HasMaxLength(11)
                .HasColumnName("total_written")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.WritePct)
                .HasPrecision(26, 2)
                .HasColumnName("write_pct");
        });

        modelBuilder.Entity<IoGlobalByFileByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("io_global_by_file_by_latency");

            entity.Property(e => e.CountMisc).HasColumnName("count_misc");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.File)
                .HasMaxLength(512)
                .HasColumnName("file");
            entity.Property(e => e.MiscLatency)
                .HasMaxLength(11)
                .HasColumnName("misc_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ReadLatency)
                .HasMaxLength(11)
                .HasColumnName("read_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.WriteLatency)
                .HasMaxLength(11)
                .HasColumnName("write_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<IoGlobalByWaitByByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("io_global_by_wait_by_bytes");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AvgRead)
                .HasMaxLength(11)
                .HasColumnName("avg_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AvgWritten)
                .HasMaxLength(11)
                .HasColumnName("avg_written")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MinLatency)
                .HasMaxLength(11)
                .HasColumnName("min_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalRead)
                .HasMaxLength(11)
                .HasColumnName("total_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalRequested)
                .HasMaxLength(11)
                .HasColumnName("total_requested")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalWritten)
                .HasMaxLength(11)
                .HasColumnName("total_written")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<IoGlobalByWaitByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("io_global_by_wait_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AvgRead)
                .HasMaxLength(11)
                .HasColumnName("avg_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.AvgWritten)
                .HasMaxLength(11)
                .HasColumnName("avg_written")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MiscLatency)
                .HasMaxLength(11)
                .HasColumnName("misc_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ReadLatency)
                .HasMaxLength(11)
                .HasColumnName("read_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalRead)
                .HasMaxLength(11)
                .HasColumnName("total_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalWritten)
                .HasMaxLength(11)
                .HasColumnName("total_written")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.WriteLatency)
                .HasMaxLength(11)
                .HasColumnName("write_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("items");

            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<LatestFileIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("latest_file_io");

            entity.Property(e => e.File)
                .HasMaxLength(512)
                .HasColumnName("file");
            entity.Property(e => e.Latency)
                .HasMaxLength(11)
                .HasColumnName("latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Operation)
                .HasMaxLength(32)
                .HasColumnName("operation");
            entity.Property(e => e.Requested)
                .HasMaxLength(11)
                .HasColumnName("requested")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Thread)
                .HasMaxLength(317)
                .HasColumnName("thread");
        });

        modelBuilder.Entity<MemoryByHostByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("memory_by_host_by_current_bytes");

            entity.Property(e => e.CurrentAllocated)
                .HasMaxLength(11)
                .HasColumnName("current_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_avg_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentCountUsed)
                .HasPrecision(41)
                .HasColumnName("current_count_used");
            entity.Property(e => e.CurrentMaxAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_max_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.TotalAllocated)
                .HasMaxLength(11)
                .HasColumnName("total_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<MemoryByThreadByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("memory_by_thread_by_current_bytes");

            entity.Property(e => e.CurrentAllocated)
                .HasMaxLength(11)
                .HasColumnName("current_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_avg_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentCountUsed)
                .HasPrecision(41)
                .HasColumnName("current_count_used");
            entity.Property(e => e.CurrentMaxAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_max_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ThreadId).HasColumnName("thread_id");
            entity.Property(e => e.TotalAllocated)
                .HasMaxLength(11)
                .HasColumnName("total_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<MemoryByUserByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("memory_by_user_by_current_bytes");

            entity.Property(e => e.CurrentAllocated)
                .HasMaxLength(11)
                .HasColumnName("current_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_avg_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentCountUsed)
                .HasPrecision(41)
                .HasColumnName("current_count_used");
            entity.Property(e => e.CurrentMaxAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_max_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TotalAllocated)
                .HasMaxLength(11)
                .HasColumnName("total_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<MemoryGlobalByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("memory_global_by_current_bytes");

            entity.Property(e => e.CurrentAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasMaxLength(11)
                .HasColumnName("current_avg_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentCount).HasColumnName("current_count");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.HighAlloc)
                .HasMaxLength(11)
                .HasColumnName("high_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.HighAvgAlloc)
                .HasMaxLength(11)
                .HasColumnName("high_avg_alloc")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.HighCount).HasColumnName("high_count");
        });

        modelBuilder.Entity<MemoryGlobalTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("memory_global_total");

            entity.Property(e => e.TotalAllocated)
                .HasMaxLength(11)
                .HasColumnName("total_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<Metric>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("metrics");

            entity.Property(e => e.Enabled)
                .HasMaxLength(7)
                .HasDefaultValueSql("''");
            entity.Property(e => e.Type)
                .HasMaxLength(210)
                .HasDefaultValueSql("''")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.VariableName)
                .HasMaxLength(193)
                .HasDefaultValueSql("''")
                .HasColumnName("Variable_name");
            entity.Property(e => e.VariableValue)
                .HasColumnType("text")
                .HasColumnName("Variable_value");
        });

        modelBuilder.Entity<Processlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("processlist");

            entity.Property(e => e.Command)
                .HasMaxLength(16)
                .HasColumnName("command");
            entity.Property(e => e.ConnId).HasColumnName("conn_id");
            entity.Property(e => e.CpuLatency)
                .HasMaxLength(11)
                .HasColumnName("cpu_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentMemory)
                .HasMaxLength(11)
                .HasColumnName("current_memory")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentStatement).HasColumnName("current_statement");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.ExecutionEngine)
                .HasColumnType("enum('PRIMARY','SECONDARY')")
                .HasColumnName("execution_engine");
            entity.Property(e => e.FullScan)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastStatement).HasColumnName("last_statement");
            entity.Property(e => e.LastStatementLatency)
                .HasMaxLength(11)
                .HasColumnName("last_statement_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.LastWait)
                .HasMaxLength(128)
                .HasColumnName("last_wait");
            entity.Property(e => e.LastWaitLatency)
                .HasMaxLength(13)
                .HasColumnName("last_wait_latency");
            entity.Property(e => e.LockLatency)
                .HasMaxLength(11)
                .HasColumnName("lock_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Pid)
                .HasMaxLength(1024)
                .HasColumnName("pid")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(1024)
                .HasColumnName("program_name")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.Progress)
                .HasPrecision(26, 2)
                .HasColumnName("progress");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Source)
                .HasMaxLength(64)
                .HasColumnName("source");
            entity.Property(e => e.State)
                .HasMaxLength(64)
                .HasColumnName("state");
            entity.Property(e => e.StatementLatency)
                .HasMaxLength(11)
                .HasColumnName("statement_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ThdId).HasColumnName("thd_id");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.TmpDiskTables).HasColumnName("tmp_disk_tables");
            entity.Property(e => e.TmpTables).HasColumnName("tmp_tables");
            entity.Property(e => e.TrxAutocommit)
                .HasColumnType("enum('YES','NO')")
                .HasColumnName("trx_autocommit");
            entity.Property(e => e.TrxLatency)
                .HasMaxLength(11)
                .HasColumnName("trx_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TrxState)
                .HasColumnType("enum('ACTIVE','COMMITTED','ROLLED BACK')")
                .HasColumnName("trx_state");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<PsCheckLostInstrumentation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ps_check_lost_instrumentation");

            entity.Property(e => e.VariableName)
                .HasMaxLength(64)
                .HasColumnName("variable_name");
            entity.Property(e => e.VariableValue)
                .HasMaxLength(1024)
                .HasColumnName("variable_value");
        });

        modelBuilder.Entity<SchemaAutoIncrementColumn>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_auto_increment_columns");

            entity.Property(e => e.AutoIncrement).HasColumnName("auto_increment");
            entity.Property(e => e.AutoIncrementRatio)
                .HasColumnType("decimal(25,4) unsigned")
                .HasColumnName("auto_increment_ratio");
            entity.Property(e => e.ColumnName)
                .HasMaxLength(64)
                .HasColumnName("column_name")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ColumnType)
                .HasColumnType("mediumtext")
                .HasColumnName("column_type")
                .UseCollation("utf8mb3_bin")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.DataType)
                .HasColumnName("data_type")
                .UseCollation("utf8mb3_bin")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IsSigned).HasColumnName("is_signed");
            entity.Property(e => e.IsUnsigned).HasColumnName("is_unsigned");
            entity.Property(e => e.MaxValue).HasColumnName("max_value");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<SchemaIndexStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_index_statistics");

            entity.Property(e => e.DeleteLatency)
                .HasMaxLength(11)
                .HasColumnName("delete_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IndexName)
                .HasMaxLength(64)
                .HasColumnName("index_name");
            entity.Property(e => e.InsertLatency)
                .HasMaxLength(11)
                .HasColumnName("insert_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.RowsDeleted).HasColumnName("rows_deleted");
            entity.Property(e => e.RowsInserted).HasColumnName("rows_inserted");
            entity.Property(e => e.RowsSelected).HasColumnName("rows_selected");
            entity.Property(e => e.RowsUpdated).HasColumnName("rows_updated");
            entity.Property(e => e.SelectLatency)
                .HasMaxLength(11)
                .HasColumnName("select_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema");
            entity.Property(e => e.UpdateLatency)
                .HasMaxLength(11)
                .HasColumnName("update_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<SchemaObjectOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_object_overview");

            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ObjectType)
                .HasMaxLength(19)
                .HasColumnName("object_type")
                .UseCollation("utf8mb3_bin")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<SchemaRedundantIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_redundant_indexes");

            entity.Property(e => e.DominantIndexColumns)
                .HasColumnType("text")
                .HasColumnName("dominant_index_columns")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.DominantIndexName)
                .HasMaxLength(64)
                .HasColumnName("dominant_index_name")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.DominantIndexNonUnique).HasColumnName("dominant_index_non_unique");
            entity.Property(e => e.RedundantIndexColumns)
                .HasColumnType("text")
                .HasColumnName("redundant_index_columns")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.RedundantIndexName)
                .HasMaxLength(64)
                .HasColumnName("redundant_index_name")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.RedundantIndexNonUnique).HasColumnName("redundant_index_non_unique");
            entity.Property(e => e.SqlDropIndex)
                .HasMaxLength(223)
                .HasColumnName("sql_drop_index")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.SubpartExists).HasColumnName("subpart_exists");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<SchemaTableLockWait>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_table_lock_waits");

            entity.Property(e => e.BlockingAccount)
                .HasColumnType("text")
                .HasColumnName("blocking_account");
            entity.Property(e => e.BlockingLockDuration)
                .HasMaxLength(32)
                .HasColumnName("blocking_lock_duration");
            entity.Property(e => e.BlockingLockType)
                .HasMaxLength(32)
                .HasColumnName("blocking_lock_type");
            entity.Property(e => e.BlockingPid).HasColumnName("blocking_pid");
            entity.Property(e => e.BlockingThreadId).HasColumnName("blocking_thread_id");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(64)
                .HasColumnName("object_name");
            entity.Property(e => e.ObjectSchema)
                .HasMaxLength(64)
                .HasColumnName("object_schema");
            entity.Property(e => e.SqlKillBlockingConnection)
                .HasMaxLength(25)
                .HasColumnName("sql_kill_blocking_connection");
            entity.Property(e => e.SqlKillBlockingQuery)
                .HasMaxLength(31)
                .HasColumnName("sql_kill_blocking_query");
            entity.Property(e => e.WaitingAccount)
                .HasColumnType("text")
                .HasColumnName("waiting_account");
            entity.Property(e => e.WaitingLockDuration)
                .HasMaxLength(32)
                .HasColumnName("waiting_lock_duration");
            entity.Property(e => e.WaitingLockType)
                .HasMaxLength(32)
                .HasColumnName("waiting_lock_type");
            entity.Property(e => e.WaitingPid).HasColumnName("waiting_pid");
            entity.Property(e => e.WaitingQuery).HasColumnName("waiting_query");
            entity.Property(e => e.WaitingQueryRowsAffected).HasColumnName("waiting_query_rows_affected");
            entity.Property(e => e.WaitingQueryRowsExamined).HasColumnName("waiting_query_rows_examined");
            entity.Property(e => e.WaitingQuerySecs).HasColumnName("waiting_query_secs");
            entity.Property(e => e.WaitingThreadId).HasColumnName("waiting_thread_id");
        });

        modelBuilder.Entity<SchemaTableStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_table_statistics");

            entity.Property(e => e.DeleteLatency)
                .HasMaxLength(11)
                .HasColumnName("delete_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FetchLatency)
                .HasMaxLength(11)
                .HasColumnName("fetch_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.InsertLatency)
                .HasMaxLength(11)
                .HasColumnName("insert_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoMiscLatency)
                .HasMaxLength(11)
                .HasColumnName("io_misc_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoMiscRequests)
                .HasPrecision(42)
                .HasColumnName("io_misc_requests");
            entity.Property(e => e.IoRead)
                .HasMaxLength(11)
                .HasColumnName("io_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoReadLatency)
                .HasMaxLength(11)
                .HasColumnName("io_read_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoReadRequests)
                .HasPrecision(42)
                .HasColumnName("io_read_requests");
            entity.Property(e => e.IoWrite)
                .HasMaxLength(11)
                .HasColumnName("io_write")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoWriteLatency)
                .HasMaxLength(11)
                .HasColumnName("io_write_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoWriteRequests)
                .HasPrecision(42)
                .HasColumnName("io_write_requests");
            entity.Property(e => e.RowsDeleted).HasColumnName("rows_deleted");
            entity.Property(e => e.RowsFetched).HasColumnName("rows_fetched");
            entity.Property(e => e.RowsInserted).HasColumnName("rows_inserted");
            entity.Property(e => e.RowsUpdated).HasColumnName("rows_updated");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UpdateLatency)
                .HasMaxLength(11)
                .HasColumnName("update_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<SchemaTableStatisticsWithBuffer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_table_statistics_with_buffer");

            entity.Property(e => e.DeleteLatency)
                .HasMaxLength(11)
                .HasColumnName("delete_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FetchLatency)
                .HasMaxLength(11)
                .HasColumnName("fetch_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.InnodbBufferAllocated)
                .HasMaxLength(11)
                .HasColumnName("innodb_buffer_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.InnodbBufferData)
                .HasMaxLength(11)
                .HasColumnName("innodb_buffer_data")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.InnodbBufferFree)
                .HasMaxLength(11)
                .HasColumnName("innodb_buffer_free")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.InnodbBufferPages)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_pages");
            entity.Property(e => e.InnodbBufferPagesHashed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_pages_hashed");
            entity.Property(e => e.InnodbBufferPagesOld)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_pages_old");
            entity.Property(e => e.InnodbBufferRowsCached)
                .HasPrecision(45)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_rows_cached");
            entity.Property(e => e.InsertLatency)
                .HasMaxLength(11)
                .HasColumnName("insert_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoMiscLatency)
                .HasMaxLength(11)
                .HasColumnName("io_misc_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoMiscRequests)
                .HasPrecision(42)
                .HasColumnName("io_misc_requests");
            entity.Property(e => e.IoRead)
                .HasMaxLength(11)
                .HasColumnName("io_read")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoReadLatency)
                .HasMaxLength(11)
                .HasColumnName("io_read_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoReadRequests)
                .HasPrecision(42)
                .HasColumnName("io_read_requests");
            entity.Property(e => e.IoWrite)
                .HasMaxLength(11)
                .HasColumnName("io_write")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoWriteLatency)
                .HasMaxLength(11)
                .HasColumnName("io_write_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IoWriteRequests)
                .HasPrecision(42)
                .HasColumnName("io_write_requests");
            entity.Property(e => e.RowsDeleted).HasColumnName("rows_deleted");
            entity.Property(e => e.RowsFetched).HasColumnName("rows_fetched");
            entity.Property(e => e.RowsInserted).HasColumnName("rows_inserted");
            entity.Property(e => e.RowsUpdated).HasColumnName("rows_updated");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema");
            entity.Property(e => e.UpdateLatency)
                .HasMaxLength(11)
                .HasColumnName("update_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<SchemaTablesWithFullTableScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_tables_with_full_table_scans");

            entity.Property(e => e.Latency)
                .HasMaxLength(11)
                .HasColumnName("latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(64)
                .HasColumnName("object_name");
            entity.Property(e => e.ObjectSchema)
                .HasMaxLength(64)
                .HasColumnName("object_schema");
            entity.Property(e => e.RowsFullScanned).HasColumnName("rows_full_scanned");
        });

        modelBuilder.Entity<SchemaUnusedIndex>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("schema_unused_indexes");

            entity.Property(e => e.IndexName)
                .HasMaxLength(64)
                .HasColumnName("index_name");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(64)
                .HasColumnName("object_name");
            entity.Property(e => e.ObjectSchema)
                .HasMaxLength(64)
                .HasColumnName("object_schema");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("session");

            entity.Property(e => e.Command)
                .HasMaxLength(16)
                .HasColumnName("command");
            entity.Property(e => e.ConnId).HasColumnName("conn_id");
            entity.Property(e => e.CpuLatency)
                .HasMaxLength(11)
                .HasColumnName("cpu_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentMemory)
                .HasMaxLength(11)
                .HasColumnName("current_memory")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CurrentStatement).HasColumnName("current_statement");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.ExecutionEngine)
                .HasColumnType("enum('PRIMARY','SECONDARY')")
                .HasColumnName("execution_engine");
            entity.Property(e => e.FullScan)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastStatement).HasColumnName("last_statement");
            entity.Property(e => e.LastStatementLatency)
                .HasMaxLength(11)
                .HasColumnName("last_statement_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.LastWait)
                .HasMaxLength(128)
                .HasColumnName("last_wait");
            entity.Property(e => e.LastWaitLatency)
                .HasMaxLength(13)
                .HasColumnName("last_wait_latency");
            entity.Property(e => e.LockLatency)
                .HasMaxLength(11)
                .HasColumnName("lock_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Pid)
                .HasMaxLength(1024)
                .HasColumnName("pid")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(1024)
                .HasColumnName("program_name")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.Progress)
                .HasPrecision(26, 2)
                .HasColumnName("progress");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Source)
                .HasMaxLength(64)
                .HasColumnName("source");
            entity.Property(e => e.State)
                .HasMaxLength(64)
                .HasColumnName("state");
            entity.Property(e => e.StatementLatency)
                .HasMaxLength(11)
                .HasColumnName("statement_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ThdId).HasColumnName("thd_id");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.TmpDiskTables).HasColumnName("tmp_disk_tables");
            entity.Property(e => e.TmpTables).HasColumnName("tmp_tables");
            entity.Property(e => e.TrxAutocommit)
                .HasColumnType("enum('YES','NO')")
                .HasColumnName("trx_autocommit");
            entity.Property(e => e.TrxLatency)
                .HasMaxLength(11)
                .HasColumnName("trx_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TrxState)
                .HasColumnType("enum('ACTIVE','COMMITTED','ROLLED BACK')")
                .HasColumnName("trx_state");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<SessionSslStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("session_ssl_status");

            entity.Property(e => e.SslCipher)
                .HasMaxLength(1024)
                .HasColumnName("ssl_cipher");
            entity.Property(e => e.SslSessionsReused)
                .HasMaxLength(1024)
                .HasColumnName("ssl_sessions_reused");
            entity.Property(e => e.SslVersion)
                .HasMaxLength(1024)
                .HasColumnName("ssl_version");
            entity.Property(e => e.ThreadId).HasColumnName("thread_id");
        });

        modelBuilder.Entity<StatementAnalysis>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("statement_analysis");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.CpuLatency)
                .HasMaxLength(11)
                .HasColumnName("cpu_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ErrCount).HasColumnName("err_count");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.FullScan)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.LockLatency)
                .HasMaxLength(11)
                .HasColumnName("lock_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxControlledMemory)
                .HasMaxLength(11)
                .HasColumnName("max_controlled_memory")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxTotalMemory)
                .HasMaxLength(11)
                .HasColumnName("max_total_memory")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsAffectedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_affected_avg");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsExaminedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_examined_avg");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.RowsSentAvg)
                .HasPrecision(21)
                .HasColumnName("rows_sent_avg");
            entity.Property(e => e.RowsSorted).HasColumnName("rows_sorted");
            entity.Property(e => e.SortMergePasses).HasColumnName("sort_merge_passes");
            entity.Property(e => e.TmpDiskTables).HasColumnName("tmp_disk_tables");
            entity.Property(e => e.TmpTables).HasColumnName("tmp_tables");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.WarnCount).HasColumnName("warn_count");
        });

        modelBuilder.Entity<StatementsWithErrorsOrWarning>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("statements_with_errors_or_warnings");

            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ErrorPct)
                .HasPrecision(27, 4)
                .HasColumnName("error_pct");
            entity.Property(e => e.Errors).HasColumnName("errors");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.WarningPct)
                .HasPrecision(27, 4)
                .HasColumnName("warning_pct");
            entity.Property(e => e.Warnings).HasColumnName("warnings");
        });

        modelBuilder.Entity<StatementsWithFullTableScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("statements_with_full_table_scans");

            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.NoGoodIndexUsedCount).HasColumnName("no_good_index_used_count");
            entity.Property(e => e.NoIndexUsedCount).HasColumnName("no_index_used_count");
            entity.Property(e => e.NoIndexUsedPct)
                .HasPrecision(24)
                .HasColumnName("no_index_used_pct");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsExaminedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_examined_avg");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.RowsSentAvg)
                .HasPrecision(21)
                .HasColumnName("rows_sent_avg");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<StatementsWithRuntimesIn95thPercentile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("statements_with_runtimes_in_95th_percentile");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ErrCount).HasColumnName("err_count");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.FullScan)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsExaminedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_examined_avg");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.RowsSentAvg)
                .HasPrecision(21)
                .HasColumnName("rows_sent_avg");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.WarnCount).HasColumnName("warn_count");
        });

        modelBuilder.Entity<StatementsWithSorting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("statements_with_sorting");

            entity.Property(e => e.AvgRowsSorted)
                .HasPrecision(21)
                .HasColumnName("avg_rows_sorted");
            entity.Property(e => e.AvgSortMerges)
                .HasPrecision(21)
                .HasColumnName("avg_sort_merges");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsSorted).HasColumnName("rows_sorted");
            entity.Property(e => e.SortMergePasses).HasColumnName("sort_merge_passes");
            entity.Property(e => e.SortUsingRange).HasColumnName("sort_using_range");
            entity.Property(e => e.SortsUsingScans).HasColumnName("sorts_using_scans");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<StatementsWithTempTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("statements_with_temp_tables");

            entity.Property(e => e.AvgTmpTablesPerQuery)
                .HasPrecision(21)
                .HasColumnName("avg_tmp_tables_per_query");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.DiskTmpTables).HasColumnName("disk_tmp_tables");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.MemoryTmpTables).HasColumnName("memory_tmp_tables");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.TmpTablesToDiskPct)
                .HasPrecision(24)
                .HasColumnName("tmp_tables_to_disk_pct");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<SysConfig>(entity =>
        {
            entity.HasKey(e => e.Variable).HasName("PRIMARY");

            entity.ToTable("sys_config");

            entity.Property(e => e.Variable)
                .HasMaxLength(128)
                .HasColumnName("variable");
            entity.Property(e => e.SetBy)
                .HasMaxLength(128)
                .HasColumnName("set_by");
            entity.Property(e => e.SetTime)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("set_time");
            entity.Property(e => e.Value)
                .HasMaxLength(128)
                .HasColumnName("value");
        });

        modelBuilder.Entity<UserSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("user_summary");

            entity.Property(e => e.CurrentConnections)
                .HasPrecision(41)
                .HasColumnName("current_connections");
            entity.Property(e => e.CurrentMemory)
                .HasMaxLength(11)
                .HasColumnName("current_memory")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FileIoLatency)
                .HasMaxLength(11)
                .HasColumnName("file_io_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FileIos)
                .HasPrecision(64)
                .HasColumnName("file_ios");
            entity.Property(e => e.StatementAvgLatency)
                .HasMaxLength(11)
                .HasColumnName("statement_avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.StatementLatency)
                .HasMaxLength(11)
                .HasColumnName("statement_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Statements)
                .HasPrecision(64)
                .HasColumnName("statements");
            entity.Property(e => e.TableScans).HasColumnName("table_scans");
            entity.Property(e => e.TotalConnections)
                .HasPrecision(41)
                .HasColumnName("total_connections");
            entity.Property(e => e.TotalMemoryAllocated)
                .HasMaxLength(11)
                .HasColumnName("total_memory_allocated")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.UniqueHosts).HasColumnName("unique_hosts");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<UserSummaryByFileIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("user_summary_by_file_io");

            entity.Property(e => e.IoLatency)
                .HasMaxLength(11)
                .HasColumnName("io_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Ios)
                .HasPrecision(42)
                .HasColumnName("ios");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<UserSummaryByFileIoType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("user_summary_by_file_io_type");

            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Latency)
                .HasMaxLength(11)
                .HasColumnName("latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<UserSummaryByStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("user_summary_by_stages");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<UserSummaryByStatementLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("user_summary_by_statement_latency");

            entity.Property(e => e.CpuLatency)
                .HasMaxLength(11)
                .HasColumnName("cpu_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FullScans)
                .HasPrecision(43)
                .HasColumnName("full_scans");
            entity.Property(e => e.LockLatency)
                .HasMaxLength(11)
                .HasColumnName("lock_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.RowsAffected)
                .HasPrecision(42)
                .HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined)
                .HasPrecision(42)
                .HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent)
                .HasPrecision(42)
                .HasColumnName("rows_sent");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<UserSummaryByStatementType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("user_summary_by_statement_type");

            entity.Property(e => e.CpuLatency)
                .HasMaxLength(11)
                .HasColumnName("cpu_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.FullScans).HasColumnName("full_scans");
            entity.Property(e => e.LockLatency)
                .HasMaxLength(11)
                .HasColumnName("lock_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Statement)
                .HasMaxLength(128)
                .HasColumnName("statement");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<Version>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("version");

            entity.Property(e => e.MysqlVersion)
                .HasMaxLength(6)
                .HasDefaultValueSql("''")
                .HasColumnName("mysql_version")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.SysVersion)
                .HasMaxLength(5)
                .HasDefaultValueSql("''")
                .HasColumnName("sys_version");
        });

        modelBuilder.Entity<WaitClassesGlobalByAvgLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wait_classes_global_by_avg_latency");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.EventClass)
                .HasMaxLength(128)
                .HasColumnName("event_class");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MinLatency)
                .HasMaxLength(11)
                .HasColumnName("min_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<WaitClassesGlobalByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wait_classes_global_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.EventClass)
                .HasMaxLength(128)
                .HasColumnName("event_class");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.MinLatency)
                .HasMaxLength(11)
                .HasColumnName("min_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<WaitsByHostByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("waits_by_host_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasColumnName("event");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<WaitsByUserByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("waits_by_user_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasColumnName("event");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<WaitsGlobalByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("waits_global_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasMaxLength(11)
                .HasColumnName("avg_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Events)
                .HasMaxLength(128)
                .HasColumnName("events");
            entity.Property(e => e.MaxLatency)
                .HasMaxLength(11)
                .HasColumnName("max_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasMaxLength(11)
                .HasColumnName("total_latency")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<XHostSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$host_summary");

            entity.Property(e => e.CurrentConnections)
                .HasPrecision(41)
                .HasColumnName("current_connections");
            entity.Property(e => e.CurrentMemory)
                .HasPrecision(63)
                .HasColumnName("current_memory");
            entity.Property(e => e.FileIoLatency)
                .HasPrecision(64)
                .HasColumnName("file_io_latency");
            entity.Property(e => e.FileIos)
                .HasPrecision(64)
                .HasColumnName("file_ios");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.StatementAvgLatency).HasColumnName("statement_avg_latency");
            entity.Property(e => e.StatementLatency)
                .HasPrecision(64)
                .HasColumnName("statement_latency");
            entity.Property(e => e.Statements)
                .HasPrecision(64)
                .HasColumnName("statements");
            entity.Property(e => e.TableScans).HasColumnName("table_scans");
            entity.Property(e => e.TotalConnections)
                .HasPrecision(41)
                .HasColumnName("total_connections");
            entity.Property(e => e.TotalMemoryAllocated)
                .HasPrecision(64)
                .HasColumnName("total_memory_allocated");
            entity.Property(e => e.UniqueUsers).HasColumnName("unique_users");
        });

        modelBuilder.Entity<XHostSummaryByFileIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$host_summary_by_file_io");

            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.IoLatency)
                .HasPrecision(42)
                .HasColumnName("io_latency");
            entity.Property(e => e.Ios)
                .HasPrecision(42)
                .HasColumnName("ios");
        });

        modelBuilder.Entity<XHostSummaryByFileIoType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$host_summary_by_file_io_type");

            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        modelBuilder.Entity<XHostSummaryByStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$host_summary_by_stages");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        modelBuilder.Entity<XHostSummaryByStatementLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$host_summary_by_statement_latency");

            entity.Property(e => e.CpuLatency)
                .HasPrecision(42)
                .HasColumnName("cpu_latency");
            entity.Property(e => e.FullScans)
                .HasPrecision(43)
                .HasColumnName("full_scans");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.LockLatency)
                .HasPrecision(42)
                .HasColumnName("lock_latency");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.RowsAffected)
                .HasPrecision(42)
                .HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined)
                .HasPrecision(42)
                .HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent)
                .HasPrecision(42)
                .HasColumnName("rows_sent");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasPrecision(42)
                .HasColumnName("total_latency");
        });

        modelBuilder.Entity<XHostSummaryByStatementType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$host_summary_by_statement_type");

            entity.Property(e => e.CpuLatency).HasColumnName("cpu_latency");
            entity.Property(e => e.FullScans).HasColumnName("full_scans");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.LockLatency).HasColumnName("lock_latency");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Statement)
                .HasMaxLength(128)
                .HasColumnName("statement");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        modelBuilder.Entity<XInnodbBufferStatsBySchema>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$innodb_buffer_stats_by_schema");

            entity.Property(e => e.Allocated)
                .HasPrecision(44)
                .HasColumnName("allocated");
            entity.Property(e => e.Data)
                .HasPrecision(44)
                .HasColumnName("data");
            entity.Property(e => e.ObjectSchema)
                .HasColumnType("text")
                .HasColumnName("object_schema")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Pages).HasColumnName("pages");
            entity.Property(e => e.PagesHashed).HasColumnName("pages_hashed");
            entity.Property(e => e.PagesOld).HasColumnName("pages_old");
            entity.Property(e => e.RowsCached)
                .HasPrecision(45)
                .HasColumnName("rows_cached");
        });

        modelBuilder.Entity<XInnodbBufferStatsByTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$innodb_buffer_stats_by_table");

            entity.Property(e => e.Allocated)
                .HasPrecision(44)
                .HasColumnName("allocated");
            entity.Property(e => e.Data)
                .HasPrecision(44)
                .HasColumnName("data");
            entity.Property(e => e.ObjectName)
                .HasColumnType("text")
                .HasColumnName("object_name")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.ObjectSchema)
                .HasColumnType("text")
                .HasColumnName("object_schema")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.Pages).HasColumnName("pages");
            entity.Property(e => e.PagesHashed).HasColumnName("pages_hashed");
            entity.Property(e => e.PagesOld).HasColumnName("pages_old");
            entity.Property(e => e.RowsCached)
                .HasPrecision(45)
                .HasColumnName("rows_cached");
        });

        modelBuilder.Entity<XInnodbLockWait>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$innodb_lock_waits");

            entity.Property(e => e.BlockingLockId)
                .HasMaxLength(128)
                .HasColumnName("blocking_lock_id");
            entity.Property(e => e.BlockingLockMode)
                .HasMaxLength(32)
                .HasColumnName("blocking_lock_mode");
            entity.Property(e => e.BlockingPid).HasColumnName("blocking_pid");
            entity.Property(e => e.BlockingQuery)
                .HasMaxLength(1024)
                .HasColumnName("blocking_query")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.BlockingTrxAge)
                .HasColumnType("time")
                .HasColumnName("blocking_trx_age");
            entity.Property(e => e.BlockingTrxId).HasColumnName("blocking_trx_id");
            entity.Property(e => e.BlockingTrxRowsLocked).HasColumnName("blocking_trx_rows_locked");
            entity.Property(e => e.BlockingTrxRowsModified).HasColumnName("blocking_trx_rows_modified");
            entity.Property(e => e.BlockingTrxStarted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("blocking_trx_started");
            entity.Property(e => e.LockedIndex)
                .HasMaxLength(64)
                .HasColumnName("locked_index");
            entity.Property(e => e.LockedTable)
                .HasColumnType("mediumtext")
                .HasColumnName("locked_table");
            entity.Property(e => e.LockedTableName)
                .HasMaxLength(64)
                .HasColumnName("locked_table_name");
            entity.Property(e => e.LockedTablePartition)
                .HasMaxLength(64)
                .HasColumnName("locked_table_partition");
            entity.Property(e => e.LockedTableSchema)
                .HasMaxLength(64)
                .HasColumnName("locked_table_schema");
            entity.Property(e => e.LockedTableSubpartition)
                .HasMaxLength(64)
                .HasColumnName("locked_table_subpartition");
            entity.Property(e => e.LockedType)
                .HasMaxLength(32)
                .HasColumnName("locked_type");
            entity.Property(e => e.SqlKillBlockingConnection)
                .HasMaxLength(27)
                .HasDefaultValueSql("''")
                .HasColumnName("sql_kill_blocking_connection");
            entity.Property(e => e.SqlKillBlockingQuery)
                .HasMaxLength(33)
                .HasDefaultValueSql("''")
                .HasColumnName("sql_kill_blocking_query");
            entity.Property(e => e.WaitAge)
                .HasColumnType("time")
                .HasColumnName("wait_age");
            entity.Property(e => e.WaitAgeSecs).HasColumnName("wait_age_secs");
            entity.Property(e => e.WaitStarted)
                .HasColumnType("datetime")
                .HasColumnName("wait_started");
            entity.Property(e => e.WaitingLockId)
                .HasMaxLength(128)
                .HasColumnName("waiting_lock_id");
            entity.Property(e => e.WaitingLockMode)
                .HasMaxLength(32)
                .HasColumnName("waiting_lock_mode");
            entity.Property(e => e.WaitingPid).HasColumnName("waiting_pid");
            entity.Property(e => e.WaitingQuery)
                .HasMaxLength(1024)
                .HasColumnName("waiting_query")
                .UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.WaitingTrxAge)
                .HasColumnType("time")
                .HasColumnName("waiting_trx_age");
            entity.Property(e => e.WaitingTrxId).HasColumnName("waiting_trx_id");
            entity.Property(e => e.WaitingTrxRowsLocked).HasColumnName("waiting_trx_rows_locked");
            entity.Property(e => e.WaitingTrxRowsModified).HasColumnName("waiting_trx_rows_modified");
            entity.Property(e => e.WaitingTrxStarted)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("datetime")
                .HasColumnName("waiting_trx_started");
        });

        modelBuilder.Entity<XIoByThreadByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$io_by_thread_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasPrecision(24, 4)
                .HasColumnName("avg_latency");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.MinLatency).HasColumnName("min_latency");
            entity.Property(e => e.ProcesslistId).HasColumnName("processlist_id");
            entity.Property(e => e.ThreadId).HasColumnName("thread_id");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasPrecision(42)
                .HasColumnName("total_latency");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<XIoGlobalByFileByByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$io_global_by_file_by_bytes");

            entity.Property(e => e.AvgRead)
                .HasPrecision(23, 4)
                .HasColumnName("avg_read");
            entity.Property(e => e.AvgWrite)
                .HasPrecision(23, 4)
                .HasColumnName("avg_write");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.File)
                .HasMaxLength(512)
                .HasColumnName("file");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalRead).HasColumnName("total_read");
            entity.Property(e => e.TotalWritten).HasColumnName("total_written");
            entity.Property(e => e.WritePct)
                .HasPrecision(26, 2)
                .HasColumnName("write_pct");
        });

        modelBuilder.Entity<XIoGlobalByFileByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$io_global_by_file_by_latency");

            entity.Property(e => e.CountMisc).HasColumnName("count_misc");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.File)
                .HasMaxLength(512)
                .HasColumnName("file");
            entity.Property(e => e.MiscLatency).HasColumnName("misc_latency");
            entity.Property(e => e.ReadLatency).HasColumnName("read_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.WriteLatency).HasColumnName("write_latency");
        });

        modelBuilder.Entity<XIoGlobalByWaitByByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$io_global_by_wait_by_bytes");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.AvgRead)
                .HasPrecision(23, 4)
                .HasColumnName("avg_read");
            entity.Property(e => e.AvgWritten)
                .HasPrecision(23, 4)
                .HasColumnName("avg_written");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.MinLatency).HasColumnName("min_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.TotalRead).HasColumnName("total_read");
            entity.Property(e => e.TotalRequested).HasColumnName("total_requested");
            entity.Property(e => e.TotalWritten).HasColumnName("total_written");
        });

        modelBuilder.Entity<XIoGlobalByWaitByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$io_global_by_wait_by_latency");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.AvgRead)
                .HasPrecision(23, 4)
                .HasColumnName("avg_read");
            entity.Property(e => e.AvgWritten)
                .HasPrecision(23, 4)
                .HasColumnName("avg_written");
            entity.Property(e => e.CountRead).HasColumnName("count_read");
            entity.Property(e => e.CountWrite).HasColumnName("count_write");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.MiscLatency).HasColumnName("misc_latency");
            entity.Property(e => e.ReadLatency).HasColumnName("read_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.TotalRead).HasColumnName("total_read");
            entity.Property(e => e.TotalWritten).HasColumnName("total_written");
            entity.Property(e => e.WriteLatency).HasColumnName("write_latency");
        });

        modelBuilder.Entity<XLatestFileIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$latest_file_io");

            entity.Property(e => e.File)
                .HasMaxLength(512)
                .HasColumnName("file");
            entity.Property(e => e.Latency).HasColumnName("latency");
            entity.Property(e => e.Operation)
                .HasMaxLength(32)
                .HasColumnName("operation");
            entity.Property(e => e.Requested).HasColumnName("requested");
            entity.Property(e => e.Thread)
                .HasMaxLength(317)
                .HasColumnName("thread");
        });

        modelBuilder.Entity<XMemoryByHostByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$memory_by_host_by_current_bytes");

            entity.Property(e => e.CurrentAllocated)
                .HasPrecision(41)
                .HasColumnName("current_allocated");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasPrecision(45, 4)
                .HasColumnName("current_avg_alloc");
            entity.Property(e => e.CurrentCountUsed)
                .HasPrecision(41)
                .HasColumnName("current_count_used");
            entity.Property(e => e.CurrentMaxAlloc).HasColumnName("current_max_alloc");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.TotalAllocated)
                .HasPrecision(42)
                .HasColumnName("total_allocated");
        });

        modelBuilder.Entity<XMemoryByThreadByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$memory_by_thread_by_current_bytes");

            entity.Property(e => e.CurrentAllocated)
                .HasPrecision(41)
                .HasColumnName("current_allocated");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasPrecision(45, 4)
                .HasColumnName("current_avg_alloc");
            entity.Property(e => e.CurrentCountUsed)
                .HasPrecision(41)
                .HasColumnName("current_count_used");
            entity.Property(e => e.CurrentMaxAlloc).HasColumnName("current_max_alloc");
            entity.Property(e => e.ThreadId).HasColumnName("thread_id");
            entity.Property(e => e.TotalAllocated)
                .HasPrecision(42)
                .HasColumnName("total_allocated");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<XMemoryByUserByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$memory_by_user_by_current_bytes");

            entity.Property(e => e.CurrentAllocated)
                .HasPrecision(41)
                .HasColumnName("current_allocated");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasPrecision(45, 4)
                .HasColumnName("current_avg_alloc");
            entity.Property(e => e.CurrentCountUsed)
                .HasPrecision(41)
                .HasColumnName("current_count_used");
            entity.Property(e => e.CurrentMaxAlloc).HasColumnName("current_max_alloc");
            entity.Property(e => e.TotalAllocated)
                .HasPrecision(42)
                .HasColumnName("total_allocated");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XMemoryGlobalByCurrentByte>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$memory_global_by_current_bytes");

            entity.Property(e => e.CurrentAlloc).HasColumnName("current_alloc");
            entity.Property(e => e.CurrentAvgAlloc)
                .HasPrecision(23, 4)
                .HasColumnName("current_avg_alloc");
            entity.Property(e => e.CurrentCount).HasColumnName("current_count");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.HighAlloc).HasColumnName("high_alloc");
            entity.Property(e => e.HighAvgAlloc)
                .HasPrecision(23, 4)
                .HasColumnName("high_avg_alloc");
            entity.Property(e => e.HighCount).HasColumnName("high_count");
        });

        modelBuilder.Entity<XMemoryGlobalTotal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$memory_global_total");

            entity.Property(e => e.TotalAllocated)
                .HasPrecision(41)
                .HasColumnName("total_allocated");
        });

        modelBuilder.Entity<XProcesslist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$processlist");

            entity.Property(e => e.Command)
                .HasMaxLength(16)
                .HasColumnName("command");
            entity.Property(e => e.ConnId).HasColumnName("conn_id");
            entity.Property(e => e.CpuLatency).HasColumnName("cpu_latency");
            entity.Property(e => e.CurrentMemory)
                .HasPrecision(41)
                .HasColumnName("current_memory");
            entity.Property(e => e.CurrentStatement).HasColumnName("current_statement");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.ExecutionEngine)
                .HasColumnType("enum('PRIMARY','SECONDARY')")
                .HasColumnName("execution_engine");
            entity.Property(e => e.FullScan)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastStatement).HasColumnName("last_statement");
            entity.Property(e => e.LastStatementLatency).HasColumnName("last_statement_latency");
            entity.Property(e => e.LastWait)
                .HasMaxLength(128)
                .HasColumnName("last_wait");
            entity.Property(e => e.LastWaitLatency)
                .HasMaxLength(20)
                .HasColumnName("last_wait_latency");
            entity.Property(e => e.LockLatency).HasColumnName("lock_latency");
            entity.Property(e => e.Pid)
                .HasMaxLength(1024)
                .HasColumnName("pid")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(1024)
                .HasColumnName("program_name")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.Progress)
                .HasPrecision(26, 2)
                .HasColumnName("progress");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Source)
                .HasMaxLength(64)
                .HasColumnName("source");
            entity.Property(e => e.State)
                .HasMaxLength(64)
                .HasColumnName("state");
            entity.Property(e => e.StatementLatency).HasColumnName("statement_latency");
            entity.Property(e => e.ThdId).HasColumnName("thd_id");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.TmpDiskTables).HasColumnName("tmp_disk_tables");
            entity.Property(e => e.TmpTables).HasColumnName("tmp_tables");
            entity.Property(e => e.TrxAutocommit)
                .HasColumnType("enum('YES','NO')")
                .HasColumnName("trx_autocommit");
            entity.Property(e => e.TrxLatency).HasColumnName("trx_latency");
            entity.Property(e => e.TrxState)
                .HasColumnType("enum('ACTIVE','COMMITTED','ROLLED BACK')")
                .HasColumnName("trx_state");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<XPsDigest95thPercentileByAvgU>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$ps_digest_95th_percentile_by_avg_us");

            entity.Property(e => e.AvgUs)
                .HasPrecision(21)
                .HasColumnName("avg_us");
            entity.Property(e => e.Percentile)
                .HasPrecision(46, 4)
                .HasColumnName("percentile");
        });

        modelBuilder.Entity<XPsDigestAvgLatencyDistribution>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$ps_digest_avg_latency_distribution");

            entity.Property(e => e.AvgUs)
                .HasPrecision(21)
                .HasColumnName("avg_us");
            entity.Property(e => e.Cnt).HasColumnName("cnt");
        });

        modelBuilder.Entity<XPsSchemaTableStatisticsIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$ps_schema_table_statistics_io");

            entity.Property(e => e.CountMisc)
                .HasPrecision(42)
                .HasColumnName("count_misc");
            entity.Property(e => e.CountRead)
                .HasPrecision(42)
                .HasColumnName("count_read");
            entity.Property(e => e.CountWrite)
                .HasPrecision(42)
                .HasColumnName("count_write");
            entity.Property(e => e.SumNumberOfBytesRead)
                .HasPrecision(41)
                .HasColumnName("sum_number_of_bytes_read");
            entity.Property(e => e.SumNumberOfBytesWrite)
                .HasPrecision(41)
                .HasColumnName("sum_number_of_bytes_write");
            entity.Property(e => e.SumTimerMisc)
                .HasPrecision(42)
                .HasColumnName("sum_timer_misc");
            entity.Property(e => e.SumTimerRead)
                .HasPrecision(42)
                .HasColumnName("sum_timer_read");
            entity.Property(e => e.SumTimerWrite)
                .HasPrecision(42)
                .HasColumnName("sum_timer_write");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema");
        });

        modelBuilder.Entity<XSchemaFlattenedKey>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$schema_flattened_keys");

            entity.Property(e => e.IndexColumns)
                .HasColumnType("text")
                .HasColumnName("index_columns")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.IndexName)
                .HasMaxLength(64)
                .HasColumnName("index_name")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.NonUnique).HasColumnName("non_unique");
            entity.Property(e => e.SubpartExists).HasColumnName("subpart_exists");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema")
                .UseCollation("utf8mb3_tolower_ci")
                .HasCharSet("utf8mb3");
        });

        modelBuilder.Entity<XSchemaIndexStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$schema_index_statistics");

            entity.Property(e => e.DeleteLatency).HasColumnName("delete_latency");
            entity.Property(e => e.IndexName)
                .HasMaxLength(64)
                .HasColumnName("index_name");
            entity.Property(e => e.InsertLatency).HasColumnName("insert_latency");
            entity.Property(e => e.RowsDeleted).HasColumnName("rows_deleted");
            entity.Property(e => e.RowsInserted).HasColumnName("rows_inserted");
            entity.Property(e => e.RowsSelected).HasColumnName("rows_selected");
            entity.Property(e => e.RowsUpdated).HasColumnName("rows_updated");
            entity.Property(e => e.SelectLatency).HasColumnName("select_latency");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema");
            entity.Property(e => e.UpdateLatency).HasColumnName("update_latency");
        });

        modelBuilder.Entity<XSchemaTableLockWait>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$schema_table_lock_waits");

            entity.Property(e => e.BlockingAccount)
                .HasColumnType("text")
                .HasColumnName("blocking_account");
            entity.Property(e => e.BlockingLockDuration)
                .HasMaxLength(32)
                .HasColumnName("blocking_lock_duration");
            entity.Property(e => e.BlockingLockType)
                .HasMaxLength(32)
                .HasColumnName("blocking_lock_type");
            entity.Property(e => e.BlockingPid).HasColumnName("blocking_pid");
            entity.Property(e => e.BlockingThreadId).HasColumnName("blocking_thread_id");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(64)
                .HasColumnName("object_name");
            entity.Property(e => e.ObjectSchema)
                .HasMaxLength(64)
                .HasColumnName("object_schema");
            entity.Property(e => e.SqlKillBlockingConnection)
                .HasMaxLength(25)
                .HasColumnName("sql_kill_blocking_connection");
            entity.Property(e => e.SqlKillBlockingQuery)
                .HasMaxLength(31)
                .HasColumnName("sql_kill_blocking_query");
            entity.Property(e => e.WaitingAccount)
                .HasColumnType("text")
                .HasColumnName("waiting_account");
            entity.Property(e => e.WaitingLockDuration)
                .HasMaxLength(32)
                .HasColumnName("waiting_lock_duration");
            entity.Property(e => e.WaitingLockType)
                .HasMaxLength(32)
                .HasColumnName("waiting_lock_type");
            entity.Property(e => e.WaitingPid).HasColumnName("waiting_pid");
            entity.Property(e => e.WaitingQuery).HasColumnName("waiting_query");
            entity.Property(e => e.WaitingQueryRowsAffected).HasColumnName("waiting_query_rows_affected");
            entity.Property(e => e.WaitingQueryRowsExamined).HasColumnName("waiting_query_rows_examined");
            entity.Property(e => e.WaitingQuerySecs).HasColumnName("waiting_query_secs");
            entity.Property(e => e.WaitingThreadId).HasColumnName("waiting_thread_id");
        });

        modelBuilder.Entity<XSchemaTableStatistic>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$schema_table_statistics");

            entity.Property(e => e.DeleteLatency).HasColumnName("delete_latency");
            entity.Property(e => e.FetchLatency).HasColumnName("fetch_latency");
            entity.Property(e => e.InsertLatency).HasColumnName("insert_latency");
            entity.Property(e => e.IoMiscLatency)
                .HasPrecision(42)
                .HasColumnName("io_misc_latency");
            entity.Property(e => e.IoMiscRequests)
                .HasPrecision(42)
                .HasColumnName("io_misc_requests");
            entity.Property(e => e.IoRead)
                .HasPrecision(41)
                .HasColumnName("io_read");
            entity.Property(e => e.IoReadLatency)
                .HasPrecision(42)
                .HasColumnName("io_read_latency");
            entity.Property(e => e.IoReadRequests)
                .HasPrecision(42)
                .HasColumnName("io_read_requests");
            entity.Property(e => e.IoWrite)
                .HasPrecision(41)
                .HasColumnName("io_write");
            entity.Property(e => e.IoWriteLatency)
                .HasPrecision(42)
                .HasColumnName("io_write_latency");
            entity.Property(e => e.IoWriteRequests)
                .HasPrecision(42)
                .HasColumnName("io_write_requests");
            entity.Property(e => e.RowsDeleted).HasColumnName("rows_deleted");
            entity.Property(e => e.RowsFetched).HasColumnName("rows_fetched");
            entity.Property(e => e.RowsInserted).HasColumnName("rows_inserted");
            entity.Property(e => e.RowsUpdated).HasColumnName("rows_updated");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.UpdateLatency).HasColumnName("update_latency");
        });

        modelBuilder.Entity<XSchemaTableStatisticsWithBuffer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$schema_table_statistics_with_buffer");

            entity.Property(e => e.DeleteLatency).HasColumnName("delete_latency");
            entity.Property(e => e.FetchLatency).HasColumnName("fetch_latency");
            entity.Property(e => e.InnodbBufferAllocated)
                .HasPrecision(44)
                .HasColumnName("innodb_buffer_allocated");
            entity.Property(e => e.InnodbBufferData)
                .HasPrecision(44)
                .HasColumnName("innodb_buffer_data");
            entity.Property(e => e.InnodbBufferFree)
                .HasPrecision(45)
                .HasColumnName("innodb_buffer_free");
            entity.Property(e => e.InnodbBufferPages)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_pages");
            entity.Property(e => e.InnodbBufferPagesHashed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_pages_hashed");
            entity.Property(e => e.InnodbBufferPagesOld)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_pages_old");
            entity.Property(e => e.InnodbBufferRowsCached)
                .HasPrecision(45)
                .HasDefaultValueSql("'0'")
                .HasColumnName("innodb_buffer_rows_cached");
            entity.Property(e => e.InsertLatency).HasColumnName("insert_latency");
            entity.Property(e => e.IoMiscLatency)
                .HasPrecision(42)
                .HasColumnName("io_misc_latency");
            entity.Property(e => e.IoMiscRequests)
                .HasPrecision(42)
                .HasColumnName("io_misc_requests");
            entity.Property(e => e.IoRead)
                .HasPrecision(41)
                .HasColumnName("io_read");
            entity.Property(e => e.IoReadLatency)
                .HasPrecision(42)
                .HasColumnName("io_read_latency");
            entity.Property(e => e.IoReadRequests)
                .HasPrecision(42)
                .HasColumnName("io_read_requests");
            entity.Property(e => e.IoWrite)
                .HasPrecision(41)
                .HasColumnName("io_write");
            entity.Property(e => e.IoWriteLatency)
                .HasPrecision(42)
                .HasColumnName("io_write_latency");
            entity.Property(e => e.IoWriteRequests)
                .HasPrecision(42)
                .HasColumnName("io_write_requests");
            entity.Property(e => e.RowsDeleted).HasColumnName("rows_deleted");
            entity.Property(e => e.RowsFetched).HasColumnName("rows_fetched");
            entity.Property(e => e.RowsInserted).HasColumnName("rows_inserted");
            entity.Property(e => e.RowsUpdated).HasColumnName("rows_updated");
            entity.Property(e => e.TableName)
                .HasMaxLength(64)
                .HasColumnName("table_name");
            entity.Property(e => e.TableSchema)
                .HasMaxLength(64)
                .HasColumnName("table_schema");
            entity.Property(e => e.UpdateLatency).HasColumnName("update_latency");
        });

        modelBuilder.Entity<XSchemaTablesWithFullTableScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$schema_tables_with_full_table_scans");

            entity.Property(e => e.Latency).HasColumnName("latency");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(64)
                .HasColumnName("object_name");
            entity.Property(e => e.ObjectSchema)
                .HasMaxLength(64)
                .HasColumnName("object_schema");
            entity.Property(e => e.RowsFullScanned).HasColumnName("rows_full_scanned");
        });

        modelBuilder.Entity<XSession>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$session");

            entity.Property(e => e.Command)
                .HasMaxLength(16)
                .HasColumnName("command");
            entity.Property(e => e.ConnId).HasColumnName("conn_id");
            entity.Property(e => e.CpuLatency).HasColumnName("cpu_latency");
            entity.Property(e => e.CurrentMemory)
                .HasPrecision(41)
                .HasColumnName("current_memory");
            entity.Property(e => e.CurrentStatement).HasColumnName("current_statement");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.ExecutionEngine)
                .HasColumnType("enum('PRIMARY','SECONDARY')")
                .HasColumnName("execution_engine");
            entity.Property(e => e.FullScan)
                .HasMaxLength(3)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastStatement).HasColumnName("last_statement");
            entity.Property(e => e.LastStatementLatency).HasColumnName("last_statement_latency");
            entity.Property(e => e.LastWait)
                .HasMaxLength(128)
                .HasColumnName("last_wait");
            entity.Property(e => e.LastWaitLatency)
                .HasMaxLength(20)
                .HasColumnName("last_wait_latency");
            entity.Property(e => e.LockLatency).HasColumnName("lock_latency");
            entity.Property(e => e.Pid)
                .HasMaxLength(1024)
                .HasColumnName("pid")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.ProgramName)
                .HasMaxLength(1024)
                .HasColumnName("program_name")
                .UseCollation("utf8mb4_bin");
            entity.Property(e => e.Progress)
                .HasPrecision(26, 2)
                .HasColumnName("progress");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Source)
                .HasMaxLength(64)
                .HasColumnName("source");
            entity.Property(e => e.State)
                .HasMaxLength(64)
                .HasColumnName("state");
            entity.Property(e => e.StatementLatency).HasColumnName("statement_latency");
            entity.Property(e => e.ThdId).HasColumnName("thd_id");
            entity.Property(e => e.Time).HasColumnName("time");
            entity.Property(e => e.TmpDiskTables).HasColumnName("tmp_disk_tables");
            entity.Property(e => e.TmpTables).HasColumnName("tmp_tables");
            entity.Property(e => e.TrxAutocommit)
                .HasColumnType("enum('YES','NO')")
                .HasColumnName("trx_autocommit");
            entity.Property(e => e.TrxLatency).HasColumnName("trx_latency");
            entity.Property(e => e.TrxState)
                .HasColumnType("enum('ACTIVE','COMMITTED','ROLLED BACK')")
                .HasColumnName("trx_state");
            entity.Property(e => e.User)
                .HasMaxLength(288)
                .HasColumnName("user");
        });

        modelBuilder.Entity<XStatementAnalysis>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$statement_analysis");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.CpuLatency).HasColumnName("cpu_latency");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ErrCount).HasColumnName("err_count");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.ExecSecondaryCount).HasColumnName("exec_secondary_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.FullScan)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.LockLatency).HasColumnName("lock_latency");
            entity.Property(e => e.MaxControlledMemory).HasColumnName("max_controlled_memory");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.MaxTotalMemory).HasColumnName("max_total_memory");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsAffectedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_affected_avg");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsExaminedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_examined_avg");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.RowsSentAvg)
                .HasPrecision(21)
                .HasColumnName("rows_sent_avg");
            entity.Property(e => e.RowsSorted).HasColumnName("rows_sorted");
            entity.Property(e => e.SortMergePasses).HasColumnName("sort_merge_passes");
            entity.Property(e => e.TmpDiskTables).HasColumnName("tmp_disk_tables");
            entity.Property(e => e.TmpTables).HasColumnName("tmp_tables");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.WarnCount).HasColumnName("warn_count");
        });

        modelBuilder.Entity<XStatementsWithErrorsOrWarning>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$statements_with_errors_or_warnings");

            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ErrorPct)
                .HasPrecision(27, 4)
                .HasColumnName("error_pct");
            entity.Property(e => e.Errors).HasColumnName("errors");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.WarningPct)
                .HasPrecision(27, 4)
                .HasColumnName("warning_pct");
            entity.Property(e => e.Warnings).HasColumnName("warnings");
        });

        modelBuilder.Entity<XStatementsWithFullTableScan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$statements_with_full_table_scans");

            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.NoGoodIndexUsedCount).HasColumnName("no_good_index_used_count");
            entity.Property(e => e.NoIndexUsedCount).HasColumnName("no_index_used_count");
            entity.Property(e => e.NoIndexUsedPct)
                .HasPrecision(24)
                .HasColumnName("no_index_used_pct");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsExaminedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_examined_avg");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.RowsSentAvg)
                .HasPrecision(21)
                .HasColumnName("rows_sent_avg");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        modelBuilder.Entity<XStatementsWithRuntimesIn95thPercentile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$statements_with_runtimes_in_95th_percentile");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ErrCount).HasColumnName("err_count");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.FullScan)
                .HasMaxLength(1)
                .HasDefaultValueSql("''")
                .HasColumnName("full_scan");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsExaminedAvg)
                .HasPrecision(21)
                .HasColumnName("rows_examined_avg");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.RowsSentAvg)
                .HasPrecision(21)
                .HasColumnName("rows_sent_avg");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.WarnCount).HasColumnName("warn_count");
        });

        modelBuilder.Entity<XStatementsWithSorting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$statements_with_sorting");

            entity.Property(e => e.AvgRowsSorted)
                .HasPrecision(21)
                .HasColumnName("avg_rows_sorted");
            entity.Property(e => e.AvgSortMerges)
                .HasPrecision(21)
                .HasColumnName("avg_sort_merges");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.RowsSorted).HasColumnName("rows_sorted");
            entity.Property(e => e.SortMergePasses).HasColumnName("sort_merge_passes");
            entity.Property(e => e.SortUsingRange).HasColumnName("sort_using_range");
            entity.Property(e => e.SortsUsingScans).HasColumnName("sorts_using_scans");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        modelBuilder.Entity<XStatementsWithTempTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$statements_with_temp_tables");

            entity.Property(e => e.AvgTmpTablesPerQuery)
                .HasPrecision(21)
                .HasColumnName("avg_tmp_tables_per_query");
            entity.Property(e => e.Db)
                .HasMaxLength(64)
                .HasColumnName("db");
            entity.Property(e => e.Digest)
                .HasMaxLength(64)
                .HasColumnName("digest");
            entity.Property(e => e.DiskTmpTables).HasColumnName("disk_tmp_tables");
            entity.Property(e => e.ExecCount).HasColumnName("exec_count");
            entity.Property(e => e.FirstSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("first_seen");
            entity.Property(e => e.LastSeen)
                .HasColumnType("timestamp(6)")
                .HasColumnName("last_seen");
            entity.Property(e => e.MemoryTmpTables).HasColumnName("memory_tmp_tables");
            entity.Property(e => e.Query).HasColumnName("query");
            entity.Property(e => e.TmpTablesToDiskPct)
                .HasPrecision(24)
                .HasColumnName("tmp_tables_to_disk_pct");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        modelBuilder.Entity<XUserSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$user_summary");

            entity.Property(e => e.CurrentConnections)
                .HasPrecision(41)
                .HasColumnName("current_connections");
            entity.Property(e => e.CurrentMemory)
                .HasPrecision(63)
                .HasColumnName("current_memory");
            entity.Property(e => e.FileIoLatency)
                .HasPrecision(64)
                .HasColumnName("file_io_latency");
            entity.Property(e => e.FileIos)
                .HasPrecision(64)
                .HasColumnName("file_ios");
            entity.Property(e => e.StatementAvgLatency).HasColumnName("statement_avg_latency");
            entity.Property(e => e.StatementLatency)
                .HasPrecision(64)
                .HasColumnName("statement_latency");
            entity.Property(e => e.Statements)
                .HasPrecision(64)
                .HasColumnName("statements");
            entity.Property(e => e.TableScans).HasColumnName("table_scans");
            entity.Property(e => e.TotalConnections)
                .HasPrecision(41)
                .HasColumnName("total_connections");
            entity.Property(e => e.TotalMemoryAllocated)
                .HasPrecision(64)
                .HasColumnName("total_memory_allocated");
            entity.Property(e => e.UniqueHosts).HasColumnName("unique_hosts");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XUserSummaryByFileIo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$user_summary_by_file_io");

            entity.Property(e => e.IoLatency)
                .HasPrecision(42)
                .HasColumnName("io_latency");
            entity.Property(e => e.Ios)
                .HasPrecision(42)
                .HasColumnName("ios");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XUserSummaryByFileIoType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$user_summary_by_file_io_type");

            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Latency).HasColumnName("latency");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XUserSummaryByStage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$user_summary_by_stages");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.EventName)
                .HasMaxLength(128)
                .HasColumnName("event_name");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XUserSummaryByStatementLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$user_summary_by_statement_latency");

            entity.Property(e => e.CpuLatency)
                .HasPrecision(42)
                .HasColumnName("cpu_latency");
            entity.Property(e => e.FullScans)
                .HasPrecision(43)
                .HasColumnName("full_scans");
            entity.Property(e => e.LockLatency)
                .HasPrecision(42)
                .HasColumnName("lock_latency");
            entity.Property(e => e.MaxLatency)
                .HasPrecision(42)
                .HasColumnName("max_latency");
            entity.Property(e => e.RowsAffected)
                .HasPrecision(42)
                .HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined)
                .HasPrecision(42)
                .HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent)
                .HasPrecision(42)
                .HasColumnName("rows_sent");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasPrecision(42)
                .HasColumnName("total_latency");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XUserSummaryByStatementType>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$user_summary_by_statement_type");

            entity.Property(e => e.CpuLatency).HasColumnName("cpu_latency");
            entity.Property(e => e.FullScans).HasColumnName("full_scans");
            entity.Property(e => e.LockLatency).HasColumnName("lock_latency");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.RowsAffected).HasColumnName("rows_affected");
            entity.Property(e => e.RowsExamined).HasColumnName("rows_examined");
            entity.Property(e => e.RowsSent).HasColumnName("rows_sent");
            entity.Property(e => e.Statement)
                .HasMaxLength(128)
                .HasColumnName("statement");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XWaitClassesGlobalByAvgLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$wait_classes_global_by_avg_latency");

            entity.Property(e => e.AvgLatency)
                .HasPrecision(46, 4)
                .HasColumnName("avg_latency");
            entity.Property(e => e.EventClass)
                .HasMaxLength(128)
                .HasColumnName("event_class");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.MinLatency).HasColumnName("min_latency");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasPrecision(42)
                .HasColumnName("total_latency");
        });

        modelBuilder.Entity<XWaitClassesGlobalByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$wait_classes_global_by_latency");

            entity.Property(e => e.AvgLatency)
                .HasPrecision(46, 4)
                .HasColumnName("avg_latency");
            entity.Property(e => e.EventClass)
                .HasMaxLength(128)
                .HasColumnName("event_class");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.MinLatency).HasColumnName("min_latency");
            entity.Property(e => e.Total)
                .HasPrecision(42)
                .HasColumnName("total");
            entity.Property(e => e.TotalLatency)
                .HasPrecision(42)
                .HasColumnName("total_latency");
        });

        modelBuilder.Entity<XWaitsByHostByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$waits_by_host_by_latency");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasColumnName("event");
            entity.Property(e => e.Host)
                .HasMaxLength(255)
                .HasColumnName("host")
                .UseCollation("ascii_general_ci")
                .HasCharSet("ascii");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        modelBuilder.Entity<XWaitsByUserByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$waits_by_user_by_latency");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.Event)
                .HasMaxLength(128)
                .HasColumnName("event");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
            entity.Property(e => e.User)
                .HasMaxLength(32)
                .HasColumnName("user")
                .UseCollation("utf8mb4_bin");
        });

        modelBuilder.Entity<XWaitsGlobalByLatency>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("x$waits_global_by_latency");

            entity.Property(e => e.AvgLatency).HasColumnName("avg_latency");
            entity.Property(e => e.Events)
                .HasMaxLength(128)
                .HasColumnName("events");
            entity.Property(e => e.MaxLatency).HasColumnName("max_latency");
            entity.Property(e => e.Total).HasColumnName("total");
            entity.Property(e => e.TotalLatency).HasColumnName("total_latency");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
