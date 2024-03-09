using MiniShop.UI.Extensions;

var builder = WebApplication.CreateBuilder(args);
#region ServicesRegion
builder.Services.AddControllersWithViews();

builder.Services.LoadMyDbContextServices();
builder.Services.LoadMyIdentityServices();
builder.Services.LoadMyRepositoryServices();
builder.Services.LoadMyOtherServices();
#endregion

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
#region RouteRegion

app.MapControllerRoute(
    name: "products",
    pattern: "urunler/{categoryUrl?}",
    defaults: new { controller = "Product", action = "Index" }
    );

app.MapAreaControllerRoute(
    name: "adminproducts",
    pattern: "yönetici/urunler/{isdeleted?}",
    areaName: "Admin",
    defaults: new { controller = "Product", action = "Index" }
    );

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
#endregion

app.UpdateDatabase().Run();
