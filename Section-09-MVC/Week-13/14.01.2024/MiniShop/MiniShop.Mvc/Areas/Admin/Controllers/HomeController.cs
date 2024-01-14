using Microsoft.AspNetCore.Mvc;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]//attribute
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
