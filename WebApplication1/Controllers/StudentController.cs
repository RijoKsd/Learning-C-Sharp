using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<string> { "Rijo", "Sebasitan" };
            return View(students);
        }
    }
}
