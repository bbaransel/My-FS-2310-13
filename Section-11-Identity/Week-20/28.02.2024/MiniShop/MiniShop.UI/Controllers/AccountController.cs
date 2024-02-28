using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ViewModels.IdentityModels;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOrderService _orderManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _orderManager = orderManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                User user = new User
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    FirstName = registerViewModel.FirstName,
                    LastName = registerViewModel.LastName,
                };
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    return Redirect("~/");
                }
            }
            return View(registerViewModel);
        }
        [HttpGet]
        public IActionResult Login(string returnUrl = null) 
        {
            if (returnUrl != null)
            {
                TempData["ReturnUrl"] = returnUrl;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }
            var user =await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı bulunamadı");
                return View(loginViewModel);
            }
            var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, false, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifre hatalı");
                return View(loginViewModel);
            }
            var returnUrl = TempData["ReturnUrl"]?.ToString();
            if (!String.IsNullOrEmpty(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["ReturnUrl"] = null;
            return Redirect("~/");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }

        public async Task<IActionResult> Profile()
        {
            var userId = _userManager.GetUserId(User);
            var orders = await _orderManager.GetOrdersAsync(userId);
            var user = await _userManager.FindByIdAsync(userId);
            //Şimdilik view'e order listesi yolluyoruz. Sonraki aşamalarda bu liste ile başka bilgilerde yollayacağız.
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel
            {
                User = new UserViewModel
                {
                    Id = userId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Address = user.Address,
                    City = user.City,
                    Gender = user.Gender,
                    DateOfBirth = user.DateOfBirth,
                    UserName = user.UserName
                },
                Orders = orders
            };
            return View(userProfileViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Profile(UserProfileViewModel userProfileViewModel)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);
            if(ModelState.IsValid)
            {
                user.FirstName = userProfileViewModel.User.FirstName;
                user.LastName = userProfileViewModel.User.LastName;
                user.PhoneNumber = userProfileViewModel.User.PhoneNumber;
                user.UserName = userProfileViewModel.User.UserName;
                user.Email = userProfileViewModel.User.Email;
                user.Address = userProfileViewModel.User.Address;
                user.City = userProfileViewModel.User.City;
                user.DateOfBirth = userProfileViewModel.User.DateOfBirth;
                user.Gender = userProfileViewModel.User.Gender;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _userManager.UpdateSecurityStampAsync(user);
                    await _signInManager.SignOutAsync();
                    await _signInManager.SignInAsync(user,false);
                    return Redirect("~/");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            userProfileViewModel.Orders = await _orderManager.GetOrdersAsync(userId);
            return View(userProfileViewModel);
        }
        public async Task<IActionResult> ChangePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(_userManager.GetUserId(User));
                var isVerified = await _userManager.CheckPasswordAsync(user, changePasswordViewModel.CurrentPassword);
                if (isVerified)
                {
                    var result = await _userManager.ChangePasswordAsync(user, changePasswordViewModel.CurrentPassword, changePasswordViewModel.NewPassword);
                    if (result.Succeeded)
                    {
                        var updateSecurityStampResult = await _userManager.UpdateSecurityStampAsync(user);
                        await _signInManager.SignOutAsync();
                        await _signInManager.PasswordSignInAsync(user, changePasswordViewModel.NewPassword, false, false);
                        return RedirectToAction("Profile");
                    }
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changePasswordViewModel);
                }
                ModelState.AddModelError("", "Geçerli şifre hatalı!");
                return View(changePasswordViewModel);
            }
            return View();
        }
    }
}
