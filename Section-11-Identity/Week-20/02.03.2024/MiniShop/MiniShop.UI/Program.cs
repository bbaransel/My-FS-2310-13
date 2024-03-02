using AspNetCoreHero.ToastNotification;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MiniShop.Business.Abstract;
using MiniShop.Business.Concrete;
using MiniShop.Data.Abstract;
using MiniShop.Data.Concrete.Contexts;
using MiniShop.Data.Concrete.Repositories;
using MiniShop.Entity.Concrete.Identity;
using MiniShop.Shared.Helpers.Abstract;
using MiniShop.Shared.Helpers.Concrete;
using MiniShop.UI.EmailServices.Abstract;
using MiniShop.UI.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MiniShopDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection"))
);

builder.Services.AddIdentity<User,Role>().AddEntityFrameworkStores<MiniShopDbContext>().AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(options =>
{
    #region Password Options
    options.Password.RequiredLength = 6;// Parola en az 6 karakter olmalý
    options.Password.RequireDigit = true;//Parola en az 1 adet sayýsal deðer içermeli
    options.Password.RequireNonAlphanumeric = true;//Parola özel karakter içermeli
    options.Password.RequireUppercase = true;// Parola büyük harf içermeli
    options.Password.RequireLowercase = true;// Parola küçük harf içermeli
                                             //options.Password.RequiredUniqueChars = // tekrar etmemesi istenilen karakterleri dizi þeklinde verip kullanýlýyor. 
    #endregion
    #region Hesap Kilitleme Ayarlarý
    options.Lockout.MaxFailedAccessAttempts = 3; // Üst üste hatalý giriþ denemesi
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(15); // kilitlenmiþ bir hesaba yeniden giriþ yapabilmek için gereken bekleme süresi
    //options.Lockout.AllowedForNewUsers = true; // Yeniden kayýt olmaya imkan ver
    #endregion
    options.User.RequireUniqueEmail = true; //Her email 1 kere kayýt olabilir.
    options.SignIn.RequireConfirmedEmail = false;

});
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(2);
    options.SlidingExpiration = true;
    options.Cookie = new CookieBuilder
    {
        Name = "MiniShop.Security",
        //Güvenlik önlemleri(default olarak none)
        HttpOnly = true,
        SameSite = SameSiteMode.Strict
    };
});

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IShoppingCartService, ShoppingCartManager>();
builder.Services.AddScoped<IShoppingCartItemService, ShoppingCartItemManager>();
builder.Services.AddScoped<IOrderService, OrderManager>();

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IShoppingCartRepository, ShoppingCartRepository>();
builder.Services.AddScoped<IShoppingCartItemRepository, ShoppingCartItemRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IImageHelper, ImageHelper>();

builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(options => new SmtpEmailSender(
    builder.Configuration["EmailSender:Host"],
    builder.Configuration.GetValue<int>("EmailSender:Port"),
    builder.Configuration.GetValue<bool>("EmailSender:EnableSsl"),
    builder.Configuration["EmailSender:UserName"],
    builder.Configuration["EmailSender:Password"]
    ));

builder.Services.AddNotyf(options =>
{
    options.DurationInSeconds = 3;
    options.IsDismissable = true;
    options.Position = NotyfPosition.TopRight;
});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
