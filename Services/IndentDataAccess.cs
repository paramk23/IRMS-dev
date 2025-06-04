using Indent_Dev.Models;
using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;

namespace Indent_Dev.Services
{
    public class IndentDataAccess
    {
        
        public List<Category> GetAllCategories()
        {
            IrmsDevContext context = new IrmsDevContext();
            var Category = context.Categories.ToList();
            return Category;
        }

        public List<SubCategory> GetAllSubCategories()
        {
            IrmsDevContext context = new IrmsDevContext();
            var SubCategory = context.SubCategories.ToList();
            return SubCategory;
        }

        public List<SubCategory> GetSubCategoriesBasedOnCategory(string Category)
        {
            IrmsDevContext context= new IrmsDevContext();
            var SubCategory = context.SubCategories.Where(u => u.Category == Category).ToList();
            return SubCategory;
        }

        public List <TaSpoc> GetTaSpocs()
        {
            IrmsDevContext context=new IrmsDevContext();
            var TaSpoc = context.TaSpocs.ToList();
            return TaSpoc;
        }

        public List<Account> GetAccounts()
        {
            IrmsDevContext context = new IrmsDevContext();
            var Accounts = context.Accounts.ToList();
            return Accounts;
        }

        public List<Location> GetLocations()
        {
            IrmsDevContext context = new IrmsDevContext();
            var Locations = context.Locations.ToList();
            return Locations;
        }

        public List<IndentStatus> GetIndentStatusForNew()
        {
            IrmsDevContext context = new IrmsDevContext();
            var Status = context.IndentStatuses.ToList();
            return Status;
        }

        public bool AddIndent(Indent model)
        {
            IrmsDevContext context =new IrmsDevContext();
            Indent indent = new Indent();
            indent = model;
            context.Indents.Add(indent);
            context.SaveChanges();
            return true;
        }

        public Indent FetchEditDetails(string id)
        {
            IrmsDevContext context = new IrmsDevContext();
            Indent indent = new Indent();

            indent = context.Indents.Where(A => A.IndentNumber == id).FirstOrDefault();
            return indent;
        }

        public void updateIndent(string id , Indent updatedIndent)
        {
            IrmsDevContext context = new IrmsDevContext();
            context.Indents.Update(updatedIndent);
            context.SaveChanges();
        }
    }
    



    //public class List<SubCategory> GetSubCategoryBasedCategory()
    //{

    //}
}
