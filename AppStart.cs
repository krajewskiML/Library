using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Database.Context;
using Library.Database.Controllers;

namespace Library
{
    public class AppStart
    {
        public static void verifyDatabase()
        {
            // creates database if it is not created
            createDatabaseIfNeeeded();
            // adds base admin / librarian if it is not present in database
            if (!UserController.isAdminCreated())
            {
                UserController.createAdmin();
            }
        }

        private static void createDatabaseIfNeeeded()
        {
            using (var dbContext = new LibraryContext())
            {
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
