using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignments
{
    internal class TourismDestination
    {
        public string? Name { get; set; }
        public string? Country { get; set; }

        public int Rating { get; set; }

        public double PricePerNight { get; set; }

        public static List<TourismDestination>TourismDestinationsList=new List<TourismDestination>();

        public TourismDestination(string? name, string? country, int rating,double pricePerNight)
        {
            Name = name;
            Country = country;
            Rating = rating;
            PricePerNight = pricePerNight;
        }
        public static List<TourismDestination> ViewSortedDestination()
        {
            var sortedDestination=TourismDestinationsList.OrderByDescending(x=>x.Rating).ToList();
            return sortedDestination;
        }
        public static List<TourismDestination>SortDestinationAboveSpecificRating()
        {
            var list = TourismDestinationsList.OrderByDescending((x) => x.Rating).Where(x => x.Rating > 3).ToList();
            return list;

        }
        public static List<TourismDestination>SortByPrice()
        {
            var list =TourismDestinationsList.OrderBy(x=>x.PricePerNight).ToList();
            return list;
        }
        public static TourismDestination SearchByCountry(string country)
        {
            var touristDestination=TourismDestinationsList.FirstOrDefault(x=>x.Country==country);
            return touristDestination;
        }

    }
}
