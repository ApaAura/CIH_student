using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;

namespace BookStore.Services;

public class BookService
{
    private AppDBContext _appDBContext;
    private readonly string wwwRootPath;
    public BookService(AppDBContext appDBContext, IWebHostEnvironment hostEnvironment)
    {
        _appDBContext = appDBContext;
        wwwRootPath = hostEnvironment.WebRootPath;
    }
    public void AddBook(Book ToAdd)
    {
        string fileName = Path.GetFileNameWithoutExtension(ToAdd.FormFile.FileName);
        string extension = Path.GetExtension(ToAdd.FormFile.FileName);
        ToAdd.Path = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
        string path = Path.Combine(wwwRootPath + "/Images/", fileName);
        using (var fileStream = new FileStream(path, FileMode.Create))
        {
            ToAdd.FormFile.CopyTo(fileStream);
        }
        _appDBContext.Books.Add(ToAdd);
        _appDBContext.SaveChanges();
    }
    public List<Book> GetAllBooks()
    {
        return _appDBContext.Books.ToList();
    }
    public Book GetBook(Guid id)
    {
        var book = _appDBContext.Books.Where(x => x.ID == id).FirstOrDefault();
        return book!;
    }
    internal void DeleteBook(Guid id)
    {
        var book = _appDBContext.Books.Where(x => x.ID == id).FirstOrDefault()!;
        if (book == null)
            throw new Exception("Book was not found");
        var filePath = Path.Combine(wwwRootPath + "/Images/", book.Path);

        if (System.IO.File.Exists(filePath))
            System.IO.File.Delete(filePath);

        _appDBContext.Books.Remove(book);
        _appDBContext.SaveChanges();
    }
    internal void UpdateBook(Book book)
    {
        var bookToUpdate = _appDBContext.Books.FirstOrDefault(x => x.ID == book.ID);
        if (bookToUpdate == null)
            throw new Exception("Book was not found");
        bookToUpdate.Title= book.Title;
        bookToUpdate.Author= book.Author;
        bookToUpdate.Editura= book.Editura;
        bookToUpdate.Price=book.Price;
        bookToUpdate.Description= book.Description;
        _appDBContext.SaveChanges();
    }
}