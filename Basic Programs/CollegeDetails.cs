using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class CollegeDetails
    {
        public String? CollegeName { get; set; }

        public String? CollegeLocation { get; set; }    

        public void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name: {0} \n College Location {1}", CollegeName, CollegeLocation);
        }
    }
}
