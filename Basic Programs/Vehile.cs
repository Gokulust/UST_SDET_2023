using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal abstract class Vehile
    {
        public int Vehnum {  get; set; }
        public string? Brand { get; set; }

        public string? Model { get ; set; }

        public string? type { get; set; }

        public abstract string? setTypeForVeh();

        public void Display()
        {
            Console.WriteLine(" vehicle Number : {0}\nBrand: {1}", Vehnum, Brand);
        }
    }
}
