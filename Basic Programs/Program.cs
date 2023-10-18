// See https://aka.ms/new-console-template for more information

using Basic_Programs;

//Calculation calculation = new Calculation();
//Console.WriteLine("Enter 2 numbers");
//int numberOne, numberTwo, result;
//numberOne=Convert.ToInt32(Console.ReadLine());
//numberTwo=Convert.ToInt32(Console.ReadLine());
//result = calculation.Add(numberOne, numberTwo);
//Console.WriteLine($"{numberOne}+{numberTwo}={result}");

Electricity electricity=new Electricity(12345,8000,8300,"gokul");
Console.WriteLine(electricity.CalculateBill());
