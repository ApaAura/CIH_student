using Microsoft.AspNetCore.Mvc;

namespace AppMatrice.Controllers
{
    public class MatriceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GenerateMatrice(int rows, int columns) 
        { 
            if(ModelState.IsValid) 
            { 
                int[,] matrice= GenerateRandomMatrice(rows, columns);
                int maxValue = matrice.Cast<int>().Max();
                int minValue = matrice.Cast<int>().Min(); 
                
                ViewBag.Matrice = matrice;  
                ViewBag.MaxValue = maxValue;    
                ViewBag.MinValue = minValue;

                return View("Matrice");
            }
            return View("Index");
        }

        private int[,] GenerateRandomMatrice(int rows, int columns)
        {
            Random random = new Random();
            int[,] matrice = new int[rows, columns]; 
            for(int i = 0;i< rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrice[i,j] = random.Next(1,100);
                }
            }
            return matrice;
        }
    }
}
