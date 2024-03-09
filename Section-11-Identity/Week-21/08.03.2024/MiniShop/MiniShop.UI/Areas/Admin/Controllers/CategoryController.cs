using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.ResponseViewModels;
using MiniShop.Shared.ViewModels;
using MiniShop.UI.Helpers;

namespace MiniShop.UI.Areas.Admin.Controllers
{
    [Authorize(Roles = "SuperAdmin")]
    [Area("Admin")]
    public class CategoryController : Controller
    {

        private readonly IProductService _productManager;
        private readonly ICategoryService _categoryManager;

        public CategoryController(IProductService productManager, ICategoryService categoryManager)
        {
            _productManager = productManager;
            _categoryManager = categoryManager;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(bool id = false)
        {
            Response<List<CategoryViewModel>> categories = await _categoryManager.GetNonDeletedCategories(id);
            ViewBag.IsDeleted = id;
            return View(categories.Data);
        }
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var result = await _categoryManager.UpdateIsActiveAsync(id);
            var category = await _categoryManager.GetByIdAsync(id);
            return Json(category.Data.IsActive);
        }
        [HttpGet]
        public IActionResult Create()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(AddCategoryViewModel addCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                addCategoryViewModel.Url = Jobs.GetUrl(addCategoryViewModel.Name);
                await _categoryManager.CreateAsync(addCategoryViewModel);
                return Redirect($"/Admin/Category/Index/false");
            }
            return View(addCategoryViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var categoryResponse = await _categoryManager.GetByIdAsync(id);
            EditCategoryViewModel editCategoryViewModel = new EditCategoryViewModel
            {
                Id = categoryResponse.Data.Id,
                Name = categoryResponse.Data.Name,
                Description = categoryResponse.Data.Description,
                IsActive = categoryResponse.Data.IsActive,
            };
            return View(editCategoryViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditCategoryViewModel editCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                editCategoryViewModel.Url = Jobs.GetUrl(editCategoryViewModel.Name);
                await _categoryManager.UpdateAsync(editCategoryViewModel);
                return Redirect($"/Admin/Category/Index/false");
            }
            return View(editCategoryViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var category = await _categoryManager.GetByIdAsync(id);
            CategoryViewModel categoryViewModel = category.Data;
            DeleteCategoryViewModel model = new DeleteCategoryViewModel
            {
                Id = categoryViewModel.Id,
                Name = categoryViewModel.Name,
                CreatedDate = categoryViewModel.CreatedDate,
                ModifiedDate = categoryViewModel.ModifiedDate,
                IsDeleted = categoryViewModel.IsDeleted,
                Description = categoryViewModel.Description,
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            await _categoryManager.HardDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> SoftDelete(int id)
        {
            await _categoryManager.SoftDeleteAsync(id);
            var response = await _productManager.GetByIdAsync(id);
            return Redirect($"/Admin/Category/Index/{!response.Data.IsDeleted}");
        }
    }
}
