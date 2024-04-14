using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
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
            var genderList = new List<SelectListItem>
            {
                new SelectListItem { Value = "Male", Text = "Male" },
                new SelectListItem { Value = "Female", Text = "Female" },
            };

            ViewBag.GenderList = genderList;
            return View("Add");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var genderList = new List<SelectListItem>
            {
                new SelectListItem { Value = "Male", Text = "Male" },
                new SelectListItem { Value = "Female", Text = "Female" },
            };

            ViewBag.GenderList = genderList;
            if (ModelState.IsValid)
            {
                var student = _studentService.GetStudentById(id);
                ViewBag.SelectedGender = student.Sex;
                return View("Update", student);
            }
            return View("Add");
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
        [HttpPost]
        public IActionResult SelectStudents(string selectedCriteria)
        {
            List<Student> filteredStudents;

            switch (selectedCriteria)
            {
                case "failed":
                    filteredStudents = _studentService.Restantieri();
                    break;
                case "gpa":
                    filteredStudents = _studentService.Bursieri();
                    break;
                case "female":
                    filteredStudents = _studentService.Fete();
                    break;
                case "male_high_grade":
                    filteredStudents = _studentService.BaietiBursieri();
                    break;
                case "age":
                    filteredStudents = _studentService.Varsta();
                    break;
                case "all":
                default:
                    filteredStudents = _studentService.GetAllStudents();
                    break;
            }

            return View("Index", filteredStudents);
        }
        [HttpPost]
        public IActionResult FilterStudents(string selectedCriteria)
        {
            List<Student> filteredStudents;

            switch (selectedCriteria)
            {
                case "alp":
                    filteredStudents = _studentService.AZ();
                    break;
                case "alpBack":
                    filteredStudents = _studentService.ZA();
                    break;
                case "desc":
                    filteredStudents = _studentService.BigestGrade();
                    break;
                case "cresc":
                    filteredStudents = _studentService.BaietiBursieri();
                    break;
                default:
                    filteredStudents = _studentService.SmallestGrade();
                    break;
            }

            return View("Index", filteredStudents);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}