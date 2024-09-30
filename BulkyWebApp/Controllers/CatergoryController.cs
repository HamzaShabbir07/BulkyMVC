using BulkyWebApp.Data;
using BulkyWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyWebApp.Controllers
{
    public class CatergoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CatergoryController( ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Catergory> objcatergorylist = _db.Catergories.ToList();
            return View(objcatergorylist);
        }
    }
}
