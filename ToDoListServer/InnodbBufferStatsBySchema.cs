using System;
using System.Collections.Generic;

namespace TodoApi;

public partial class InnodbBufferStatsBySchema
{
    public string? ObjectSchema { get; set; }

    public string? Allocated { get; set; }

    public string? Data { get; set; }

    public long Pages { get; set; }

    public long PagesHashed { get; set; }

    public long PagesOld { get; set; }

    public decimal? RowsCached { get; set; }
}
