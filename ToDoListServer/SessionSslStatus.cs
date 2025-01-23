using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class SessionSslStatus
{
    public ulong ThreadId { get; set; }

    public string? SslVersion { get; set; }

    public string? SslCipher { get; set; }

    public string? SslSessionsReused { get; set; }
}
