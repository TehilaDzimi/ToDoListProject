using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SchemaTablesWithFullTableScan
{
    public string? ObjectSchema { get; set; }

    public string? ObjectName { get; set; }

    public ulong RowsFullScanned { get; set; }

    public string? Latency { get; set; }
}
