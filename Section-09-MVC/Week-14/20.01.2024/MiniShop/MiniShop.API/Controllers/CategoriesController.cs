using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;
using System.Text.Json;

namespace MiniShop.API.Controllers
{
    [Route("[controller]")]
    // Eğer actionlara tek tek özel isim vermek istemiyorsan 
    // [Route("[controller]/[action]")] olarak kullanarak actionlardaki fonksiyon adını kullanmasını sağlayabilirsin.
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesController(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var response =  await _categoryManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        
        [HttpGet("getwithproducts")]
        public async Task<IActionResult> GetWithProducts()
        {
            var response = await _categoryManager.GetAllCategoriesWithProductsAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _categoryManager.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpPost("add")]
        public async Task<IActionResult> Create(AddCategoryDTO addCategoryDTO)
        {
            var response = await _categoryManager.CreateAsync(addCategoryDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpPut("update")] // Bu metot güncelleme işlemlerinde kullanırlır.
        public async Task<IActionResult> Update(EditCategoryDTO editCategoryDTO)
        {
            var response = await _categoryManager.UpdateAsync(editCategoryDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpDelete("harddelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _categoryManager.HardDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpDelete("softdelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _categoryManager.SoftDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpGet("getnondeleted")]
        public async Task<IActionResult> GetNonDeleted()
        {
            var response = await _categoryManager.GetNonDeletedCategoriesAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpGet("isactiveisdeleted/{isActive}/{isDeleted}")]
        public async Task<IActionResult> GetAllCategoriesActiveDeletedAsync(bool? isActive = null, bool? isDeleted = null)
        {
            var response = await _categoryManager.GetAllCategoriesActiveDeletedAsync(isActive, isDeleted);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
