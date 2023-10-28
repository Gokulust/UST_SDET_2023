using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_E_Commerce
{
    internal class DigitalProduct:Product
    {
        public String? DownloadLink { get; set; }
        public String? FileFormat { get; set; }

        public static  List<DigitalProduct>DigitalPRoductList=new List<DigitalProduct>();

    }
}
