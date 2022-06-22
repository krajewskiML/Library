using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Constants
{
    public class RentConstants
    {
        public const int MAX_BOOKS_RENTED = 3;
        public static TimeSpan MAX_RENT_TIME = new TimeSpan(30, 0, 0, 0);
        //reminding the user about returning after 25 days
        public static TimeSpan REMIND_AFTER_TIME = new TimeSpan(25, 0, 0, 0);
        //public static TimeSpan REMIND_AFTER_TIME = new TimeSpan(0, 0, 0, 40);
    }
}
