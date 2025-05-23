using System;
using System.Collections.Generic;

namespace Indent_Dev.Models;

public partial class Category
{
    public short? CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Indent> Indents { get; set; } = new List<Indent>();

    public virtual ICollection<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
}
