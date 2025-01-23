using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class PsCheckLostInstrumentation
{
    public string VariableName { get; set; } = null!;

    public string? VariableValue { get; set; }
}
