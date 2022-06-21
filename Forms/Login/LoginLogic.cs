using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Database.Controllers;
using System.Windows.Forms;
using Library.Database.Models;
using Library.Forms.AdminPanel;
using Library.Utilities;

namespace Library.Forms.Login
{
    public class LoginLogic
    {
        public static bool validateUser(string username, string password)
        {
            if (!UserController.doesUserExist(username))
            {
                MessageBox.Show(
                   $"user with login: {username} does not exist!",
                   "Wrong login",
                   MessageBoxButtons.OK
                   );
                return false;
            }
            if (!UserController.isPasswordValid(username, password))
            {
                MessageBox.Show(
                   $"Password does not match login: {username} ",
                   "Wrong password",
                   MessageBoxButtons.OK
                   );
                return false;
            }
            return true;
        }
        public static bool registerUser(string username, string password, string passwordRepeated)
        {
            if (UserController.doesUserExist(username))
            {
                MessageBox.Show(
                   $"user with login: {username} already exist!",
                   "Login taken",
                   MessageBoxButtons.OK
                   );
                return false;
            }
            if (password != passwordRepeated)
            {
                MessageBox.Show(
                   $"Passwords does not match!",
                   "Wrong passwords",
                   MessageBoxButtons.OK
                   );
                return false;
            }
            MessageBox.Show(
                   $"You have succesfully created new account",
                   "Wrong passwords",
                   MessageBoxButtons.OK
                   );
            UserController.addUser(username, password);
            var user = UserController.getUser(username, password);
            return true;
        }
        public static void loginUser(string username, string password)
        {
            User user = UserController.getUser(username, password);
            MainPanelForm adminPanel = new MainPanelForm(user);
            adminPanel.ShowDialog();
        }

        public static void loginGuest()
        {
            GuestUser user = new GuestUser();
            MainPanelForm adminPanel = new MainPanelForm(user);
            adminPanel.ShowDialog();
        }
    }
}
