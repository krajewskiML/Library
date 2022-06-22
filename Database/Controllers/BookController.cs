using Library.Database.Context;
using Library.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database.Controllers
{
    public  class BookController
    {
        public static void addBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }

        public static List<Book> getBooks()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.ToList();
            }
        }

        public static void editBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                var bookToEdit = db.Books.Where(b => b.BookId == book.BookId).First();
                bookToEdit.Currency = book.Currency;
                bookToEdit.Price = book.Price;
                bookToEdit.Title = book.Title;
                bookToEdit.Description = book.Description;
                bookToEdit.Category = book.Category;
                bookToEdit.Author = book.Author;
                bookToEdit.Pages = book.Pages;
                db.SaveChanges();
            }
        }

        public static void deleteBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        public static Book getBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                return db.Books.Where((b) => b.BookId == book.BookId).First();
            }
        }

        public static List<Book> getUserCurrentlyRentedBooks(User user)
        {
            var activeRents = RentController.getUsersCurrentRents(user);
            var activeBooksIds = activeRents.Select(b => b.BookId).ToList();
            using (var db = new LibraryContext())
            {
                var books = db.Books.Where(b => activeBooksIds.Contains(b.BookId)).ToList();
                return books;
            }
        }

        public static string getTitle(int bookId)
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.Where(b =>b.BookId == bookId).First();
                return book.Title;
            }
        }
    }
}
