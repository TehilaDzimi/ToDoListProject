using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class XSchemaFlattenedKey
{
    public string? TableSchema { get; set; }

    public string? TableName { get; set; }

    public string? IndexName { get; set; }

    public int? NonUnique { get; set; }

    public long? SubpartExists { get; set; }

    public string? IndexColumns { get; set; }
}
