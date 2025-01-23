using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SchemaAutoIncrementColumn
{
    public string? TableSchema { get; set; }

    public string? TableName { get; set; }

    public string? ColumnName { get; set; }

    public string? DataType { get; set; }

    public string ColumnType { get; set; } = null!;

    public int IsSigned { get; set; }

    public int IsUnsigned { get; set; }

    public ulong? MaxValue { get; set; }

    public ulong? AutoIncrement { get; set; }

    public decimal? AutoIncrementRatio { get; set; }
}
