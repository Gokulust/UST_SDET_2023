using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_E_Commerce
{
    internal class PhysicalProduct:Product
    {
        public int weight {  get; set; }
        public string? Dimension { get; set; }

        public static List<PhysicalProduct> physicalProductList=new List<PhysicalProduct>();



        public static double CalculateCost(List<PhysicalProduct> physicalProductsList)
        {
            double totalCost=0;
            foreach(PhysicalProduct physicalProduct in physicalProductsList)
            {
                totalCost += physicalProduct.StockQuantity * physicalProduct.ProductPrice;
            }
            return totalCost;

        }
    }
}
