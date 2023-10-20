using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class DigitalProduct:ElectronicsProducts
    {
        public DigitalProduct(string fileFormat,int warranty,string productName,double price,int quantity):base(warranty,productName,price,quantity)
        {
            FileFormat = fileFormat;
        }

        public string FileFormat { set; get; }

        public void DisplayFileFormat()
        {
            Console.WriteLine("File Format :{0}",FileFormat);
        }
    }
}
