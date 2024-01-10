using Microsoft.AspNetCore.Mvc;

namespace Proje06_MvcWithSql.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
