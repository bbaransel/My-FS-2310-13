using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;

namespace MiniShop.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly IShoppingCartService _shoppingCartManager;
        private readonly IShoppingCartItemService _shoppingCartItemService;

        public ShoppingCartController(UserManager<User> userManager, IShoppingCartService shoppingCartManager, IShoppingCartItemService shoppingCartItemService)
        {
            _userManager = userManager;
            _shoppingCartManager = shoppingCartManager;
            _shoppingCartItemService = shoppingCartItemService;
        }

        // Kullanıcının sepetini gösterecek
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            var shoppingCart = await _shoppingCartManager.GetShoppingCartByUserIdAsync(userId);
            return View(shoppingCart.Data);
        }
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            var userId =  _userManager.GetUserId(User);
            await _shoppingCartManager.AddToCartAsync(userId, productId, quantity);
            return Redirect("~/");
        }
        public async Task<IActionResult> ChangeQuantity(ShoppingCartItemViewModel shoppingCartItemViewModel)
        {
            if(ModelState.IsValid)
            {
                await _shoppingCartItemService.ChangeQuantityAsync(shoppingCartItemViewModel.Id, shoppingCartItemViewModel.Quantity);
                return RedirectToAction("Index");
            }
            return View(shoppingCartItemViewModel);
        }
    }
}
