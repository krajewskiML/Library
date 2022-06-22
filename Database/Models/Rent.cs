using Library.Database.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Database.Models
{
    public class Rent
    {
        public int RentId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime Rented { get; set; }
        public DateTime? Returned { get; set; }

        override public string ToString()
        {
            // get books title
            var title = BookController.getTitle(BookId);
            // title author rented at date (not returned / returned at)
            StringBuilder sb = new StringBuilder();
            sb.Append(title);
            sb.Append(" has been rented on: ");
            sb.Append(Rented);
            if(Returned == null)
            {
                sb.Append(" and has not been returned");
            }
            else
            {
                sb.Append(" and has been returned on: ");
                sb.Append(Returned);
            }
            return sb.ToString();
        }
    }
}
