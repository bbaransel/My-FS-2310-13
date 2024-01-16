using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;

namespace MiniShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;

        public CategoryController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            var categories = _categoryManager.GetAll();
            return View(categories);
        }
    }
}
