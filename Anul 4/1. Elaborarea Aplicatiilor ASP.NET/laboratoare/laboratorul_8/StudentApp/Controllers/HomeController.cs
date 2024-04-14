using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;
using StudentApp.Services;
using System.Diagnostics;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentService _studentService;
        public HomeController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
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
                var student = _studentService.GetStudentById(id);
                return View("Update", student);
            }
            return View("Add");
        }
        [HttpGet]
        public IActionResult Category()
        {
            var bursieri = _studentService.Bursieri();
            var restantieri = _studentService.Restantieri();
            return View(new Tuple<List<Student>, List<Student>>(bursieri,restantieri));
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.UpdateStudent(student);
                return RedirectToAction("Index");
            }
            return View("Update", student);
        }
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.CreateStudent(student);
                return RedirectToAction("Index");
            }
            return View("Add", student);
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}