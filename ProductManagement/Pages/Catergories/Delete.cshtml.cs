using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ProductManagement.Data;
using ProductManagement.Model;

namespace ProductManagement.Pages.Catergories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Catergory Catergory { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? ID)
        {
            if (ID != null && ID != 0)
            {
                Catergory = _db.Categories.Find(ID);
            }
        }

        public IActionResult OnPost()
        {
            Catergory? obj = _db.Categories.Find(Catergory.ID);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Category deleted successfully";
            return RedirectToPage("Index");
        }
    }
}
