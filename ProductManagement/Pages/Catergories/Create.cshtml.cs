using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json.Schema;
using ProductManagement.Data;
using ProductManagement.Model;
using System.Reflection.Metadata.Ecma335;

namespace ProductManagement.Pages.Catergories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Catergory Category { get; set; }
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
