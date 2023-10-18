// See https://aka.ms/new-console-template for more information
using Assignments;

Console.WriteLine("Enter the student name:");
string? studentName=Console.ReadLine();
Console.WriteLine("Enter the first Mark:");
double markOne=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second Mark:");
double markTwo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the third Mark:");
double markThree = Convert.ToDouble(Console.ReadLine());

Student student=new Student(studentName,markOne, markTwo, markThree);
Console.WriteLine($"Total Mark of student {student.StudentName} And Average Mark is {student.CalculateAverage()} with grade {student.GetGrade()}");
