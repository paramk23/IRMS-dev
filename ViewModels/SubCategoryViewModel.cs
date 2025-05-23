using Microsoft.AspNetCore.Mvc.Rendering;

namespace Indent_Dev.ViewModels
{
    public class SubCategoryViewModel
    {
        public short? CategoryId { get; set; }

        public string SelectedSubCategoryName { get; set; } = null!;

        public List<SelectListItem> SubCategorySelectList { get; set; }
    }
}
