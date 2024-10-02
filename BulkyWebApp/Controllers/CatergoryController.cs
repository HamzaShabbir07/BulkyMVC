using BulkyWebApp.Data;
using BulkyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Catergory obj)
        {
            if(obj.Name == obj.Display_Order.ToString())
            {
                ModelState.AddModelError("name", "Cannot Same value");
                ModelState.AddModelError( "display_order", "Cannot Same value");
            }
            if (ModelState.IsValid)
            {
            _db.Catergories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
            }
            return View();
            

        }
    }
}
