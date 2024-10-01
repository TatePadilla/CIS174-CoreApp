using CIS174_CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174_CoreApp.Controllers
{
    public class StudentController : Controller
    {
        // Creating DB context object to tie in seed data/DB connection.
        private StudentContext context { get; set; }
        public StudentController(StudentContext ctx) => context = ctx;

        // Creating ViewStudents method with accessLevel as a parameter, passed from the URL route parameter.
        [HttpGet]
        public IActionResult ViewStudents(int accessLevel)
        {
            
            // Validate access level.
            if (accessLevel < 1 || accessLevel > 10)
            {
                return BadRequest("Access level must be between 1 and 10.");
            }

            // Storing accessLevel passed into ViewStudents() method in the ViewData key named "AccessLevel" (passed to 'ViewStudents' view).
            ViewData["AccessLevel"] = accessLevel;

            // Creating list of students using the context object.
            var students = context.Students.ToList();

            // Storing students seed data from StudentContext in the ViewData key named "Students" (passed to 'ViewStudents' view).
            ViewData["Students"] = students;

            return View();
        }
    }
      
}
