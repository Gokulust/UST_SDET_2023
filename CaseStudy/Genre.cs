using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Genre : Book
    {
        public Genre(string? title, string? author, int iSBN, double price, string? availability, string type) : base(title, author, iSBN, price, availability)
        {
            Type = type;
        }
        public string Type { get; set; }
    }
}
