using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class Metric
{
    public string VariableName { get; set; } = null!;

    public string? VariableValue { get; set; }

    public string Type { get; set; } = null!;

    public string Enabled { get; set; } = null!;
}
