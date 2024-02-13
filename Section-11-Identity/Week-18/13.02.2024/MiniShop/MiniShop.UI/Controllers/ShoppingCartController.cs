using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly UserManager<User> _userManager;

        public ShoppingCartController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        // Kullanıcının sepetini gösterecek
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            await _userManager.GetUserId(User)
        }
    }
}
