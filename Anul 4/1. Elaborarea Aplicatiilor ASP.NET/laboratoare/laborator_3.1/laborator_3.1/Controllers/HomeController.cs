using laborator_3._1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laborator_3._1.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Paralelipiped());
        }
        [HttpPost]
        public IActionResult Index(Paralelipiped paralelipiped)
        {
            if (!ModelState.IsValid)
            {
                return View(paralelipiped);
            }
            return RedirectToAction("media", paralelipiped);
        }
        [HttpGet]
        public IActionResult Media(Paralelipiped paralelipiped)
        {
            if (ModelState.IsValid)
            {
                return View(paralelipiped);
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