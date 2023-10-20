using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StaffDetails:CollegeDetails
    {
        public int Staffid { get; set; }
        public string? Name { get; set; }

        public string? Department { get; set; }

        public void DisplayStaffDetails()
        {
            Console.WriteLine("Staff Id: {0} \nName : {1} \n Department : {2}",Staffid,Name,Department);
        }
    }
}
