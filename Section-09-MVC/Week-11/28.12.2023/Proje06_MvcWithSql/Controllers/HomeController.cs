using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.Models;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        List<ProductViewModel> list = new List<ProductViewModel>{
            new ProductViewModel {Name="IPhone 13", Price= 50000},
            new ProductViewModel {Name="IPhone 14", Price=50000},
            new ProductViewModel {Name="IPhone 15", Price=50000},
            new ProductViewModel {Name="IPhone 16", Price=50000 },
            new ProductViewModel {Name="IPhone 17", Price=50000 },
        };
        try
        {
            Db.OpenCn();

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return View(list);
    }
}
