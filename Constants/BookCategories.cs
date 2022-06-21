using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Constants
{
    public class BookCategories
    {
        public static readonly string FICTION = "fiction";
        public static readonly string NON_FICTION = "nonfiction";
        public static readonly string DRAMA = "drama";
        public static readonly string POETRY = "fiction";
        public static readonly string FOLKTALE = "folktale";

        public static List<string> getBookCategories()
        {
            return new List<string> { FICTION, NON_FICTION, DRAMA, POETRY, FOLKTALE };
        }
    }
}
