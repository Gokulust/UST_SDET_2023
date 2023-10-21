using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Order
    {
        public static List<Genre> OrderedBookList = new List<Genre>();
        public string? OrderDate;
        public double TotalCost;

        public double GetTotalCost()
        {
            
            foreach (var genre in OrderedBookList)
            {
                TotalCost += genre.Price;
            }
            return TotalCost;
        }
    }
}
