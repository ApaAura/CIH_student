using laborator_3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace laborator_3.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task Dreptunghi()
        {
            string content = @"<form method='post'>
                <label>Lungime:</label><br/>
                <input type='number' name='width'/> <br/>
                <label>Latime:</label><br/>
                <input type='number' name='height'/> <br/>
                <input type='submit' value='Send'/> 
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(content);
        }
        [HttpPost]
        public string Dreptunghi(int width, int height)
        {
            int area=width*height;
            return $"Aria dreptunghiului cu laturile: {width} si {height} este egala cu: {area}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}