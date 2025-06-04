using Indent_Dev.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Indent_Dev.ViewModels
{
    public class AddIndentViewModel
    {
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        public List<SelectListItem> CategorySelectList { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string SelectedCategory { get; set; }


        [DisplayName("Sub Category Name")]
        public string SubCategoryName { get; set; }
        public List<SelectListItem> SubCategorySelectList { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string SelectedSubCategory { get; set; }



        [DisplayName("FY Quarter")]
        [Required(ErrorMessage = "This field is required")]
        public string? FyQuarter { get; set; }


        [DisplayName("Indent Number")]
        [Required(ErrorMessage = "This field is required")]
        public string IndentNumber { get; set; } = null!;



        [DisplayName("Number of Slots")]
        [Required(ErrorMessage = "Number of Slots cannot be zero")]
        public byte? NumberOfSlots { get; set; }


        [DisplayName("Location")]
        public string? Location { get; set; }
        public List<SelectListItem> LocationsSelectList { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string SelectedLocation { get; set; }


        [DisplayName("Sub Unit")]
        [Required(ErrorMessage = "This field is required")]
        public string? Subunit { get; set; }



        [Required(ErrorMessage = "This field is required")]
        public string? PU { get; set; }



        [Required(ErrorMessage = "This field is required")]
        public string? JL { get; set; }



        [Required(ErrorMessage = "This field is required")]
        public string? Role { get; set; }


        [DisplayName("Indent Type")]
        [Required(ErrorMessage = "This field is required")]
        public string? IndentType { get; set; }


        [DisplayName("Date of Release")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}")]
        [Required(ErrorMessage = "This field is required")]
        public DateOnly? DateOfRelease { get; set; } = null!;


        [DisplayName("Date of Fulfillment")]
        
        public DateOnly? DateOfFulfillment { get; set; } 


        [DisplayName("Indent Status")]
        [Required(ErrorMessage = "This field is required")]
        public string? IndentStatus { get; set; } 
        public List<SelectListItem> StatusSelectList { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        public string SelectedStatus { get; set; }



        public string? Account { get; set; } 
        public List<SelectListItem> AccountsSelectList { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        public string SelectedAccount { get; set; }


        [DisplayName("TA SPOC")]
        public string? TaSpoc { get; set; } 
        public List<SelectListItem> TaSpocsSelectList { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public string SelectedTaSpoc { get; set; }

        public string? Remarks { get; set; } = null!;

        

    }
}
