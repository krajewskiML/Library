namespace Library.Forms.Login
{
    partial class RegisterForm
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginlLbel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordlabel = new System.Windows.Forms.Label();
            this.RepeatedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(16, 79);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // LoginlLbel
            // 
            this.LoginlLbel.AutoSize = true;
            this.LoginlLbel.Location = new System.Drawing.Point(16, 25);
            this.LoginlLbel.Name = "LoginlLbel";
            this.LoginlLbel.Size = new System.Drawing.Size(33, 13);
            this.LoginlLbel.TabIndex = 6;
            this.LoginlLbel.Text = "Login";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(124, 76);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(134, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(124, 25);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(134, 20);
            this.LoginTextBox.TabIndex = 4;
            // 
            // RepeatPasswordlabel
            // 
            this.RepeatPasswordlabel.AutoSize = true;
            this.RepeatPasswordlabel.Location = new System.Drawing.Point(16, 132);
            this.RepeatPasswordlabel.Name = "RepeatPasswordlabel";
            this.RepeatPasswordlabel.Size = new System.Drawing.Size(90, 13);
            this.RepeatPasswordlabel.TabIndex = 9;
            this.RepeatPasswordlabel.Text = "Repeat password";
            // 
            // RepeatedPasswordTextBox
            // 
            this.RepeatedPasswordTextBox.Location = new System.Drawing.Point(124, 129);
            this.RepeatedPasswordTextBox.Name = "RepeatedPasswordTextBox";
            this.RepeatedPasswordTextBox.Size = new System.Drawing.Size(134, 20);
            this.RepeatedPasswordTextBox.TabIndex = 8;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(124, 178);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 213);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RepeatPasswordlabel);
            this.Controls.Add(this.RepeatedPasswordTextBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginlLbel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label LoginlLbel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label RepeatPasswordlabel;
        private System.Windows.Forms.TextBox RepeatedPasswordTextBox;
        private System.Windows.Forms.Button RegisterButton;
    }
}