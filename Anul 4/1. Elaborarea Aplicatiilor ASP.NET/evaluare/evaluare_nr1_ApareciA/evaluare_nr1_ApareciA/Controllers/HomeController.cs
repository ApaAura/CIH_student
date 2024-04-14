using evaluare_nr1_ApareciA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

namespace evaluare_nr1_ApareciA.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Note());
        }

        [HttpPost]
        public IActionResult Index(Note note)
        {
            if (!ModelState.IsValid)
            {
                return View(note);
            }
            return RedirectToAction("media",note);
        }

        [HttpGet]
        public IActionResult Media(Note note)
        {
            if (ModelState.IsValid) 
            { 
                return View(note);
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