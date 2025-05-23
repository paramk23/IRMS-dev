using System;
using System.Collections.Generic;

namespace Indent_Dev.Models;

public partial class Account
{
    public short? Id { get; set; }

    public string AccountName { get; set; } = null!;

    public virtual ICollection<Indent> Indents { get; set; } = new List<Indent>();
}
