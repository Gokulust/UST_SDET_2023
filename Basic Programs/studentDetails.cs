using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class studentDetails:CollegeDetails
    {
        public int RollNo {  get; set; } 

        public string? StudentName {  get; set; }

        public string? City {  get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("Roll num : {0} \nName: {1} \nCity: {2}",RollNo,StudentName,City);
        }

    }
}
