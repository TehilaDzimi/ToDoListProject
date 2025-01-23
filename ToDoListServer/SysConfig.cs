using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SysConfig
{
    public string Variable { get; set; } = null!;

    public string? Value { get; set; }

    public DateTime? SetTime { get; set; }

    public string? SetBy { get; set; }
}
