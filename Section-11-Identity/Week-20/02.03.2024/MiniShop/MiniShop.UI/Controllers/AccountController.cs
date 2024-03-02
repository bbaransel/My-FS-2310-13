using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MiniShop.Business.Abstract;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.ViewModels;
using MiniShop.Shared.ViewModels.IdentityModels;
using MiniShop.UI.EmailServices.Abstract;

namespace MiniShop.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IOrderService _orderManager;
        private readonly IEmailSender _emailSender;
        private readonly IShoppingCartService _shoppingCartManager;
        private readonly INotyfService _notyfService;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IOrderService orderManager, IEmailSender emailSender, IShoppingCartService shoppingCartManager, INotyfService notyfService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _orderManager = orderManager;
            _emailSender = emailSender;
            _shoppingCartManager = shoppingCartManager;
            _notyfService = notyfService;
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
                    EmailConfirmed = true
                };
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    ////Mail gönderme işlemi başlıyor.
                    ////Token oluşturma
                    //var tokenCode = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    //var backUrl = Url.Action("ConfirmEmail", "Account", new
                    //{
                    //    userId = user.Id,
                    //    token = tokenCode
                    //});
                    ////Mail Gönderme
                    //await _emailSender.SendEmailAsync(user.Email, "<p>MiniShopApp Üyelik Onayı", $"MiniShopApp uygulamasına üyeliğinizi onaylamak için aşağıdaki linke tıklayınız.</p><a href='https://localhost:59079{backUrl}'>Onay Linki</a>");

                    // Yukarıdaki email onay kodlarını aktifleştirdiğimizde sileceğiz.
                    await _shoppingCartManager.InitializeShoppingCartAsync(user.Id);
                    _notyfService.Success("Üyeliğiniz başarı ile oluşturuldu, epostanızı kontrol ederek üyeliğinizi onaylayabilirsiniz.",10);
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
            if (ModelState.IsValid)
            {
                var user =await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user == null)
                {
                    _notyfService.Error("Kullanıcı adı veya şifre hatalı");
                    return View(loginViewModel);
                }
                var isComfirmed = await _userManager.IsEmailConfirmedAsync(user);
                if (!isComfirmed)
                {
                    _notyfService.Warning("Hesabınız onaylı değildir. Lütfen mailinize gelen maildeki link üzerinden hesabınızı onaylayabilirsiniz.", 10);
                    return View(loginViewModel);
                }
                var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, true);
                if (result.Succeeded)
                {
                    var returnUrl = TempData["ReturnUrl"]?.ToString();
                    _notyfService.Information("Başarı ile giriş yapıldı. Hoş geldiniz!");
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }else if (result.IsLockedOut)
                {
                    //program cs dosyasında ayarladığımız yeniden deneme için geçmesi gereken süreyi alıyoruz.
                    var duration = _signInManager.Options.Lockout.DefaultLockoutTimeSpan.TotalSeconds;
                    //await _userManager.getlock
                    _notyfService.Information($"Hesap kilitlendi. {duration} süre sonra tekrar deneyiniz.");
                    return View(loginViewModel);
                }
                else
                {
                    var attempCount = _signInManager.Options.Lockout.MaxFailedAccessAttempts;
                    var failedAttempCount = await _userManager.GetAccessFailedCountAsync(user);
                    if(attempCount== failedAttempCount)
                    {
                        await _userManager.SetLockoutEnabledAsync(user, true);
                        _notyfService.Information("Hesabınız kilitlendi");
                    }
                    else
                    {
                    var accessFailedCount = attempCount - failedAttempCount;
                    _notyfService.Information($"Kalan hakkınız: {accessFailedCount}");
                    }
                }
            }
                    return View(loginViewModel);

        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            TempData["ReturnUrl"] = null;
            _notyfService.Success("Başarı ile çıkış yapıldı.");
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
                    _notyfService.Success("Profiliniz başarı ile güncellenmiştir.");
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
        public IActionResult ChangePassword()
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
                        _notyfService.Success("Şifreniz başarı ile değiştirilmiştir.");
                        return RedirectToAction("Profile");
                    }
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(changePasswordViewModel);
                }
                _notyfService.Warning("Geçerli şifreiz hatalıdır.");
            }
            return View();
        }
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                _notyfService.Warning("Bilgilerinizde hata var, kontrol ediniz.");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                _notyfService.Error("Geçerli kullanıcı bulunamadı");
                return View();
            }
            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                // Bu kişi onaylı bir user olduğuna göre bir shoppingcart oluşturuyoruz.
                await _shoppingCartManager.InitializeShoppingCartAsync(userId);
                _notyfService.Success("Hesabınız başarı ile onaylanmıştır.");
                return RedirectToAction("Login");
            }
            _notyfService.Error("Hesabınız onaylanırken bir hata oluştu, daha sonra tekrar deneyiniz.");
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string email)
        {
            if (email == null)
            {
                ModelState.AddModelError("", "Eposta adresi boş bırakılamaz.");
                return View() ;
            }
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                ModelState.AddModelError("", "Geçerli epostaya ait hesap bulunamadı.");
                return View();
            }
            var tokenCode = await _userManager.GeneratePasswordResetTokenAsync(user);
            var backUrl = Url.Action("ResetPassword", "Account", new
            {
                userId = user.Id,
                tokenCode = tokenCode
            });
            var subject = "MiniShopApp Şifre Sıfırlama";
            var htmlMessage = $"<h1>MiniShopApp Şifre Sıfırlama İşlemi</h1>" +
                $"<p>" +
                $"Lütfen şifrenizi sıfırlamak için aşağıdaki linke tıklayınız." +
                $"</p>" +
                $"<a href='https://localhost:59079{backUrl}'>Şifreyi sıfırla</a>";
            await _emailSender.SendEmailAsync(email, subject, htmlMessage);
            _notyfService.Success("Şifre sıfırlama linki mailinize iletilmiştir.");
            return RedirectToAction("Login");
        }
        public async Task<IActionResult> ResetPassword(string userId, string tokenCode)
        {
            if(userId == null || tokenCode == null)
            {
                ModelState.AddModelError("", "Bir sorun oluştu");
                return View();
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı");
                return View();
            }
            ResetPasswordViewModel resetPasswordViewModel = new ResetPasswordViewModel
            {
                UserId = userId,
                TokenCode = tokenCode
            };
            return View(resetPasswordViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = await _userManager.FindByIdAsync(resetPasswordViewModel.UserId);
            if (user == null)
            {
                ModelState.AddModelError("", "Böyle bir kullanıcı bulunamadı.");
                return View(resetPasswordViewModel);
            }
            var result = await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.TokenCode, resetPasswordViewModel.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return View(resetPasswordViewModel);
        }
    }
}
