using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Constants;
using Library.Database.Controllers;
using Library.Database.Models;
using Library.Utilities;

namespace Library.Forms.AdminPanel
{
    public partial class MainPanelForm : Form
    {
        // last clicked book
        private Book selectedBook { get; set; }
        private Filter filter { get; set; }

        private MainPanelLogic mainPanelLogic { get; set; }
        public MainPanelForm(User user)
        {
            mainPanelLogic = new MainPanelLogic(user);
            InitializeComponent();
            initializeUsersComponentes();
            setNewFilter();
            fillBooks();
            fillBookCategories();
            fillCurrencies();
            fillToHideCategories();
        }

        private void initializeUsersComponentes()
        {
            // guest
            if (mainPanelLogic.currentUser is GuestUser)
            {
                // hide controls which are nota available in guest mode
                hideControlsToGuest();
                return;
            }
            // admin
            if (mainPanelLogic.currentUser.IsAdmin)
            {
                RentBookButton.Visible = false;
                BookDetailsButton.Visible = false;
                RentedBooksListBox.Visible = false;
                ProlongRentButton.Visible = false;
                ReturnBookButton.Visible = false;
                fillUsers();
            }
            // normal user
            else
            {

                AddBookButton.Visible = false;
                DeleteBookButton.Visible = false;
                EditBookButton.Visible = false;
                UsersLabel.Text = "Currently rented books";
                UsersListBox.Visible = false;
                fillRentedBooks();
            }
        }

        private void fillRentedBooks()
        {
            var rentedBooks = mainPanelLogic.getRentedBooks();
            RentedBooksListBox.DataSource = rentedBooks;
        }

        private void hideControlsToGuest()
        {
            AddBookButton.Visible = false;
            RentBookButton.Visible = false;
            DeleteBookButton.Visible = false;
            BookDetailsButton.Visible = false;
            EditBookButton.Visible = false;
            UsersLabel.Visible = false;
            UsersListBox.Visible = false;
            RentedBooksListBox.Visible = false;   
            ViewHistoryButton.Visible = false;
            ProlongRentButton.Visible = false;
            ReturnBookButton.Visible = false;
        }

        private void fillToHideCategories()
        {
            ToHideCheckedList.Items.Clear();
            ToHideCheckedList.Items.AddRange(BookCategories.getBookCategories().ToArray());
        }

        private void fillBookCategories()
        {
            CategoryComboBox.Items.Clear();
            CategoryComboBox.Items.AddRange(BookCategories.getBookCategories().ToArray());
            CategoryComboBox.SelectedIndex = 0;
        }

        private void fillCurrencies()
        {
            CurrencyComboBox.Items.Clear();
            CurrencyComboBox.Items.AddRange(Currencies.getCurrencies().ToArray());
            CurrencyComboBox.SelectedIndex = 0;
        }

        private void fillUsers()
        {
            UsersListBox.Items.Clear();
            UsersListBox.SelectedIndex = -1;
            var users = UserController.getNonAdminUsers();
            UsersListBox.DataSource = users;
            UsersListBox.DisplayMember = "username";
        }

        private void fillBooks()
        {
            var books = MainPanelLogic.getBooks(filter);
            BookGridView.DataSource = books;
            BookGridView.ReadOnly = true;
            BookGridView.Columns["BookId"].Visible = false;
            BookGridView.Columns["Description"].Visible = false;
            selectedBook = null;
        }

        private void ViewHistoryButton_Click(object sender, EventArgs e)
        {  
            if (mainPanelLogic.currentUser.IsAdmin)
            {
                // if admin is the current user the user must be picked
                if (UsersListBox.SelectedItem == null)
                {
                    MessageBox.Show(
                      $"You need to pick the user first",
                      "Book not picked",
                      MessageBoxButtons.OK
                    );
                    return;
                }
                var selectedUser = (User)UsersListBox.SelectedItem;
                MainPanelLogic.rentHistory(selectedUser);
            }
            else
            {
                // if the user is not admin then we show his history
                mainPanelLogic.rentHistory();
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            MainPanelLogic.addBook();
            fillBooks();
        }

        private void EditBookButton_Click(object sender, EventArgs e)
        {
            if (selectedBook != null)
            {
                MainPanelLogic.editBook(selectedBook);
                fillBooks();
            }
            else
            {
                MessageBox.Show(
                  $"You need to pick book first",
                  "Book not picked",
                  MessageBoxButtons.OK
                  );
            }
        }

        private void DeleteBookButton_Click(object sender, EventArgs e)
        {
            if (selectedBook != null)
            {
                MainPanelLogic.deleteBook(selectedBook);
                fillBooks();
            }
            else
            {
                MessageBox.Show(
                  $"You need to pick book first",
                  "Book not picked",
                  MessageBoxButtons.OK
                );
            }
        }

        private void BookGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedBook = BookGridView.SelectedRows[0].DataBoundItem as Book;
        }

