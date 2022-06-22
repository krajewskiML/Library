using Library.Database.Context;
using Library.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database.Controllers
{
    public class BookRemiderController
    {
        public static void createReminder(Book book, User user)
        {
            BookReminder reminder = new BookReminder()
            { BookId = book.BookId, UserId = user.UserId };
            using(var db = new LibraryContext())
            {
                db.BookReminders.Add(reminder);
                db.SaveChanges();
            }
        }

        public static List<BookReminder> popValidreminders(User user)
        {
            using (var db = new LibraryContext())
            {
                var activeReminders = (from book in db.Books
                                      join rent in db.Rents on book.BookId equals rent.BookId
                                      join reminder in db.BookReminders on book.BookId equals reminder.BookId
                                      where (rent.Returned != null) && (reminder.UserId == user.UserId)
                                      select reminder).ToList();
                var removedDuplicates = activeReminders.GroupBy(br => br.BookReminderId).Select(g => g.First()).ToList();
                db.BookReminders.RemoveRange(removedDuplicates);
                db.SaveChanges();
                return removedDuplicates;
            }
            
        }
    }
}
