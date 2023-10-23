using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {
        public Employee(string? firstName, string? lastName, int age,int employeeId) : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
        }

        public int EmployeeId { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine("Full Name: {0} {1} \nAge: {2}", FirstName, LastName, Age);
        }
    }
}
