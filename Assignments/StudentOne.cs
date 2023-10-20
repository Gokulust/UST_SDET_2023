using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class StudentOne
    {
        public string? Name { get; set; }

        double[] Marks;

        public StudentOne(string? name, double[] marks, char grade)
        {
            Name = name;
            Marks = marks;
            Grade = grade;
        }

        public char Grade { get; set; }

        public double CalculateAverage()
        {
            double average;
            average=(Marks.Sum())/Marks.Length;
            return average;
        }
        public void GetMarkSummary()
        {
            Console.WriteLine("{0} has {1} Marks. \nHighest Mark:{2} \nLowest Mark:{3}", Name, Marks.Length, Marks.Max(), Marks.Min());
        }


    }
}
