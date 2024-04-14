using app.Models;
using app.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace app.Controllers;

public class HomeController : Controller
{
    private readonly StudentService studentService;
    public HomeController(StudentService StudentService)
    {
        this.studentService = StudentService;
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View("Add");
    }
    [HttpGet]
    public IActionResult Edit(string student)
    {
        if (ModelState.IsValid)
        {
            var std = studentService.GetStudentByID(student);
            return View("Update", std);
        }
        return View("Add");
    }
    [HttpGet]
    public IActionResult StudentList()
    {
        var students = studentService.GetStudents();
        return View(students);
    }
    [HttpPost]
    public IActionResult Update(Student student)
    {
        if (ModelState.IsValid)
        {
            studentService.UpdateStudent(student);
            return RedirectToAction("StudentList");
        }
        return View("Update",student);
    }
    [HttpPost]
    public IActionResult Register(Student student)
    {
        if (ModelState.IsValid)
        {
            studentService.AddStudent(student);
            return RedirectToAction("StudentList");
        }
        return View("Add", student);
    }
    [HttpPost]
    public IActionResult Delete(string id)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        studentService.DeleteStudent(id);
        return RedirectToAction("StudentList");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}