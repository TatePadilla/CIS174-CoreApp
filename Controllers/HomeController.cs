using CIS174_CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CIS174_CoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Assignments()
        {
            return View();
        }
    }
}
