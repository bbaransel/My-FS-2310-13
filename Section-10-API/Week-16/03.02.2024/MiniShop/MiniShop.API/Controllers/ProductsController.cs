﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Shared.DTOs;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.ResponseDTOs;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MiniShop.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productManager;
        private readonly IImageHelper _imageHelper;

        public ProductsController(IProductService productManager, IImageHelper imageHelper)
        {
            _productManager = productManager;
            _imageHelper = imageHelper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("GetAllNonDeleted/{isDeleted?}")]
        public async Task<IActionResult> GetAllNonDeleted(bool isDeleted=false)
        {
            var response = await _productManager.GetAllNonDeletedAsync(isDeleted);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("GetAllWithCategories")]
        public async Task<IActionResult> GetAllWithCategories()
        {
            var response = await _productManager.GetAllProductsWithCategoriesAsync();
            //var options = new JsonSerializerOptions
            //{
            //    ReferenceHandler = ReferenceHandler.IgnoreCycles
            //};
            //var jsonResponse = JsonSerializer.Serialize(response, options);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await _productManager.GetByIdAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("GetWithCategories/{id}")]
        public async Task<IActionResult> GetWithCategories(int id)
        {
            var response = await _productManager.GetProductWithCategoriesAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("GetByCategoryId/{categoryId}")]
        public async Task<IActionResult> GetByCategoryId(int categoryId)
        {
            var response = await _productManager.GetProductsByCategoryIdAsync(categoryId);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        //[HttpPost("Create")]
        //public async Task<IActionResult> Create([FromForm] AddProductDTO addProductDTO)
        //{
        //    addProductDTO.ImageUrl = await _imageHelper.UploadImageAsync(addProductDTO.Image, "products");
        //    var response = await _productManager.CreateAsync(addProductDTO);
        //    var jsonResponse = JsonSerializer.Serialize(response);
        //    return Ok(jsonResponse);
        //}
        [HttpPost("Create")]
        public async Task<IActionResult> Create(AddProductDTO addProductDTO)
        {
            var response = await _productManager.CreateAsync(addProductDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpPost("UploadImage")]
        public async Task<IActionResult> UploadImage(IFormFile image)
        {
            var response = await _imageHelper.UploadImageAsync(image,"products");
            return Ok(response);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(EditProductDTO editProductDTO)
        {
            //Ürünün kategori bilgilerinin güncellenmesi gerçekleşmiyor.
            //MVC tarafını geliştirirken, bu meseleyi çözeceğiz.
            var response = await _productManager.UpdateAsync(editProductDTO);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpPost("UpdateIsHome/{id}")]
        public async Task<IActionResult> UpdateIsHome(int id)
        {
            var response = await _productManager.UpdateIsHomeAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpPost("UpdateIsActive/{id}")]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            var response = await _productManager.UpdateIsActiveAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("HardDelete/{id}")]
        public async Task<IActionResult> HardDelete(int id)
        {
            var response = await _productManager.HardDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpDelete("SoftDelete/{id}")]
        public async Task<IActionResult> SoftDelete(int id)
        {
            var response = await _productManager.SoftDeleteAsync(id);
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        [HttpGet("Count")]
        public async Task<IActionResult> GetCount()
        {
            var response = await _productManager.GetProductCount();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }

        [HttpGet("ActiveCount")]
        public async Task<IActionResult> GetActiveCount()
        {
            var response = await _productManager.GetActiveProductCount();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
        
    }
}
