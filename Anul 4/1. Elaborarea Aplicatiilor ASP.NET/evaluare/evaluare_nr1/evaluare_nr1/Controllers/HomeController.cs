using evaluare_nr1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace evaluare_nr1.Controllers
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
        public async Task Media()
        {
            string content = @" <div class='container'>
                <h1 class='text-center'>Calculeaza-ti media de concurs intr-un<br> mod simplu si rapid</h1>
                <p style='color: #5fbfcd;'>Notele anuale la 4 discipline de profil:</p>
                <form method='post'>
                    <div class='row'>
                        <div class='col-lg-3'>
                            <label>Limba de instruire: </label>
                            <input class='form-control' type='number' name='instruire'>
                            </div>
                        <div class='col-lg-3'>
                            <label>Limba straina(en/fr): </label>
                            <input class='form-control' type='number' name='straina'>
                        </div>
                        <div class='col-lg-3'>
                            <label>Matematica: </label>
                            <input class='form-control' type='number' name='matematica'>
                        </div>
                        <div class='col-lg-3'>
                            <label>Informatica/Istoria: </label>
                            <input class='form-control' type='number' name='profil'>
                        </div>
                    </div>
                </form>
                <br>
                <p style='color: #5fbfcd;'>Media notelor de la examenele de absolvire:</p>
                <form method='post'>
                    <div class='row;>
                        <div class='col-lg-3'><label>MNEA(ex:9.33 nu 9,33)</label></div>
                        <div class='col-lg-9'></div>
                    </div>
                    <div class='d-flex justify-content-between'>
                        <div class='col-lg-3'><input class='form-control' type='number' name='MNEA'></div>
                        <div class='col-lg-3'><input class='btn btn-danger' type='submit' value='Calculeaza'></div>
                    </div>
                </form>
            </div>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(content);
        }
        [HttpPost]
        public string Media(double instruire, double straina, double matematica, double profil, double MNEA)
        {
            double MNDP = (instruire + straina + matematica + profil)/4 ;
            double MC = 0.6 * MNDP + 0.4 * MNEA;
            return $"Media dumneavoastra este: {MC}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}