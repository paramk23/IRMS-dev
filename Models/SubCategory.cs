using System;
using System.Collections.Generic;

namespace Indent_Dev.Models;

public partial class SubCategory
{
    public short? CategoryId { get; set; }

    public string SubCategoryName { get; set; } = null!;

    public string? Category { get; set; }

    public virtual Category? CategoryNavigation { get; set; }

    public virtual ICollection<Indent> Indents { get; set; } = new List<Indent>();
}
