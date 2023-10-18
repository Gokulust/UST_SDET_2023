using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Student
    {
        public string? StudentName;
        double markOne, markeTwo, markThree;

        public Student(string studentName, double markOne, double markeTwo, double markThree)
        {
            this.StudentName = studentName;
            this.markOne = markOne;
            this.markeTwo = markeTwo;
            this.markThree = markThree;
        }
        public double CalculateAverage()
        {
            double average;
            average = (markOne + markeTwo + markThree) / 3;
            return average;
        }
        public double GetTotalMarks()
        {
            double totalMarks;
            totalMarks = markOne + markeTwo + markThree;
            return totalMarks;
        }
        public char GetGrade()
        {
            double average=CalculateAverage();
            if(average >= 90)
            {
                return 'A';
            }
            else if(average >=80)
            {
                return 'B';
            }
            else if(average >=70)
            {
                return 'C';
            }
            else if(average >=60)
            {
                return 'D';
            }
            else if (average >=50)
            {
                return 'E';
            }
            else
            {
                return 'F';
            }
        }
    }
}
