using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Employee
    {
        private int empolyeeId;
        private string? employeeName, department;
        private double basicPay;
        private readonly int _bonus=10;

        public Employee(int empolyeeId, string? employeeName, string? department, double basicPay)
        {
            EmpolyeeId = empolyeeId;
            EmployeeName = employeeName;
            Department = department;
            BasicPay = basicPay;
        }

        public int EmpolyeeId { get => empolyeeId; set => empolyeeId = value; }
        public string? EmployeeName { get => employeeName; set => employeeName = value; }
        public string? Department { get => department; set => department = value; }
        public double BasicPay { get => basicPay; set => basicPay = value; }

        public int Bonus => _bonus;

        public double GetSalary()
        {
            double netSalary,grossSalary;
            double allowances=BasicPay*0.3+BasicPay*0.2+BasicPay*0.15;
            grossSalary = BasicPay + allowances;
            double deductions = BasicPay * 0.1;
            netSalary = grossSalary - deductions;
            return netSalary;
        }
    }
}
