using Library.Database.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database.Models
{
    public class BookReminder
    {
        public int BookReminderId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }


        public override string ToString()
        {
            var title = BookController.getTitle(BookId);
            return $"{title} is now available!";
        }
    }
}
