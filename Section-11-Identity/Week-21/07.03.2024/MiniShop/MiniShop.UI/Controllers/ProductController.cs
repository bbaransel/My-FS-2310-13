using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.UI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;

        public ProductController(IProductService productManager, ICategoryService categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }

        public async Task<IActionResult> Index(string categoryUrl = null)
        {
            var products = "" ?
                await _productManager.GetAllNonDeletedAsync() :
                    await _productManager.GetProductsByCategoryUrlAsync(categoryUrl);
            var category = categoryUrl != null ? await _categoryManager.GetByIdAsync(Convert.ToInt32(id)) : null;
            ViewBag.CategoryName = category.Data != null ? category.Data.Name : null;
            return View(products.Data);
        }
        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var product = await _productManager.GetByIdAsync(id);
            return View(product.Data);
        }
    }
}
