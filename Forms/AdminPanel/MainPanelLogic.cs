using Library.Constants;
using Library.Database.Controllers;
using Library.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms.AdminPanel
{
    public class MainPanelLogic
    {
        public User currentUser;
        public MainPanelLogic(User user)
        {
            currentUser = user;
            checkForReminders();
            checkForEndingRents();
        }
        public static void rentHistory(User user)
        {
            var rentHistory = RentController.getUsersRents(user);
            RentHistoryForm rentHistoryForm = new RentHistoryForm(user, rentHistory);
            rentHistoryForm.ShowDialog();
        }

        private void checkForReminders()
        {
            var usersReminders = BookRemiderController.popValidreminders(currentUser);
            foreach(var reminder in usersReminders)
            {
                MessageBox.Show(
                     reminder.ToString(),
                     "Book available!",
                     MessageBoxButtons.OK
                   );
            }
        }

        private void checkForEndingRents()
        {
            var endingRents = RentController.getRentsThatNeedToBefinished(currentUser);
            foreach (var reminder in endingRents)
            {
                var titleOfBookToReturn = BookController.getTitle(reminder.BookId);
                MessageBox.Show(
                     $"You need to return {titleOfBookToReturn}!",
                     "Rent ending!",
                     MessageBoxButtons.OK
                   );
            }
        }

        private void checkForLateReturn()
        {

        }

        public void rentHistory()
        {
            rentHistory(currentUser);
        }

        public static void addBook()
        {
            BookCreatorForm bookCreatorForm = new BookCreatorForm();
            var result = bookCreatorForm.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                var newBook = bookCreatorForm.returnBook;
                BookController.addBook(newBook);
            }
        }
        public static void editBook(Book book)
        {
            // as the currency of the book might be changed in the viewer we need to fetch original book
            book = BookController.getBook(book);
            BookCreatorForm bookCreatorForm = new BookCreatorForm(book);
            var result = bookCreatorForm.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var newBook = bookCreatorForm.returnBook;
                BookController.editBook(newBook);
            }
        }

        public static void deleteBook(Book book)
        {
            BookController.deleteBook(book);
        }


        public static List<Book> getBooks(Filter filter)
        {

            var allBooks = BookController.getBooks();
            string currency = filter.currency;
            string title = filter.title;
            string category = filter.category;
            string author = filter.author;
            int? pagesMin = filter.pagesMin;
            int? pagesMax = filter.pagesMax;
            int? priceMin = filter.priceMin;
            int? priceMax = filter.priceMax;
            bool viewPriceInPLN = filter.viewPriceInPLN;
            List< string > categoriesExcluded = filter.categoriesExcluded;
            if (currency != null)
            {
                allBooks = allBooks.Where(b => b.Currency == currency).ToList();
            }
            if (title != null)
            {
                allBooks = allBooks.Where(b => b.Title == title).ToList();
            }
            if (category != null)
            {
                allBooks = allBooks.Where(b => b.Category == category).ToList();
            }
            if (author != null)
            {
                allBooks = allBooks.Where(b => b.Author == author).ToList();
            }
            if (pagesMin != null)
            {
                allBooks = allBooks.Where(b => b.Pages > pagesMin).ToList();
            }
            if (pagesMax != null)
            {
                allBooks = allBooks.Where(b => b.Pages < pagesMax).ToList();
            }
            if (priceMin != null)
            {
                allBooks = allBooks.Where(b => b.Price > priceMin).ToList();
            }
            if (priceMax != null)
            {
                allBooks = allBooks.Where(b => b.Price < priceMax).ToList();
            }
            if (categoriesExcluded != null)
            {
                allBooks = allBooks.Where(b => !categoriesExcluded.Contains(b.Category)).ToList();
            }
            if (viewPriceInPLN)
            {
                foreach(var book in allBooks)
                {
                    book.Price = Currencies.convertPrice(book.Currency, Currencies.PLN, book.Price);
                    book.Currency = Currencies.PLN;
                }
            }
            return allBooks;
        }

        public bool rentBook(Book book)
        {
            // check if book is rented
            if (RentController.isBookRented(book))
            {
                //check if u already rented this book
                if(RentController.isBookRentedByUser(currentUser, book))
                {
                    MessageBox.Show(
                      $"You have this book currently rented!",
                      "Too many books rented",
                      MessageBoxButtons.OK
                    );
                    return false;
                }

                //propose to create a reminder if the book is back
                DialogResult dialogResult = MessageBox.Show(
                    "Book is already rented. Do you want to receive a notification when this book will be available?",
                    "Book not available",
                    MessageBoxButtons.YesNo
                );
                if (dialogResult == DialogResult.Yes)
                {
                    // create a notification
                    createRemider(book);
                }
                
                return false;
            }
            // check if user has les then 3 boooks rented
            if (RentController.getUsersCurrentRents(currentUser).Count() == RentConstants.MAX_BOOKS_RENTED)
            {
                MessageBox.Show(
                  $"You have already rented {RentConstants.MAX_BOOKS_RENTED} books. Return any book to be able to rent this one",
                  "Too many books rented",
                  MessageBoxButtons.OK
                );
                return false;
            }
            else
            {
                //rent a book
                RentController.rentBook(currentUser, book);
                return true;
            }
        }

        public List<Book> getRentedBooks()
        {
            return BookController.getUserCurrentlyRentedBooks(currentUser);
        }

        public void returnBook(Book book)
        {
            RentController.returnBook(book, currentUser);
        }

        public void prolongRent(Book book)
        {
            RentController.prolongRent(book, currentUser);
        }

        internal static void viewBook(Book selectedBook)
        {
            BookCreatorForm viewForm = new BookCreatorForm(selectedBook, true);
            viewForm.ShowDialog();
        }

        private void createRemider(Book book)
        {
            BookRemiderController.createReminder(book, currentUser);
        }
    }
}
