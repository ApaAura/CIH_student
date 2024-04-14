using Microsoft.AspNetCore.Mvc;
using Sarcina1.Models;
using System.Diagnostics;

namespace Sarcina1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public string Index(string username)
        {
            return $"/{username}";
        }
    }
}