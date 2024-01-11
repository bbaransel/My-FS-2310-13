using Microsoft.AspNetCore.Mvc;
using MiniShop.Mvc.Models;
using System.Diagnostics;

namespace MiniShop.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
