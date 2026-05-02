using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        //{
        //    var students = new List<string> { "Rijo", "Sebasitan" };
        //    return View(students);
        //}
        {
            var students = new List<Student>
       {
           new Student { Name = "Rijo" },
            new Student { Name = "Sebasitan" }

       };
            return View(students);
        }
    }
}
