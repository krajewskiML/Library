namespace Library.Forms.AdminPanel
{
    partial class MainPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersLabel = new System.Windows.Forms.Label();
            this.UsersListBox = new System.Windows.Forms.ListBox();
            this.ViewHistoryButton = new System.Windows.Forms.Button();
            this.BooksLabel = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.DeleteBookButton = new System.Windows.Forms.Button();
            this.EditBookButton = new System.Windows.Forms.Button();
            this.ToHideCheckedList = new System.Windows.Forms.CheckedListBox();
            this.exlcudeLabel = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.BookGridView = new System.Windows.Forms.DataGridView();
            this.MinimalPriceNumericalUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaximalPriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinPriceLabel = new System.Windows.Forms.Label();
            this.MaximalPriceLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MaximalPagesLabel = new System.Windows.Forms.Label();
            this.MinimalPagesLabel = new System.Windows.Forms.Label();
            this.MaximalPagesNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.MinimalPagesNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CurrencyCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimalPriceCheckBox = new System.Windows.Forms.CheckBox();
            this.MaximalPriceCheckBox = new System.Windows.Forms.CheckBox();
            this.AuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.TitleCheckbox = new System.Windows.Forms.CheckBox();
            this.CategoryCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimalPagesCheckBox = new System.Windows.Forms.CheckBox();
            this.MaximalPagesCheckBox = new System.Windows.Forms.CheckBox();
            this.FilterButton = new System.Windows.Forms.Button();
            this.ViewPriceInPLNCheckBox = new System.Windows.Forms.CheckBox();
            this.ViewCurrencyLabel = new System.Windows.Forms.Label();
            this.ReturnBookButton = new System.Windows.Forms.Button();
            this.ProlongRentButton = new System.Windows.Forms.Button();
            this.RentedBooksListBox = new System.Windows.Forms.ListBox();
            this.RentBookButton = new System.Windows.Forms.Button();
            this.BookDetailsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalPriceNumericalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximalPriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximalPagesNumericUpdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalPagesNumericUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(508, 266);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(34, 13);
            this.UsersLabel.TabIndex = 0;
            this.UsersLabel.Text = "Users";
            // 
            // UsersListBox
            // 
            this.UsersListBox.FormattingEnabled = true;
            this.UsersListBox.Location = new System.Drawing.Point(510, 282);
            this.UsersListBox.Name = "UsersListBox";
            this.UsersListBox.Size = new System.Drawing.Size(120, 147);
            this.UsersListBox.TabIndex = 1;
            // 
            // ViewHistoryButton
            // 
            this.ViewHistoryButton.Location = new System.Drawing.Point(510, 435);
            this.ViewHistoryButton.Name = "ViewHistoryButton";
            this.ViewHistoryButton.Size = new System.Drawing.Size(119, 23);
            this.ViewHistoryButton.TabIndex = 2;
            this.ViewHistoryButton.Text = "View history of rents ";
            this.ViewHistoryButton.UseVisualStyleBackColor = true;
            this.ViewHistoryButton.Click += new System.EventHandler(this.ViewHistoryButton_Click);
            // 
            // BooksLabel
            // 
            this.BooksLabel.AutoSize = true;
            this.BooksLabel.Location = new System.Drawing.Point(9, 5);
            this.BooksLabel.Name = "BooksLabel";
            this.BooksLabel.Size = new System.Drawing.Size(37, 13);
            this.BooksLabel.TabIndex = 4;
            this.BooksLabel.Text = "Books";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(12, 224);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(75, 23);
            this.AddBookButton.TabIndex = 5;
            this.AddBookButton.Text = "Add Book";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // DeleteBookButton
            // 
            this.DeleteBookButton.Location = new System.Drawing.Point(281, 224);
            this.DeleteBookButton.Name = "DeleteBookButton";
            this.DeleteBookButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteBookButton.TabIndex = 6;
            this.DeleteBookButton.Text = "Delete Book";
            this.DeleteBookButton.UseVisualStyleBackColor = true;
            this.DeleteBookButton.Click += new System.EventHandler(this.DeleteBookButton_Click);
            // 
            // EditBookButton
            // 
            this.EditBookButton.Location = new System.Drawing.Point(555, 224);
            this.EditBookButton.Name = "EditBookButton";
            this.EditBookButton.Size = new System.Drawing.Size(75, 23);
            this.EditBookButton.TabIndex = 7;
            this.EditBookButton.Text = "Edit Book";
            this.EditBookButton.UseVisualStyleBackColor = true;
            this.EditBookButton.Click += new System.EventHandler(this.EditBookButton_Click);
            // 
            // ToHideCheckedList
            // 
            this.ToHideCheckedList.FormattingEnabled = true;
            this.ToHideCheckedList.Location = new System.Drawing.Point(9, 282);
            this.ToHideCheckedList.Name = "ToHideCheckedList";
            this.ToHideCheckedList.Size = new System.Drawing.Size(120, 109);
            this.ToHideCheckedList.TabIndex = 8;
            // 
            // exlcudeLabel
            // 
            this.exlcudeLabel.AutoSize = true;
            this.exlcudeLabel.Location = new System.Drawing.Point(9, 266);
            this.exlcudeLabel.Name = "exlcudeLabel";
            this.exlcudeLabel.Size = new System.Drawing.Size(109, 13);
            this.exlcudeLabel.TabIndex = 9;
            this.exlcudeLabel.Text = "Categories to exclude";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Location = new System.Drawing.Point(136, 282);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(120, 21);
            this.CurrencyComboBox.TabIndex = 10;
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Location = new System.Drawing.Point(136, 266);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(49, 13);
            this.CurrencyLabel.TabIndex = 11;
            this.CurrencyLabel.Text = "Currency";
            // 
            // BookGridView
            // 
            this.BookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGridView.Location = new System.Drawing.Point(12, 21);
            this.BookGridView.Name = "BookGridView";
            this.BookGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookGridView.Size = new System.Drawing.Size(618, 197);
            this.BookGridView.TabIndex = 12;
            this.BookGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookGridView_CellClick);
            // 
            // MinimalPriceNumericalUpDown
            // 
            this.MinimalPriceNumericalUpDown.Location = new System.Drawing.Point(136, 327);
            this.MinimalPriceNumericalUpDown.Name = "MinimalPriceNumericalUpDown";
            this.MinimalPriceNumericalUpDown.Size = new System.Drawing.Size(120, 20);
            this.MinimalPriceNumericalUpDown.TabIndex = 13;
            // 
            // MaximalPriceNumericUpDown
            // 
            this.MaximalPriceNumericUpDown.Location = new System.Drawing.Point(135, 371);
            this.MaximalPriceNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaximalPriceNumericUpDown.Name = "MaximalPriceNumericUpDown";
            this.MaximalPriceNumericUpDown.Size = new System.Drawing.Size(124, 20);
            this.MaximalPriceNumericUpDown.TabIndex = 14;
            this.MaximalPriceNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // MinPriceLabel
            // 
            this.MinPriceLabel.AutoSize = true;
            this.MinPriceLabel.Location = new System.Drawing.Point(136, 311);
            this.MinPriceLabel.Name = "MinPriceLabel";
            this.MinPriceLabel.Size = new System.Drawing.Size(69, 13);
            this.MinPriceLabel.TabIndex = 15;
            this.MinPriceLabel.Text = "Minimal Price";
            // 
            // MaximalPriceLabel
            // 
            this.MaximalPriceLabel.AutoSize = true;
            this.MaximalPriceLabel.Location = new System.Drawing.Point(136, 355);
            this.MaximalPriceLabel.Name = "MaximalPriceLabel";
            this.MaximalPriceLabel.Size = new System.Drawing.Size(72, 13);
            this.MaximalPriceLabel.TabIndex = 16;
            this.MaximalPriceLabel.Text = "Maximal Price";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 398);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.AuthorLabel.TabIndex = 17;
            this.AuthorLabel.Text = "Author";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(12, 415);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(244, 20);
            this.AuthorTextBox.TabIndex = 18;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(15, 447);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 19;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(12, 464);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(244, 20);
            this.TitleTextBox.TabIndex = 20;
            // 
            // MaximalPagesLabel
            // 
            this.MaximalPagesLabel.AutoSize = true;
            this.MaximalPagesLabel.Location = new System.Drawing.Point(316, 355);
            this.MaximalPagesLabel.Name = "MaximalPagesLabel";
            this.MaximalPagesLabel.Size = new System.Drawing.Size(78, 13);
            this.MaximalPagesLabel.TabIndex = 24;
            this.MaximalPagesLabel.Text = "Maximal Pages";
            // 
            // MinimalPagesLabel
            // 
            this.MinimalPagesLabel.AutoSize = true;
            this.MinimalPagesLabel.Location = new System.Drawing.Point(316, 311);
            this.MinimalPagesLabel.Name = "MinimalPagesLabel";
            this.MinimalPagesLabel.Size = new System.Drawing.Size(75, 13);
            this.MinimalPagesLabel.TabIndex = 23;
            this.MinimalPagesLabel.Text = "Minimal Pages";
            // 
            // MaximalPagesNumericUpdown
            // 
            this.MaximalPagesNumericUpdown.Location = new System.Drawing.Point(319, 371);
            this.MaximalPagesNumericUpdown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaximalPagesNumericUpdown.Name = "MaximalPagesNumericUpdown";
            this.MaximalPagesNumericUpdown.Size = new System.Drawing.Size(120, 20);
            this.MaximalPagesNumericUpdown.TabIndex = 22;
            this.MaximalPagesNumericUpdown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // MinimalPagesNumericUpdown
            // 
            this.MinimalPagesNumericUpdown.Location = new System.Drawing.Point(316, 327);
            this.MinimalPagesNumericUpdown.Name = "MinimalPagesNumericUpdown";
            this.MinimalPagesNumericUpdown.Size = new System.Drawing.Size(120, 20);
            this.MinimalPagesNumericUpdown.TabIndex = 21;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(316, 266);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(49, 13);
            this.CategoryLabel.TabIndex = 26;
            this.CategoryLabel.Text = "Category";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(316, 282);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(120, 21);
            this.CategoryComboBox.TabIndex = 25;
            // 
            // CurrencyCheckBox
            // 
            this.CurrencyCheckBox.AutoSize = true;
            this.CurrencyCheckBox.Location = new System.Drawing.Point(263, 285);
            this.CurrencyCheckBox.Name = "CurrencyCheckBox";
            this.CurrencyCheckBox.Size = new System.Drawing.Size(15, 14);
            this.CurrencyCheckBox.TabIndex = 27;
            this.CurrencyCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinimalPriceCheckBox
            // 
            this.MinimalPriceCheckBox.AutoSize = true;
            this.MinimalPriceCheckBox.Location = new System.Drawing.Point(263, 329);
            this.MinimalPriceCheckBox.Name = "MinimalPriceCheckBox";
            this.MinimalPriceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MinimalPriceCheckBox.TabIndex = 28;
            this.MinimalPriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaximalPriceCheckBox
            // 
            this.MaximalPriceCheckBox.AutoSize = true;
            this.MaximalPriceCheckBox.Location = new System.Drawing.Point(263, 373);
            this.MaximalPriceCheckBox.Name = "MaximalPriceCheckBox";
            this.MaximalPriceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MaximalPriceCheckBox.TabIndex = 29;
            this.MaximalPriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // AuthorCheckBox
            // 
            this.AuthorCheckBox.AutoSize = true;
            this.AuthorCheckBox.Location = new System.Drawing.Point(263, 418);
            this.AuthorCheckBox.Name = "AuthorCheckBox";
            this.AuthorCheckBox.Size = new System.Drawing.Size(15, 14);
            this.AuthorCheckBox.TabIndex = 30;
            this.AuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // TitleCheckbox
            // 
            this.TitleCheckbox.AutoSize = true;
            this.TitleCheckbox.Location = new System.Drawing.Point(263, 467);
            this.TitleCheckbox.Name = "TitleCheckbox";
            this.TitleCheckbox.Size = new System.Drawing.Size(15, 14);
            this.TitleCheckbox.TabIndex = 31;
            this.TitleCheckbox.UseVisualStyleBackColor = true;
            // 
            // CategoryCheckBox
            // 
            this.CategoryCheckBox.AutoSize = true;
            this.CategoryCheckBox.Location = new System.Drawing.Point(442, 282);
            this.CategoryCheckBox.Name = "CategoryCheckBox";
            this.CategoryCheckBox.Size = new System.Drawing.Size(15, 14);
            this.CategoryCheckBox.TabIndex = 32;
            this.CategoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinimalPagesCheckBox
            // 
            this.MinimalPagesCheckBox.AutoSize = true;
            this.MinimalPagesCheckBox.Location = new System.Drawing.Point(442, 329);
            this.MinimalPagesCheckBox.Name = "MinimalPagesCheckBox";
            this.MinimalPagesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MinimalPagesCheckBox.TabIndex = 33;
            this.MinimalPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaximalPagesCheckBox
            // 
            this.MaximalPagesCheckBox.AutoSize = true;
            this.MaximalPagesCheckBox.Location = new System.Drawing.Point(442, 373);
            this.MaximalPagesCheckBox.Name = "MaximalPagesCheckBox";
            this.MaximalPagesCheckBox.Size = new System.Drawing.Size(15, 14);
            this.MaximalPagesCheckBox.TabIndex = 34;
            this.MaximalPagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterButton
            // 
            this.FilterButton.Location = new System.Drawing.Point(316, 462);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(141, 22);
            this.FilterButton.TabIndex = 35;
            this.FilterButton.Text = "Apply filters";
            this.FilterButton.UseVisualStyleBackColor = true;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ViewPriceInPLNCheckBox
            // 
            this.ViewPriceInPLNCheckBox.AutoSize = true;
            this.ViewPriceInPLNCheckBox.Location = new System.Drawing.Point(442, 421);
            this.ViewPriceInPLNCheckBox.Name = "ViewPriceInPLNCheckBox";
            this.ViewPriceInPLNCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ViewPriceInPLNCheckBox.TabIndex = 38;
            this.ViewPriceInPLNCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewCurrencyLabel
            // 
            this.ViewCurrencyLabel.AutoSize = true;
            this.ViewCurrencyLabel.Location = new System.Drawing.Point(316, 418);
            this.ViewCurrencyLabel.Name = "ViewCurrencyLabel";
            this.ViewCurrencyLabel.Size = new System.Drawing.Size(93, 13);
            this.ViewCurrencyLabel.TabIndex = 37;
            this.ViewCurrencyLabel.Text = "View Price In PLN";
            // 
            // ReturnBookButton
            // 
            this.ReturnBookButton.Location = new System.Drawing.Point(510, 490);
            this.ReturnBookButton.Name = "ReturnBookButton";
            this.ReturnBookButton.Size = new System.Drawing.Size(120, 23);
            this.ReturnBookButton.TabIndex = 39;
            this.ReturnBookButton.Text = "Return Book";
            this.ReturnBookButton.UseVisualStyleBackColor = true;
            this.ReturnBookButton.Click += new System.EventHandler(this.ReturnBookButton_Click);
            // 
            // ProlongRentButton
            // 
            this.ProlongRentButton.Location = new System.Drawing.Point(511, 462);
            this.ProlongRentButton.Name = "ProlongRentButton";
            this.ProlongRentButton.Size = new System.Drawing.Size(119, 23);
            this.ProlongRentButton.TabIndex = 40;
            this.ProlongRentButton.Text = "Prolong Rent";
            this.ProlongRentButton.UseVisualStyleBackColor = true;
            this.ProlongRentButton.Click += new System.EventHandler(this.ProlongRentButton_Click);
            // 
            // RentedBooksListBox
            // 
            this.RentedBooksListBox.FormattingEnabled = true;
            this.RentedBooksListBox.Location = new System.Drawing.Point(509, 282);
            this.RentedBooksListBox.Name = "RentedBooksListBox";
            this.RentedBooksListBox.Size = new System.Drawing.Size(120, 147);
            this.RentedBooksListBox.TabIndex = 41;
            // 
            // RentBookButton
            // 
            this.RentBookButton.Location = new System.Drawing.Point(148, 224);
            this.RentBookButton.Name = "RentBookButton";
            this.RentBookButton.Size = new System.Drawing.Size(75, 23);
            this.RentBookButton.TabIndex = 42;
            this.RentBookButton.Text = "Rent Book";
            this.RentBookButton.UseVisualStyleBackColor = true;
            this.RentBookButton.Click += new System.EventHandler(this.RentBookButton_Click);
            // 
            // BookDetailsButton
            // 
            this.BookDetailsButton.Location = new System.Drawing.Point(414, 224);
            this.BookDetailsButton.Name = "BookDetailsButton";
            this.BookDetailsButton.Size = new System.Drawing.Size(86, 23);
            this.BookDetailsButton.TabIndex = 43;
            this.BookDetailsButton.Text = "Book\'s Details";
            this.BookDetailsButton.UseVisualStyleBackColor = true;
            // 
            // MainPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 519);
            this.Controls.Add(this.BookDetailsButton);
            this.Controls.Add(this.RentBookButton);
            this.Controls.Add(this.RentedBooksListBox);
            this.Controls.Add(this.ProlongRentButton);
            this.Controls.Add(this.ReturnBookButton);
            this.Controls.Add(this.ViewPriceInPLNCheckBox);
            this.Controls.Add(this.ViewCurrencyLabel);
            this.Controls.Add(this.FilterButton);
            this.Controls.Add(this.MaximalPagesCheckBox);
            this.Controls.Add(this.MinimalPagesCheckBox);
            this.Controls.Add(this.CategoryCheckBox);
            this.Controls.Add(this.TitleCheckbox);
            this.Controls.Add(this.AuthorCheckBox);
            this.Controls.Add(this.MaximalPriceCheckBox);
            this.Controls.Add(this.MinimalPriceCheckBox);
            this.Controls.Add(this.CurrencyCheckBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.MaximalPagesLabel);
            this.Controls.Add(this.MinimalPagesLabel);
            this.Controls.Add(this.MaximalPagesNumericUpdown);
            this.Controls.Add(this.MinimalPagesNumericUpdown);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.MaximalPriceLabel);
            this.Controls.Add(this.MinPriceLabel);
            this.Controls.Add(this.MaximalPriceNumericUpDown);
            this.Controls.Add(this.MinimalPriceNumericalUpDown);
            this.Controls.Add(this.BookGridView);
            this.Controls.Add(this.CurrencyLabel);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.exlcudeLabel);
            this.Controls.Add(this.ToHideCheckedList);
            this.Controls.Add(this.EditBookButton);
            this.Controls.Add(this.DeleteBookButton);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.BooksLabel);
            this.Controls.Add(this.ViewHistoryButton);
            this.Controls.Add(this.UsersListBox);
            this.Controls.Add(this.UsersLabel);
            this.Name = "MainPanelForm";
            this.Text = "AdminPanelForm";
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalPriceNumericalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximalPriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximalPagesNumericUpdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimalPagesNumericUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.ListBox UsersListBox;
        private System.Windows.Forms.Button ViewHistoryButton;
        private System.Windows.Forms.Label BooksLabel;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.Button DeleteBookButton;
        private System.Windows.Forms.Button EditBookButton;
        private System.Windows.Forms.CheckedListBox ToHideCheckedList;
        private System.Windows.Forms.Label exlcudeLabel;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.DataGridView BookGridView;
        private System.Windows.Forms.NumericUpDown MinimalPriceNumericalUpDown;
        private System.Windows.Forms.NumericUpDown MaximalPriceNumericUpDown;
        private System.Windows.Forms.Label MinPriceLabel;
        private System.Windows.Forms.Label MaximalPriceLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label MaximalPagesLabel;
        private System.Windows.Forms.Label MinimalPagesLabel;
        private System.Windows.Forms.NumericUpDown MaximalPagesNumericUpdown;
        private System.Windows.Forms.NumericUpDown MinimalPagesNumericUpdown;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.CheckBox CurrencyCheckBox;
        private System.Windows.Forms.CheckBox MinimalPriceCheckBox;
        private System.Windows.Forms.CheckBox MaximalPriceCheckBox;
        private System.Windows.Forms.CheckBox AuthorCheckBox;
        private System.Windows.Forms.CheckBox TitleCheckbox;
        private System.Windows.Forms.CheckBox CategoryCheckBox;
        private System.Windows.Forms.CheckBox MinimalPagesCheckBox;
        private System.Windows.Forms.CheckBox MaximalPagesCheckBox;
        private System.Windows.Forms.Button FilterButton;
        private System.Windows.Forms.CheckBox ViewPriceInPLNCheckBox;
        private System.Windows.Forms.Label ViewCurrencyLabel;
        private System.Windows.Forms.Button ReturnBookButton;
        private System.Windows.Forms.Button ProlongRentButton;
        private System.Windows.Forms.ListBox RentedBooksListBox;
        private System.Windows.Forms.Button RentBookButton;
        private System.Windows.Forms.Button BookDetailsButton;
    }
}