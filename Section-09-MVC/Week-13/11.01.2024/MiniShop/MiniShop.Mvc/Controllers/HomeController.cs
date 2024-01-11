using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Mvc.Models;
using System.Diagnostics;

namespace MiniShop.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productManager;

        public HomeController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            var products = _productManager.GetAll(true);
            return View(products);
        }
    }
}
