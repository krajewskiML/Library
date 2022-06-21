using Library.Database.Context;
using Library.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database.Controllers
{
    public class RentController
    {
        public static List<Rent> getUsersRents(User user)
        {
            using (var db = new LibraryContext())
            {
                var rents = db.Rents.Where(r => r.UserId == user.UserId).OrderBy(r => r.Rented).ToList();
                return rents;
            }
        }

        public static List<Rent> getUsersCurrentRents(User user)
        {
            using (var db = new LibraryContext())
            {
                var rents = db.Rents.Where(r => r.UserId == user.UserId && r.Returned == null).ToList();
                return rents;
            }
        }

        public static bool isBookRented(Book book)
        {
            using (var db = new LibraryContext())
            {
                var rents = db.Rents.Where(r => r.BookId == book.BookId && r.Returned == null).Count();
                return rents > 0;
            }
        }

        public static bool isBookRentedByUser(User user, Book book)
        {
            using (var db = new LibraryContext())
            {
                var rents = db.Rents.Where(r => r.BookId == book.BookId && r.UserId == user.UserId && r.Returned == null).Count();
                return rents > 0;
            }
        }

        public static void rentBook(User user, Book book)
        {
            using (var db = new LibraryContext())
            {
                Rent rent = new Rent() { BookId = book.BookId, UserId = user.UserId, Rented = DateTime.Now, Returned = null };
                db.Rents.Add(rent);
                db.SaveChanges();
            }
        }

        public static void returnBook(Book book, User user)
        {
            using (var db = new LibraryContext())
            {
                Rent rent = db.Rents.Where(r => r.BookId == book.BookId && r.UserId == user.UserId && r.Returned == null).First();
                rent.Returned = DateTime.Now;
                db.SaveChanges();
            }
        }

        public static void prolongRent(Book book, User user)
        {
            using (var db = new LibraryContext())
            {
                Rent rent = db.Rents.Where(r => r.BookId == book.BookId && r.UserId == user.UserId && r.Returned == null).First();
                rent.Rented = DateTime.Now;
                db.SaveChanges();
            }
        }
    }
}
