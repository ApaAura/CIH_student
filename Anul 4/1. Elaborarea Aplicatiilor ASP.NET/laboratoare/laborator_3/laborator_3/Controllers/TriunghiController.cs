using Microsoft.AspNetCore.Mvc;


namespace laborator_3.Controllers
{
    public class TriunghiController : Controller
    {
        [HttpGet]
        public async Task Triunghi()
        {
            string content = @"<form method='post'>
                <label>Latura a:</label><br/>
                <input type='number' name='x'/> <br/>
                <label>Latura b:</label><br/>
                <input type='number' name='y'/> <br/>
                <label>Latura c:</label><br/>
                <input type='number' name='z'/> <br/>
                <input type='submit' value='Send'/>
            </form>";
            Response.ContentType = "text/html;charset=utf-8";
            await Response.WriteAsync(content);
        }
        [HttpPost]
        public string Triunghi(int x, int y, int z)
        {
            if ((x+y>z)&&(x+z>y)&&(z+y>x)) 
            {
                int perimetru = x + y + z;
                double s = perimetru / 2.0;
                double aria = Math.Sqrt(s * (s - x) * (s - y) * (s - z)); ;
                return $"Perimetrul triunghiului cu laturile: {x}, {y}, {z} este {perimetru}.\nAria: {aria}.";
            }
            else
            {
                return "Laturile nu formeaza un triunghi!";
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
