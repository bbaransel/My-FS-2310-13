var builder = WebApplication.CreateBuilder(args);

/*
 * AddControllersWithViews servisi, bu projenin bir MVC uygulamasý olmasýný saðlar. Burada ControllersWithViews servisini IOC (servis havuzu) içine koymuþ oluruz. Uygulama ihtiyaç duyduðu her anda bu havuzdan bu bilgiyi edinebilir.
 * Peki ya MVC nedir?
 * Model: Projemizdeki veri, ver tabaný gibi iþleri yürüttüðümüz bölüm.
 * View: Projemizdeki arayüzü temsil eden bölüm.
 * Controller: Gelen tüm istekleri karþýlayan yani projemizin asýl backend kodlarýnýn yer alacaðý bölüm.
 
*/

builder.Services.AddControllersWithViews();

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
// https://localhost:5069/Product/AddProduct
// https://localhost:5069/
// https://localhost:5069/Home/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
