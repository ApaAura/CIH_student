using CarStore.Data;
using CarStore.Models;
using CarStore.Services;
using CarStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace CarStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly CarService _carService;
        private readonly AppDbContext _dbContext;
        public HomeController(CarService carService, AppDbContext context)
        {
            _carService = carService;
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddProducer()
        {
            return View(new Producer());
        }
        [HttpGet]
        public IActionResult AddCar()
        {
            var prods = _carService.GetAllProducers();
            var AddNewCar = new AddNewCarViewModel()
            {
                Producers = prods,
                Car = new Car()
            };
            return View(AddNewCar);
        }
        [HttpPost]
        public IActionResult AddCarPost(AddNewCarViewModel model)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(model.Car);
                return RedirectToAction("Index");//carList for ViewData
            }
            return View("AddCar", model);
        }
        [HttpPost]
        public IActionResult AddProducerPost(Producer prod)
        {
            if (ModelState.IsValid)
            {
                _carService.AddProducer(prod);
                return RedirectToAction("Index");//carList for ViewData
            }
            return View("AddProducer", prod);
        }
        [HttpGet]
        public IActionResult ViewData()
        {
            var DataVM = new ViewDataViewModel()
            {
                Cars = _carService.GetAllCars(),
                Producers = _carService.GetAllProducers()
            };
            return View("ViewData", DataVM);
        }
        [HttpPost]
        public IActionResult DeleteCar(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _carService.DeleteCar(id);
            return RedirectToAction("ViewData");
        }
        [HttpPost]
        public IActionResult DeleteProducer(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _carService.DeleteProducer(id);
            return RedirectToAction("ViewData");
        }
        [HttpPost]
        public IActionResult UpdateCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.UpdateCar(car);
                return RedirectToAction("ViewData");
            }
            return View("UpdateCar", car);
        }
        [HttpPost]
        public IActionResult UpdateProducer(Producer prod)
        {
            if (ModelState.IsValid)
            {
                _carService.UpdateProducer(prod);
                return RedirectToAction("ViewData");
            }
            return View("UpdateProducer", prod);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}