        private void setNewFilter()
        {
            //currency
            string currency = null;
            if (CurrencyCheckBox.Checked)
            {
                currency = CurrencyComboBox.SelectedItem as string;
            }
            //author
            string author = null;
            if (AuthorCheckBox.Checked)
            {
                author = AuthorTextBox.Text;
            }
            //title
            string title = null;
            if (TitleCheckbox.Checked)
            {
                title = TitleTextBox.Text;
            }
            //category
            string category = null;
            if (CategoryCheckBox.Checked)
            {
                category = CategoryComboBox.SelectedItem as string;
            }
            //pagesMin
            int? pagesMin = null;
            if (MinimalPagesCheckBox.Checked)
            {
                pagesMin = (int?)MinimalPagesNumericUpdown.Value;
            }
            //pagesMax
            int? pagesMax = null;
            if (MaximalPagesCheckBox.Checked)
            {
                pagesMax = (int?)MaximalPagesNumericUpdown.Value;
            }
            //priceMin
            int? priceMin = null;
            if (MinimalPriceCheckBox.Checked)
            {
                priceMin = (int?)MinimalPriceNumericalUpDown.Value;
            }
            //priceMax
            int? priceMax = null;
            if (MaximalPriceCheckBox.Checked)
            {
                priceMax = (int?)MaximalPriceNumericUpDown.Value;
            }
            //PLN view
            bool convertToPLN = ViewPriceInPLNCheckBox.Checked;
            // excluded topics
            List<string> exludedCategories = ToHideCheckedList.CheckedItems.Cast<string>().ToList();
            this.filter = new Filter(currency, title, category, author, pagesMin, pagesMax, priceMin, priceMax, convertToPLN, exludedCategories);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            setNewFilter();
            fillBooks();
        }

        private void RentBookButton_Click(object sender, EventArgs e)
        {
            if(selectedBook != null)
            {
                bool rented = mainPanelLogic.rentBook(selectedBook);
                if (rented)
                {
                    fillRentedBooks();
                }
            }
            else
            {
                MessageBox.Show(
                  $"You need to pick book first",
                  "Book not picked",
                  MessageBoxButtons.OK
                );
            }
        }

        private void ReturnBookButton_Click(object sender, EventArgs e)
        {
            if(RentedBooksListBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    $"You need to pick book first",
                    "Book not picked",
                    MessageBoxButtons.OK
                );
                return;
            }
            Book pickedBook = RentedBooksListBox.SelectedItem as Book;
            mainPanelLogic.returnBook(pickedBook);
            fillRentedBooks();
            MessageBox.Show(
                $"You have succesfully returned {pickedBook.Title} by {pickedBook.Author}",
                "Book not picked",
                MessageBoxButtons.OK
            );
            return;
        }

        private void ProlongRentButton_Click(object sender, EventArgs e)
        {
            if (RentedBooksListBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    $"You need to pick book first",
                    "Book not picked",
                    MessageBoxButtons.OK
                );
                return;
            }
            Book pickedBook = RentedBooksListBox.SelectedItem as Book;
            mainPanelLogic.prolongRent(pickedBook);
            fillRentedBooks();
            MessageBox.Show(
                $"You have succesfully prolonged rent of {pickedBook.Title} by {pickedBook.Author}",
                "Rent prolonged",
                MessageBoxButtons.OK
            );
            return;
        }

        private void BookDetailsButton_Click(object sender, EventArgs e)
        {
            if (selectedBook != null)
            {
                MainPanelLogic.viewBook(selectedBook);
            }
            else
            {
                MessageBox.Show(
                  $"You need to pick book first",
                  "Book not picked",
                  MessageBoxButtons.OK
                );
            }
        }
    }
}
