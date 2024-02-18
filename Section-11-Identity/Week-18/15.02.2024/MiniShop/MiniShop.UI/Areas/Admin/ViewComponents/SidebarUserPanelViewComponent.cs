using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniShop.Entity.Concrete.Identity;

namespace MiniShop.UI.Areas.Admin.ViewComponents
{
    public class SidebarUserPanelViewComponent : ViewComponent
    {
        private readonly UserManager<User> _userManager;

        public SidebarUserPanelViewComponent(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string? userName)
        {
            if (userName != null) 
            {
                var user = await _userManager.FindByNameAsync(userName);
                ViewBag.UserFullName = $"{user.FirstName} {user.LastName}";
                return View();
            }
            return View();
        }
    }
}