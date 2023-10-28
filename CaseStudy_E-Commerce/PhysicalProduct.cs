using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_E_Commerce
{
    internal class PhysicalProduct:Product
    {
        public int Deight {  get; set; }
        public string? Dimension { get; set; }

        public static List<PhysicalProduct>physicalProductList=new List<PhysicalProduct>();
    }
}
