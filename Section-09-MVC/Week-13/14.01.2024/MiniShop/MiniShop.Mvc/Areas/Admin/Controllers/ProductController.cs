using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Core.ViewModels;

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
            var products = _productManager.GetAll(null, null, false);
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductViewModel productViewModel)
        {
            _productManager.Create(productViewModel);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ProductViewModel editedProduct = _productManager.GetById(id);
            return View(editedProduct);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel editedProduct)
        {
            _productManager.Update(editedProduct);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ProductViewModel deletedProduct = _productManager.GetById(id);
            return View(deletedProduct);
        }
       
        public IActionResult HardDelete(int id)
        {
            _productManager.HardDelete(id);
            return RedirectToAction("Index");
        }
        public IActionResult SoftDelete(int id)
        {
            _productManager.SoftDelete(id);
            return RedirectToAction("Index");
        }
    }
}
