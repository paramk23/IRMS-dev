using System;
using System.Collections.Generic;

namespace Indent_Dev.Models;

public partial class Location
{
    public short? Id { get; set; }

    public string LocationName { get; set; } = null!;

    public virtual ICollection<Indent> Indents { get; set; } = new List<Indent>();
}
