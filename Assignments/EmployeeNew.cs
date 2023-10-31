using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class EmployeeNew
    {
        public EmployeeNew(int employeeId, string? employeeName, int performanceRating)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            PerformanceRating = performanceRating;
        }

        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }

        public int PerformanceRating { get; set; }

        public static double BonusCalculation(EmployeeNew employee)
        {
            double bonus;
            if(employee.PerformanceRating<2)
            {
                bonus = 5000;
                return bonus;
            }
            else if(employee.PerformanceRating<4)
            {
                bonus = 1000;
                return bonus;
            }
            else
            {
                bonus = 15000;
                return bonus;
            }

        }
        public static double BonusCalculationAccount(EmployeeNew employee)
        {
            double bonus;
            if (employee.PerformanceRating < 2)
            {
                bonus = 10000;
                return bonus;
            }
            else if (employee.PerformanceRating < 4)
            {
                bonus = 15000;
                return bonus;
            }
            else
            {
                bonus = 25000;
                return bonus;
            }

        }
    }
}
