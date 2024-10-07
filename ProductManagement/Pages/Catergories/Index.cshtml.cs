using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductManagement.Data;
using ProductManagement.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ProductManagement.Pages.Catergories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public List<Catergory> CategoryList  { get; set; }
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            CategoryList = _context.Categories.ToList();


        }
    }
}

