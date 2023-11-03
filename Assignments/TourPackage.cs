using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourPackage
    {
        public static List<TourPackage>TourPackages=new List<TourPackage>();
        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public string StartDate { get; set; }

        public decimal Price { get; set; }

       

        public TourPackage(int packageId, string? destination, string startDate, decimal price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        //static void BookPackage(TourPackage package)
        //{
        //    Console.WriteLine("Enter the id to book");
        //    int a=Convert.ToInt32(package.Destination);
        //    lock(TourPackages) {
        //        var pack = TourPackages.Find(x= x.PackageId == a);
        //        Console.WriteLine("Booking request For BookingId:{0} to {1} Starting On {2}", pack.PackageId, pack.Destination, pack.StartDate);
        //        Thread.Sleep(2000);
        //        Console.WriteLine("Booking Confirmed");

        //    }
            
                
            
            
        //}

    }
  
  
}
