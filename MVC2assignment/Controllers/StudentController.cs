using Microsoft.AspNetCore.Mvc;
using MVC2assignment.Models;

namespace MVC2assignment.Controllers
{
    public class StudentController : Controller
    {
        Student student= new Student();
        public IActionResult Index()
        {
            student.Name ="Chirag";
            student.Address = "Delhi";

            ViewBag.NameOfStudent = student.Name;
            ViewBag.AddressOfStudent = student.Address;
            return View();
        }
    }
}
