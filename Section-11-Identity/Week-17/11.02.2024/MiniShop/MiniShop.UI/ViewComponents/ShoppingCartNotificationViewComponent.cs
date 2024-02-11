using Microsoft.AspNetCore.Mvc;

namespace MiniShop.UI.ViewComponents
{
    public class ShoppingCartNotificationViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            return View();
        }
    }
}
