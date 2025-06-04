using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Indent_Dev.Models;

public partial class Indent
{
    public string? Category { get; set; }

    public string? SubCategory { get; set; }

    public string? FyQuarter { get; set; }

    [DisplayName("Number")]
    public string IndentNumber { get; set; } = null!;

    [DisplayName("Slots")]
    public byte? NumberOfSlots { get; set; }

    public string? Location { get; set; }

    public string? Subunit { get; set; }

    public string? PU { get; set; }

    public string? JL { get; set; }

    public string? Role { get; set; }

    public string? IndentType { get; set; }

    [DisplayName("Date of Release")]
    public DateOnly? DateOfRelease { get; set; }

    [DisplayName("Fulfillment")]
    public DateOnly? DateOfFulfillment { get; set; }

    public string? IndentStatus { get; set; }

    public string? Account { get; set; }

    public string? TaSpoc { get; set; }

    public string? Remarks { get; set; }

    public virtual Account? AccountNavigation { get; set; }

    public virtual Category? CategoryNavigation { get; set; }

    public virtual IndentStatus? IndentStatusNavigation { get; set; }

    public virtual Location? LocationNavigation { get; set; }

    public virtual Pu? PuNavigation { get; set; }

    public virtual SubCategory? SubCategoryNavigation { get; set; }

    public virtual Subunit? SubunitNavigation { get; set; }

    public virtual TaSpoc? TaSpocNavigation { get; set; }
}
