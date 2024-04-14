using BookStore.Data;
using BookStore.Models;
using System;

namespace BookStore.Services
{
    public class BookService
    {
        private ApplicationDbContext _appDbContext;
        public BookService(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void CreateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _appDbContext.Books.ToList();
        }

        public Book GetBookById(Guid id)
        {
            return _appDbContext.Books.FirstOrDefault(s => s.ID == id)!;
        }
        public void UpdateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            _appDbContext.Books.Update(book);
            _appDbContext.SaveChanges();
        }

        public void DeleteStudent(Guid id)
        {
            var book = _appDbContext.Books.FirstOrDefault(s => s.ID == id);
            if (book != null)
            {
                _appDbContext.Books.Remove(book);
                _appDbContext.SaveChanges();
            }
        }
        public List<Book> taskBilet9()
        {
            List<char> vowels = new List<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            var filteredBooks = _appDbContext.Books.Where(book => vowels.Contains(book.Editor.FirstOrDefault())&& vowels.Contains(book.Editor.LastOrDefault())) .ToList();
            return filteredBooks;
        }


    }
}
