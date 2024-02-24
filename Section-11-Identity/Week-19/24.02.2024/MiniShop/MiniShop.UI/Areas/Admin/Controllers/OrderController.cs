using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiniShop.Business.Abstract;
using MiniShop.UI.Areas.Admin.Models;

namespace MiniShop.UI.Areas.Admin.Controllers
{
    [Authorize(Roles ="SuperAdmin, Admin")]
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderManager;
        private readonly IProductService _productManager;

        public OrderController(IOrderService orderManager, IProductService productManager)
        {
            _orderManager = orderManager;
            _productManager = productManager;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _orderManager.GetOrdersAsync();
            var response = await _productManager.GetAllNonDeletedAsync();
            var products = response.Data;
            List<SelectListItem> productListItems = products.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            }).ToList();
            var result = new OrderFilterViewModel
            {
                Orders = orders,
                ProductListItems = productListItems
            };
            return View(result);
        }
    }
}
