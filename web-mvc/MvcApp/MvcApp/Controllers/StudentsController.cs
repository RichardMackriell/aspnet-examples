using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;

namespace MvcApp.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                return View("Registered", student);
            }
            else
            {
                return View(student);
            }
        }
    }
}
