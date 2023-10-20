using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ElectronicsProducts:Product
    {
        public ElectronicsProducts(int warrantyPeriod,string productName,double price,int quantity):base(productName,price,quantity)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public int WarrantyPeriod { get; set; }

        public void DisplayWarrantyPeriod()
        {
            Console.WriteLine("Warranty Period: {0}",WarrantyPeriod);
        }


    }
}
