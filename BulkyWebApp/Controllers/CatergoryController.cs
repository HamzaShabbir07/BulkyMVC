using Microsoft.AspNetCore.Mvc;

namespace BulkyWebApp.Controllers
{
    public class CatergoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
