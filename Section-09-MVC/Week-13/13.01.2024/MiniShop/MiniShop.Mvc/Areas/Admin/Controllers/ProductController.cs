using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;

        public ProductController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            var products = _productManager.GetAll();
            return View(products);
        }
    }
}
