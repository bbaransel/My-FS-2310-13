using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;

namespace MiniShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var response =  await _categoryManager.GetAllCategoriesWithProductsAsync();
            return null;
        }
    }
}
