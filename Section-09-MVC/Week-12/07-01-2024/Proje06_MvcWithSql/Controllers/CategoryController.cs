using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Proje06_MvcWithSql.Dal;
using Proje06_MvcWithSql.ViewModels;

namespace Proje06_MvcWithSql.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            Db.OpenCn();
            string queryString = @"select 
	                                    c.CategoryID as Id,
	                                    c.CategoryName as Name,
	                                    c.Description as Description
                                    from Categories c";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Db.connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            List<CategoryViewModel> categories = new List<CategoryViewModel>();
            CategoryViewModel categoryViewModel = null;
            foreach (DataRow row in dataTable.Rows)
            {
                //categoryViewModel = new CategoryViewModel
                //{
                //    Id = Convert.ToInt32(row["Id"]),
                //    Name = row["Name"].ToString(),
                //    Description = row["Description"].ToString()
                //};
                //categories.Add(categoryViewModel);
                categories.Add(new CategoryViewModel
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Name"]),
                    Description = Convert.ToString(row["Description"])
                });
            }
            return View(categories);
        }
    }
}