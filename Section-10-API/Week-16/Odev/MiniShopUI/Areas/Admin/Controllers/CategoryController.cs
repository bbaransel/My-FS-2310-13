using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniShop.MVC.Areas.Admin.Models;
using MiniShop.MVC.Mappings.Admin;
using MiniShop.MVC.Helpers;
using System.Text;
using System.Text.Json;

namespace MiniShop.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        //public readonly IMapper _mapper;

        //public ProductController(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        public async Task<IActionResult> Index(bool id=false)
        {
            Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/categories/GetNonDeleteds/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponseApi);
            }
            ViewBag.ShowDeleted = id;
            return View(response.Data);
        }
        //public async Task<IActionResult> UpdateIsHome(int id)
        //{
        //    HttpClient httpClient = new HttpClient();

        //    HttpRequestMessage request = new HttpRequestMessage()
        //    {
        //        Method = HttpMethod.Post,
        //        RequestUri= new Uri($"http://localhost:7700/products/UpdateIsHome/{id}"),
        //        Content=new StringContent("",Encoding.UTF8,"application/json")
        //    };
        //    HttpResponseMessage response = await httpClient.SendAsync(request);

        //    return RedirectToAction("Index");
        //}
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"http://localhost:7700/categories/UpdateIsActive/{id}"),
                Content = new StringContent("", Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }

        [NonAction]
        public async Task<List<CategoryViewModel>> GetCategoriesAsync()
        {
            Response<List<CategoryViewModel>> response = new Response<List<CategoryViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:7700/Categories");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<CategoryViewModel>>>(contentResponseApi);
            }
            return response.Data;
        }

        //[HttpGet]
        //public async Task<IActionResult> Create()
        //{

        //    AddCategoryViewModel model = new AddCategoryViewModel
        //    {
        //        Categories = await GetCategoriesAsync()
        //    };
        //    return View(model);
        //}
        [HttpPost]
        public async Task<IActionResult> Create(AddCategoryViewModel model)
        {
            model.Url = Jobs.GetUrl(model.Name);
            if(ModelState.IsValid)
            {

                using (var httpClient = new HttpClient())
                {
                    var serializeModel = JsonSerializer.Serialize(model);
                    StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                    var result = await httpClient.PostAsync("http://localhost:7700/categories/add", stringContent);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }
            return View(model);
        }
        [NonAction]
        public async Task<CategoryViewModel> GetByIdAsync(int id)
        {
            Response<CategoryViewModel> response = new Response<CategoryViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:7700/Categories/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<CategoryViewModel>>(contentResponseApi);
            }
            return response.Data;
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            CategoryViewModel categoryViewModel = await GetByIdAsync(id);
            //my part
            //var model = _mapper.Map<EditProductViewModel>(productViewModel);
            //my part

            EditCategoryViewModel model = new EditCategoryViewModel()
            {
                Id = categoryViewModel.Id,
                Name = categoryViewModel.Name,
                IsActive = categoryViewModel.IsActive,
                Description = categoryViewModel.Description,
                Url = categoryViewModel.Url,
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(EditCategoryViewModel model)
        {
            model.Url = Jobs.GetUrl(model.Name);
            if (ModelState.IsValid)
            {

                using (var httpClient = new HttpClient())
                {
                    var serializeModel = JsonSerializer.Serialize(model);
                    StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                    var result = await httpClient.PutAsync("http://localhost:7700/categories/Update", stringContent);
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }
            }

            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            CategoryViewModel categoryViewModel = await GetByIdAsync(id);
            DeleteCategoryViewModel model = new DeleteCategoryViewModel()
            {
                Id = categoryViewModel.Id,
                Name = categoryViewModel.Name,
                CreatedDate = categoryViewModel.CreatedDate,
                ModifiedDate = categoryViewModel.ModifiedDate,
                IsDeleted = categoryViewModel.IsDeleted,
            };
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.DeleteAsync($"http://localhost:7700/categories/HardDelete/{id}");

            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> SoftDelete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.DeleteAsync($"http://localhost:7700/categories/SoftDelete/{id}");

            }
            var categoryViewModel = await GetByIdAsync(id);
            //return RedirectToAction("Index");
            // RedirectToAction overloadlarını araştır. 
            //TempData isimli veri taşıma yöntemini araştır. ViewBag ile temel farkını anlamaya çalışın.
            return Redirect($"/Admin/Category/Index/{!categoryViewModel.IsDeleted}");
        }
    }
}
