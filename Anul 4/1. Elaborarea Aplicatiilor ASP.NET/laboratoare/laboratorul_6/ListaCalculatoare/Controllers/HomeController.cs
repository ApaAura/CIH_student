using ListaCalculatoare.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ListaCalculatoare.Controllers
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
            var produse = ProdusRepsitory.GetProduse();
            return View(produse);
        }
        [HttpPost]
        public IActionResult ListaProduse(string categorie, decimal? pretMin,decimal? pretMax)
        {
            var produse = ProdusRepsitory.GetProduse();
            if (!string.IsNullOrEmpty(categorie))
            {
                produse.Where(p=>p.Categorie==categorie).ToList();
            }
            if (pretMin.HasValue)
            {
                produse.Where(p => p.Pret >= pretMin).ToList();
            }
            if (pretMax.HasValue)
            {
                produse.Where(p => p.Pret <= pretMax).ToList();
            }
            return View("Index", produse);
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