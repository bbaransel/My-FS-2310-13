using AjaxIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxIntro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }
        [HttpPost]
        public PartialViewResult AddStudent(string firstName, string lastName, string stundentNumber)
        {
            Student student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                StudentNumber = Convert.ToInt32(stundentNumber)
            };
            _context.Students.Add(student);
            _context.SaveChanges();
            var students = _context.Students.ToList();
            return PartialView("_StudentListPartial", students);
        }

        [HttpGet]
        public IActionResult ChangeIsActive(int id) 
        {
            var student = _context.Students.Find(id);
            student.IsActive= !student.IsActive;
            _context.SaveChanges();
            return Json(student.IsActive);
        }

    }
}