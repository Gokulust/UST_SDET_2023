using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentGrade:StudentMarks
    {
        public string? Grade {  get; set; }

        public string CalculateGrade()
        {
            if (Average>90)
            {
                return "A";
            }
            else
            {
                return "B";
            }
        }
    }
}
