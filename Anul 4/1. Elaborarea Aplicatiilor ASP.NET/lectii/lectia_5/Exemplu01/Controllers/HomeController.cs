using Microsoft.AspNetCore.Mvc;

namespace Exemplu01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
