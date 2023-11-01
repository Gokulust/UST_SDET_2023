using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQExample
    {
        public void ExampleOne()
        {
            List<string> courses = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("Web Tech");
            courses.Add("UI");
            courses.Add("DBMS");

            var result = from c in courses where c.Equals("DBMS") select c;
            foreach (var c in result)
            {
                Console.WriteLine(c);
            }
            var output = courses.Where(c => c.Equals("DBMS"));
            foreach (var c in output)
            {
                Console.WriteLine(c);
            }
        }
        public void ExampleTwo()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(12, "gokul", "Cs"));
            students.Add(new Student(13, "shirin", "Bca"));
            students.Add(new Student(14, "vishnu", "Bsc Physics"));
            Student stud=(Student)students.FirstOrDefault(student=>student.Id==12);
            Console.WriteLine(stud.Name);

        }
    }
}
