using Library.Constants;
using Library.Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms.AdminPanel
{
    public partial class BookCreatorForm : Form
    {
        private int? bookId;
        public Book returnBook { get; set; }
        public BookCreatorForm()
        {
            // this constructor is responsible for creating new book
            InitializeComponent();
            fillPickers();
        }

        public BookCreatorForm(Book book)
        {
            // this constructor is responsible for editing book
            InitializeComponent();
            bookId = book.BookId;
            fillPickers();
            fillKnownInfo(book);
        }

        public BookCreatorForm(Book book, bool noEdit)
        {
            // this constructor is responsible for viewing details book
            InitializeComponent();
            bookId = book.BookId;
            fillPickers();
            fillKnownInfo(book);
            disableEditing();
        }

        private void disableEditing()
        {
            TitleTextBox.Enabled = false;
            AuthorTextBox.Enabled = false;
            CurrencyComboBox.Enabled = false;
            CategoryComboBox.Enabled = false;
            PriceNumericUpDown.Enabled = false;
            DescriptionTextBox.Enabled = false;
            PagesNUmericUpdDown.Enabled = false;

        }

        private void fillPickers()
        {
            fillBookCategories();
            fillCurrencies();
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

        private void fillKnownInfo(Book book)
        {
            TitleTextBox.Text = book.Title;
            AuthorTextBox.Text = book.Author;
            DescriptionTextBox.Text = book.Description;
            CategoryComboBox.Text = book.Category;
            PriceNumericUpDown.Value = (decimal)book.Price;
            PagesNUmericUpdDown.Value = book.Pages;
            CurrencyComboBox.Text = book.Currency;
        }

        private bool checkIfValuesAreCorrect()
        {
            if(
                TitleTextBox.Text.Trim() != "" &&
                AuthorTextBox.Text.Trim() != "" &&
                DescriptionTextBox.Text.Trim() != "" &&
                CategoryComboBox.Text.Trim() != "" &&
                CurrencyComboBox.Text.Trim() != "" &&
                PriceNumericUpDown.Text.Trim() != "" &&
                PagesNUmericUpdDown.Text.Trim() != ""
                )
            {
                return true;
            }
            return false;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!checkIfValuesAreCorrect())
            {
                MessageBox.Show(
                   "Fill all the necessary information about the book!",
                   "Missing data",
                   MessageBoxButtons.OK
                   );
                return;
            }
            else
            {
                if(bookId != null)
                {
                    this.returnBook = new Book() { 
                        BookId = (int)bookId,
                        Author = AuthorTextBox.Text,
                        Title = TitleTextBox.Text,
                        Description = DescriptionTextBox.Text,
                        Category = CategoryComboBox.Text,
                        Price = (double)PriceNumericUpDown.Value,
                        Pages = (int)PagesNUmericUpdDown.Value,
                        Currency = CurrencyComboBox.Text,
                    };
                }
                else
                {
                    this.returnBook = new Book()
                    {
                        Author = AuthorTextBox.Text.Trim(),
                        Title = TitleTextBox.Text.Trim(),
                        Description = DescriptionTextBox.Text.Trim(),
                        Category = CategoryComboBox.Text.Trim(),
                        Price = (double)PriceNumericUpDown.Value,
                        Pages = (int)PagesNUmericUpdDown.Value,
                        Currency = CurrencyComboBox.Text.Trim(),
                    };
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
