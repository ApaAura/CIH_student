using Employee.Data;
using Employee.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Employee.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _employeeService;
        public HomeController(AppDbContext empService)
        {
            _employeeService = empService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var emp = _employeeService.Employees.ToList();
            var maxSal = _employeeService.Employees.Max(x => x.Salariu);
            var emps = _employeeService.Employees.Where(x => x.Salariu == maxSal).ToList();

            return View(new Tuple<List<Employee.Models.Employee>, List<Employee.Models.Employee>>(emp, emps));
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View("Add");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                var emp = _employeeService.Employees.FirstOrDefault(s => s.ID == id)!;
                return View("Update", emp);
            }
            return View("Add");
        }
        [HttpPost]
        public IActionResult Update(Employee.Models.Employee emp)
        {
            if (ModelState.IsValid)
            {
                if (emp == null)
                {
                    throw new ArgumentNullException(nameof(emp));
                }
                _employeeService.Employees.Update(emp);
                _employeeService.SaveChanges();


                return RedirectToAction("Index");
            }
            return View("Update", emp);
        }
        [HttpPost]
        public IActionResult Register(Employee.Models.Employee emp)
        {
            if (ModelState.IsValid)
            {

                if (emp == null)
                {
                    throw new ArgumentNullException(nameof(emp));
                }
                _employeeService.Employees.Add(emp);
                _employeeService.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Add", emp);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var emp = _employeeService.Employees.FirstOrDefault(s => s.ID == id);
            if (emp != null)
            {
                _employeeService.Employees.Remove(emp);
                _employeeService.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}