using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentMarks:studentDetails
    {
       

        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }  
        public int Total { get; set; }
        public double Average { get; set; }

        public int CalculateTotal()
        {
            Total=Mark1+Mark2 + Mark3;
            return Total;
        }

        public double CalculateAverage()
        {
            Average=(Mark1+ Mark2+Mark3)/3;
            return Average;
        }


    }
}
