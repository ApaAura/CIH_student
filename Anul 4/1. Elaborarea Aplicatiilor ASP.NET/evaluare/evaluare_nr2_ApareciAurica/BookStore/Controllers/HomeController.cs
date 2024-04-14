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
            var books= _bookService.GetAllBooks();
            return View(books);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View("Add");
        }
        [HttpGet]
        public IActionResult Edit(Guid bookId)
        {
            if (ModelState.IsValid)
            {
                var book = _bookService.GetBook(bookId);
                return View("Update", book);
            }
            return View("Add");
        }
        [HttpGet]
        public IActionResult BookList()
        {
            var books = _bookService.GetAllBooks();
            return View(books);
        }
        [HttpPost]
        public IActionResult Update(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.UpdateBook(book);
                return RedirectToAction("BookList");
            }
            return View("Update", book);
        }
        [HttpPost]
        public IActionResult Register(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookService.AddBook(book);
                return RedirectToAction("BookList");
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
            _bookService.DeleteBook(id);
            return RedirectToAction("BookList");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}