using EF_Core.Data;
using EF_Core.Model;
//using EF_Core_Series.Data;
//using EF_Core_Series.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Series.Controllers
{
    public class StudentController(AppDbContext _context) : Controller
    {
        // Index: Fetches all students and shows them as raw JSON
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return Json(students); // Direct output to browser
        }
        public IActionResult Seed()
        {
            var newStudent = new Student { Name = "Rijo Sebastian", Email = "test@example.com" };
            _context.Students.Add(newStudent);
            _context.SaveChanges();

            return RedirectToAction("Index"); // This will show the JSON list with the new student
        }

    }

}