using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Constants
{
    public class Currencies
    {
        public static readonly string EUR = "eur";
        public static readonly string USD = "usd";
        public static readonly string PLN = "zl";

        public static Dictionary<string, double> ratios = new Dictionary<string, double>()
        {
            {PLN, 1},
            {EUR, 4.65},
            {USD, 4.5}
        };

        public static List<string> getCurrencies()
        {
            return new List<string>() { EUR, USD, PLN };
        }

        public static double convertPrice(string from, string to, double price)
        {
            var priceInPln = price * ratios[from];
            var priceOut = priceInPln * ratios[to];
            return priceOut;
        }
    }
}
