using DotNetWebAPI_InMemoryDatabase.Data;
using DotNetWebAPI_InMemoryDatabase.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWebAPI_InMemoryDatabase.Services
{
    public class BookServices : IBooks
    {
        private readonly BookContext _context;


        public BookServices(BookContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {

            _context.Books.Add(book);
            _context.SaveChanges();

        }

        public void DeleteBook(int bookid)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == bookid);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            IEnumerable<Book> books = _context.Books;
            if (books == null)
            {
                return null;
            }
            return books;
        }

        public Book GetBook(int bookid)
        {
            Book book = _context.Books.FirstOrDefault(book => book.Id == bookid);
            if (book != null)
            {
                return book;
            }
            return null;
        }

        public Book UpdateBook(int bookid, Book book)
        {
            var bookDB = GetBook(bookid);
            if (bookDB == null)
            {
                return null;
            }
            bookDB.Title = book.Title;
            bookDB.Price = book.Price;
            bookDB.Description = book.Description;
            bookDB.Author = book.Author;
            var entityEntry = _context.Update(bookDB);
            _context.SaveChanges(true);
            return entityEntry.Entity;
        }
    }
}
