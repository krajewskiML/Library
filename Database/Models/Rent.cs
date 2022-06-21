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
            return $"asdfasdfasfd {this.RentId}";
            // title author rented at date (not returned / returned at)
            StringBuilder sb = new StringBuilder();
            sb.Append(sb.ToString());
            return sb.ToString();
        }
    }
}
