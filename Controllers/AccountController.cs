using Indent_Dev.Models;
using Indent_Dev.Services;
using Indent_Dev.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Indent_Dev.Controllers
{
    public class AccountController : Controller
    {
        // GET: AccountController
        public ActionResult Index()
        {
            IrmsDevContext context = new IrmsDevContext();
            List<Indent> indents = new List<Indent>();
            indents = context.Indents.ToList();
            return View(indents);
        }

        // GET: AccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AccountController/Create
        public ActionResult AddIndent()
        {
            IndentDataAccess indentDataAccess = new IndentDataAccess();
            var model = new AddIndentViewModel();

            var Category = indentDataAccess.GetAllCategories();
            model.CategorySelectList = new List<SelectListItem>();
            foreach (var category in Category)
            {
                model.CategorySelectList.Add(new SelectListItem { Text = category.CategoryName });

            }

            var SubCategories = new List<SubCategory>();
            var SubCategory = indentDataAccess.GetAllSubCategories();
            //String sb = "Sales";
            //var subCategory2 = indentDataAccess.GetSubCategoriesBasedOnCategory(sb); 
            model.SubCategorySelectList = new List<SelectListItem>();
            foreach (var subCategory in SubCategory) { 
                model.SubCategorySelectList.Add(new SelectListItem {Text = subCategory.SubCategoryName});    
            }

            var TaSpocs = indentDataAccess.GetTaSpocs();
            model.TaSpocsSelectList = new List<SelectListItem>();
            foreach (var taSp in TaSpocs)
            {
                model.TaSpocsSelectList.Add(new SelectListItem { Text = taSp.TaSpocName });
            }

            var Accounts = indentDataAccess.GetAccounts();
            model.AccountsSelectList = new List<SelectListItem>();
            foreach (var acc in Accounts)
            {
                model.AccountsSelectList.Add(new SelectListItem { Text = acc.AccountName });
            }

            var Locations = indentDataAccess.GetLocations();
            model.LocationsSelectList = new List<SelectListItem>();
            foreach (var loc in Locations)
            {
                model.LocationsSelectList.Add(new SelectListItem { Text = loc.LocationName });
            }

            var Statuses = indentDataAccess.GetIndentStatusForNew();
            model.StatusSelectList = new List<SelectListItem>();
            foreach (var stat in Statuses)
            {
                model.StatusSelectList.Add(new SelectListItem { Text = stat.IndentStatus1 });
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult AddIndent(AddIndentViewModel model)
        {
            IndentDataAccess indentDataAccess = new IndentDataAccess();

            Indent indentObj = new Indent();
            indentObj.Category = model.SelectedCategory;
            indentObj.SubCategory = model.SelectedSubCategory;
            indentObj.FyQuarter = model.FyQuarter;
            indentObj.IndentNumber = model.IndentNumber;
            indentObj.NumberOfSlots = model.NumberOfSlots;
            indentObj.Location = model.SelectedLocation;
            indentObj.Subunit = model.Subunit;
            indentObj.PU = model.PU;
            indentObj.JL = model.JL;
            indentObj.Role = model.Role;
            indentObj.IndentType = model.IndentType;
            indentObj.DateOfRelease = model.DateOfRelease;
            indentObj.DateOfFulfillment = model.DateOfFulfillment;
            indentObj.IndentStatus = model.SelectedStatus;
            indentObj.Account = model.SelectedAccount;
            indentObj.TaSpoc = model.SelectedTaSpoc;
            indentObj.Remarks = model.Remarks;

            //if (ModelState.IsValid)
            //{
            //    indentDataAccess.AddIndent(indentObj);
            //    return RedirectToAction("Index");
            //}
            indentDataAccess.AddIndent(indentObj);
            return RedirectToAction("Index");
        }

        public JsonResult GetSubCategoryByCategory(string categoryName)
        {
            IndentDataAccess indentDataAccess = new IndentDataAccess();
            var SubCategories = indentDataAccess.GetSubCategoriesBasedOnCategory(categoryName);
            return Json(SubCategories);
        }

        public JsonResult GetCategories()
        {
            IndentDataAccess indentDataAccess = new IndentDataAccess();
            var Categories = indentDataAccess.GetAllCategories();
            return Json(Categories);
        }

        //[HttpPost]
        //public ActionResult AddIndent(AddIndentViewModel model)
        //{


        //}
        // POST: AccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AccountController/Edit/5

        public ActionResult Edit(string id)
        {
            IndentDataAccess indentDataAccess = new IndentDataAccess();
            Indent indent = new Indent();
            AddIndentViewModel model = new AddIndentViewModel();
            indent = indentDataAccess.FetchEditDetails(id);
            model.SelectedCategory = indent.Category;
            model.SelectedSubCategory = indent.SubCategory;
            model.FyQuarter = indent.FyQuarter;
            model.IndentNumber = indent.IndentNumber;
            model.NumberOfSlots = indent.NumberOfSlots;
            model.SelectedLocation = indent.Location;
            model.Subunit = indent.Subunit;
            model.PU = indent.PU;
            model.JL = indent.JL;
            model.Role = indent.Role;
            model.IndentType = indent.IndentType;
            model.DateOfRelease = indent.DateOfRelease;
            model.DateOfFulfillment = indent.DateOfFulfillment;
            var Statuses = indentDataAccess.GetIndentStatusForNew();
            model.StatusSelectList = new List<SelectListItem>();
            foreach (var stat in Statuses)
            {
                model.StatusSelectList.Add(new SelectListItem { Text = stat.IndentStatus1 });
            }

            model.SelectedStatus = indent.IndentStatus;
            model.SelectedAccount = indent.Account;
            model.SelectedTaSpoc = indent.TaSpoc;
            model.Remarks = indent.Remarks;
            return View(model);
        }

        // POST: AccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(string id, AddIndentViewModel model)
        {
            IndentDataAccess indentDataAccess = new IndentDataAccess(); 
            Indent indent = new Indent();
            indent.Category = model.SelectedCategory;
            indent.SubCategory = model.SelectedSubCategory;
            indent.FyQuarter = model.FyQuarter;
            indent.IndentNumber = model.IndentNumber;
            indent.NumberOfSlots = model.NumberOfSlots;
            indent.Location = model.SelectedLocation;
            indent.Subunit = model.Subunit;
            indent.PU = model.PU;
            indent.JL = model.JL;
            indent.Role = model.Role;
            indent.IndentType = model.IndentType;
            indent.DateOfRelease = model.DateOfRelease;
            indent.DateOfFulfillment = model.DateOfFulfillment;
            indent.IndentStatus = model.SelectedStatus;
            indent.Account = model.SelectedAccount;
            indent.TaSpoc = model.SelectedTaSpoc;
            indent.Remarks = model.Remarks;


            indentDataAccess.updateIndent(id, indent);

            return RedirectToAction("Index");
            
        }

        // GET: AccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
