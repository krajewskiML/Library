using Library.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public class GuestUser : User
    {
        public readonly bool IsGuest = true;
    }
}
