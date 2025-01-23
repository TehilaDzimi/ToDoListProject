using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class Version
{
    public string SysVersion { get; set; } = null!;

    public string MysqlVersion { get; set; } = null!;
}
