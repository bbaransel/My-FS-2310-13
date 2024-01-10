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
                                    c.Description as 'Desc'
                                  from Categories c
                                  order by Id ";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, Db.connection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            List<CategoryViewModel> list = new List<CategoryViewModel>();
            CategoryViewModel categoryViewModel = null;
            foreach (DataRow categoryRow in dataTable.Rows)
            {
                //categoryViewModel = new CategoryViewModel
                //{
                //    Id = Convert.ToInt32(categoryRow[0]),
                //    Name = categoryRow[1].ToString(),
                //    Desc = categoryRow[2].ToString()
                //};
                //list.Add(categoryViewModel);
                list.Add(new CategoryViewModel
                {
                    Id = Convert.ToInt32(categoryRow[0]),
                    Name = categoryRow[1].ToString(),
                    Desc = categoryRow[2].ToString()
                });
            }

            return View(list);
        }
    }
}