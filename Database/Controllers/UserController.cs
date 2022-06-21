using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Database.Models;
using Library.Database.Context;

namespace Library.Database.Controllers
{
    public class UserController
    {
        public static bool isAdminCreated()
        {
            using (var db = new LibraryContext())
            {
                var numOfAdmins = db.Users.Where(u => u.IsAdmin).Count();
                return numOfAdmins > 0;
            }
        }

        public static void createAdmin()
        {
            using (var db = new LibraryContext())
            {
                var admin = new User() { IsAdmin = true , Password = "admin", UserName = "admin"};
                db.Users.Add(admin);
                db.SaveChanges();
            }
        }
        public static bool doesUserExist(string username)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.Where(u => u.UserName == username).Count();
                return user > 0;
            }
        }

        public static bool isPasswordValid(string username, string password)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.Where(u => u.UserName == username && u.Password == password).Count();
                return user > 0;
            }
        }
        public static User getUser(string username, string password)
        {
            using (var db = new LibraryContext())
            {
                var user = db.Users.Where(u => u.UserName == username && u.Password == password).First();
                return user;
            }
        }
        public static void addUser(string username, string password)
        {
            using (var db = new LibraryContext())
            {
                var newUser = new User() { IsAdmin = false, Password = password, UserName = username };
                db.Users.Add(newUser);
                db.SaveChanges();
            }
        }

        public static List<User> getNonAdminUsers()
        {
            using (var db = new LibraryContext())
            {
                var users = db.Users.Where(u => u.IsAdmin == false).ToList();
                return users;
            }
        }
    }
}
