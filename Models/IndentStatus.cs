using System;
using System.Collections.Generic;

namespace Indent_Dev.Models;

public partial class IndentStatus
{
    public short? Id { get; set; }

    public string IndentStatus1 { get; set; } = null!;

    public virtual ICollection<Indent> Indents { get; set; } = new List<Indent>();
}
