using laborator_3._2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laborator_3._2.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Sir());
        }
        [HttpPost]
        public IActionResult Index(Sir sir)
        {
            if (!ModelState.IsValid)
            {
                return View(sir);
            }
            return RedirectToAction("media", sir);
        }
        [HttpGet]
        public IActionResult Media(Sir sir)
        {
            if (ModelState.IsValid)
            {
                return View(sir);
            }
            return RedirectToAction("error");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}