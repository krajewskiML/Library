using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Forms.AdminPanel
{
    
    public class Filter
    {
        public string currency { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string author { get; set; }
        public int? pagesMin { get; set; }
        public int? pagesMax { get; set; }
        public int? priceMin { get; set; }
        public int? priceMax { get; set; }
        public bool viewPriceInPLN { get; set; }
        public List<string> categoriesExcluded { get; set; }
        public Filter(
            string currency,
            string title,
            string category,
            string author,
            int? pagesMin,
            int? pagesMax,
            int? priceMin,
            int? priceMax,
            bool viewPriceInPLN,
            List<string> categoriesExcluded)
        {
            this.currency = currency;
            this.title = title;
            this.category = category;
            this.author = author;
            this.pagesMin = pagesMin;
            this.pagesMax = pagesMax;
            this.priceMin = priceMin;
            this.priceMax = priceMax;
            this.viewPriceInPLN = viewPriceInPLN;
            this.categoriesExcluded = categoriesExcluded;
        }
    }
}
