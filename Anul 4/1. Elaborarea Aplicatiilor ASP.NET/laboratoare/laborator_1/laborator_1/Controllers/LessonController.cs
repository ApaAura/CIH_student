using laborator_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace laborator_1.Controllers
{
    public class LessonController : Controller
    {
        private List<Lesson> lessons = new List<Lesson>
        {
            new Lesson
            {
                Id = 1,
                CourseName = "PC",
                Instructor="Profesor X",
                Day =DayOfWeek.Monday,
                StartTime=new TimeSpan(9,0,0),
                EndTime=new TimeSpan(10,30,0)
            },
            new Lesson
            {
                Id = 1,
                CourseName = "PC",
                Instructor="Profesor X",
                Day =DayOfWeek.Monday,
                StartTime=new TimeSpan(9,0,0),
                EndTime=new TimeSpan(10,30,0)
            },
            new Lesson
            {
                Id = 1,
                CourseName = "PC",
                Instructor="Profesor X",
                Day =DayOfWeek.Monday,
                StartTime=new TimeSpan(9,0,0),
                EndTime=new TimeSpan(10,30,0)
            },
            new Lesson
            {
                Id = 1,
                CourseName = "PC",
                Instructor="Profesor X",
                Day =DayOfWeek.Monday,
                StartTime=new TimeSpan(9,0,0),
                EndTime=new TimeSpan(10,30,0)
            }
        };
        public IActionResult Index()
        {
            return View(lessons);
        }
    }
}
