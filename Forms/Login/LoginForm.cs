using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Forms.Login;

namespace Library.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var username = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            bool userValidated = LoginLogic.validateUser(username, password);
            if (userValidated)
            {
                Hide();
                LoginLogic.loginUser(username, password);
                Show();
            }
            else
            {
                clear();
            }
        }

        private void clear()
        {
            LoginTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            Hide();
            registerForm.ShowDialog();
            Show();
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginLogic.loginGuest();
            Show();
        }
    }
}
