using BulkyWebApp.Data;
using BulkyWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BulkyWebApp.Controllers
{
    public class CatergoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CatergoryController(ApplicationDbContext db)
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
                TempData["success"] = "Caterogy Created Successfully";
            return RedirectToAction("Index");
            }
            return View();
            
        }

        public IActionResult Edit(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }

            Catergory? Categoryfromdb = _db.Catergories.FirstOrDefault(u => u.ID == ID);
            if (Categoryfromdb == null)
            {
                return NotFound();
            }

            return View(Categoryfromdb);
        }


        [HttpPost]
        public IActionResult Edit(Catergory obj)
        {
            if (ModelState.IsValid)
            {
                _db.Catergories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Caterogy Edit Successfully";
                return RedirectToAction("Index");
            }
            return View();


        }

        public IActionResult Delete(int? ID)
        {
            if (ID == null || ID == 0)
            {
                return NotFound();
            }

            Catergory? Categoryfromdb = _db.Catergories.FirstOrDefault(u => u.ID == ID);
            if (Categoryfromdb == null)
            {
                return NotFound();
            }

            return View(Categoryfromdb);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? ID)
        {
            Catergory? obj = _db.Catergories.Find(ID); 
            if (obj == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Catergories.Remove(obj);
                _db.SaveChanges();
                TempData["success"] = "Caterogy Delete Successfully";
                return RedirectToAction("Index");
            }
            return View();


        }
    }
}
