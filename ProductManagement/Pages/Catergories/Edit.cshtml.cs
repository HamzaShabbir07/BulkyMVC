using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Data;
using ProductManagement.Model;

namespace ProductManagement.Pages.Catergories
{
    
    public class EditModel : PageModel
    {
        
        private readonly ApplicationDbContext _context;
        
        [BindProperty]
        public Catergory Catergory { get; set; }
        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return RedirectToPage("Index"); 
            }

            Catergory = _context.Categories.FirstOrDefault(c => c.ID == ID);

            if (Catergory == null)
            {
                return NotFound(); 
            }

            return Page(); 
        }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Catergory.ID == 0)
                {
                    return BadRequest("Invalid Category ID.");
                }

                _context.Categories.Update(Catergory);
                _context.SaveChanges();

                return RedirectToPage("Index");
            }

            return Page();
        }
    }
}
