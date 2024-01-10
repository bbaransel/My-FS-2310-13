using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Db.OpenCn();
            string queryString = @"select 
                                p.ProductID as Id,
                                p.ProductName as 'Name',
                                p.UnitPrice as Price,
                                p.CategoryID as CategoryId,
                                p.UnitsInStock as Stock
                             from Products p
                             order by p.UnitsInStock desc";
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(queryString, Db.connection);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter2.Fill(dataTable2);
            List<ProductViewModel> products = new List<ProductViewModel>();
            ProductViewModel productViewModel2 = null;
            foreach (DataRow productRow in dataTable2.Rows)
            {
                productViewModel2 = new ProductViewModel
                {
                    Id = Convert.ToInt32(productRow[0]),
                    Name = productRow[1].ToString(),
                    Price = Convert.ToDecimal(productRow[2]),
                    CategoryId = Convert.ToInt32(productRow[3]),
                    Stock = Convert.ToInt32(productRow[4])
                };
                products.Add(productViewModel2);
            }
            Db.CloseCn();
            Db.OpenCn();
            queryString = @"select 
                        c.CategoryID as Id,
                        c.CategoryName as Name
                        from Categories c
                        order by Id ";
            SqlCommand cmd = new SqlCommand(queryString, Db.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            List<CategoryViewModel> categories = new List<CategoryViewModel>();
            CategoryViewModel category = null;
            while (reader.Read())
            {
                category = new CategoryViewModel
                {
                    Id = Convert.ToInt32(reader[0]),
                    Name = reader[1].ToString(),
                };
                categories.Add(category);
            }
            Db.CloseCn();
            CategoriesProducts model = new CategoriesProducts
            {
                Products = products,
                Categories = categories
            };


            return View(products);
        }
    }
}