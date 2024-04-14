using BookStore.Models;
using BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {

        private readonly BookService _bookService;
        public HomeController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var book = _bookService.GetAllBooks();
            return View(book);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View("Add");
        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            if (ModelState.IsValid)
            {
                var book = _bookService.GetBookById(id);
                return View("Update", book);
            }
            return View("Add");
        }
        [HttpPost]
        public IActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.UpdateBook(book);
                return RedirectToAction("Index");
            }
            return View("Update", book);
        }
        [HttpPost]
        public IActionResult Register(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.CreateBook(book);
                return RedirectToAction("Index");
            }
            return View("Add", book);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookService.DeleteStudent(id);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult SelectBooks(string selectedCriteria)
        {
            List<Book> filteredBooks;

            switch (selectedCriteria)
            {
                case "bilet9":
                    filteredBooks = _bookService.taskBilet9();
                    break;
                case "all":
                default:
                    filteredBooks = _bookService.GetAllBooks();
                    break;
            }

            return View("Index", filteredBooks);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}