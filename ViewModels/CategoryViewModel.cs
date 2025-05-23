using Microsoft.AspNetCore.Mvc.Rendering;

namespace Indent_Dev.ViewModels
{
    public class CategoryViewModel
    {
        public short? CategoryId { get; set; }
        public string CategoryName { get; set; }

        public string SelectedCategory { get; set; } = null!;

        public List<SelectListItem> CategorySelectList { get; set; }

        
    }
}
