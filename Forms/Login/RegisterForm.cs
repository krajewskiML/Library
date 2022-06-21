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

namespace Library.Forms.Login
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var username = LoginTextBox.Text;
            var password = PasswordTextBox.Text;
            var repeatedPassword = RepeatedPasswordTextBox.Text;
            bool isRegistered = LoginLogic.registerUser(username, password, repeatedPassword);
            if (isRegistered)
            {
                Close();
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
            RepeatedPasswordTextBox.Text = string.Empty;
        }
    }
}
