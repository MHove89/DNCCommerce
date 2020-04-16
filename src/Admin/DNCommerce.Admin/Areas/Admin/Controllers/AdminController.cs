using Microsoft.AspNetCore.Mvc;

namespace DNCommerce.Admin.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            return View($"~/Areas/Admin/Views/Admin/Index.cshtml");
        }
    }
}
