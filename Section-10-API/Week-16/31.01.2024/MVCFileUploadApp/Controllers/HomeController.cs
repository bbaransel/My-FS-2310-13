using Microsoft.AspNetCore.Mvc;
using MVCFileUploadApp.Core;
using MVCFileUploadApp.Models;
using System.Diagnostics;

namespace MVCFileUploadApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult UploadImage(IFormFile image) 
        {
            if (image == null)
            {
                //ViewBag.Status = false;
                ViewBag.Message = "Resimde bir sorun var lütfen tekrar deneyiniz.";
                return View("Index");
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", image.FileName);
            using (var stream = new FileStream(path,FileMode.Create))
            {
                image.CopyTo(stream);
            }


            //ViewBag.Status = true;
            ViewBag.Message = "Resim başarı ile yüklendi";
            return View("Index"); 
        }

        [HttpGet]
        public IActionResult ResimYukle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ResimYukle(IFormFile image)
        {
            // Burada resim yükleme için yazacağımız methodu çağıracağız.
            var ImageUrl = Uploader.UploadImage(image);
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}