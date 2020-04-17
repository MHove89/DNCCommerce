using Microsoft.AspNetCore.Mvc;

namespace DNCommerce.Admin.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
