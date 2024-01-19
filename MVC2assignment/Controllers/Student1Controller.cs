using Microsoft.AspNetCore.Mvc;
using MVC2assignment.Models;

namespace MVC2assignment.Controllers
{
    public class Student1Controller : Controller
    {
        
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){RollNo=50,Name="Chirag",Address="delhi"},
                new Student(){RollNo=51,Name="Animesh",Address="Gurgaon"},
                new Student(){RollNo=52,Name="saurav",Address="Hariyana"},
            };
            ViewBag.Students = students;
            return View();
        }
    }
}
