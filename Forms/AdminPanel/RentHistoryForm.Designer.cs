namespace Library.Forms.AdminPanel
{
    partial class RentHistoryForm
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
            this.UserRentHistoryLabel = new System.Windows.Forms.Label();
            this.RentHistoryListBox = new System.Windows.Forms.ListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserRentHistoryLabel
            // 
            this.UserRentHistoryLabel.AutoSize = true;
            this.UserRentHistoryLabel.Location = new System.Drawing.Point(13, 13);
            this.UserRentHistoryLabel.Name = "UserRentHistoryLabel";
            this.UserRentHistoryLabel.Size = new System.Drawing.Size(0, 13);
            this.UserRentHistoryLabel.TabIndex = 0;
            // 
            // RentHistoryListBox
            // 
            this.RentHistoryListBox.FormattingEnabled = true;
            this.RentHistoryListBox.Location = new System.Drawing.Point(13, 45);
            this.RentHistoryListBox.Name = "RentHistoryListBox";
            this.RentHistoryListBox.Size = new System.Drawing.Size(302, 251);
            this.RentHistoryListBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(127, 331);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 366);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RentHistoryListBox);
            this.Controls.Add(this.UserRentHistoryLabel);
            this.Name = "RentHistoryForm";
            this.Text = "RentHistory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserRentHistoryLabel;
        private System.Windows.Forms.ListBox RentHistoryListBox;
        private System.Windows.Forms.Button OKButton;
    }
}