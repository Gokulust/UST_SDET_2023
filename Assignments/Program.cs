// See https://aka.ms/new-console-template for more information
using Assignments;

//Console.WriteLine("Enter the student name:");
//string? studentName=Console.ReadLine();
//Console.WriteLine("Enter the first Mark:");
//double markOne=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the second Mark:");
//double markTwo = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Enter the third Mark:");
//double markThree = Convert.ToDouble(Console.ReadLine());

//Student student=new Student(studentName,markOne, markTwo, markThree);
//Console.WriteLine($"Total Mark of student {student.StudentName} is {student.GetTotalMarks()} And Average Mark is {student.CalculateAverage()} with grade {student.GetGrade()}");

//19-10-2023

//Product firstProduct = new Product("iphone", 60000, 3);
//Product secondProduct = new Product("v27 pro", 40000, 4);
//Product thirdProduct = new Product("s23", 80000, 5);

//Product[] productArray = {firstProduct, secondProduct, thirdProduct};

//foreach (Product product in productArray)
//{
//    Console.WriteLine("Product Name: {0} \nPrice : {1} \nQuantity:{2} \nProduct value:{3}",product.ProductName,product.Price,product.Quantity,product.ProductValue());
//}

//StudentOne firstStudent = new StudentOne("Gokul", new double[] { 23, 45, 67 }, 'A');
//StudentOne secondStudent = new StudentOne("shirin", new double[] { 45, 56, 76 }, 'B');
//StudentOne thirdStudent = new StudentOne("vishnu", new double[] { 45, 76, 89 }, 'C');

//firstStudent.GetMarkSummary();
//secondStudent.GetMarkSummary();
//thirdStudent.GetMarkSummary();

//20-10-2023

ElectronicsProducts EP = new ElectronicsProducts(12, "Refrigerator", 30000, 2);
EP.DisplayWarrantyPeriod();
Console.WriteLine(EP.ProductValue());

DigitalProduct DP = new DigitalProduct("jpg", 12, "Image", 30000, 2);
DP.DisplayWarrantyPeriod();
DP.DisplayFileFormat();
Console.WriteLine(DP.ProductValue());

ClothingProduct CP = new ClothingProduct("L", "T-shirt", 12000, 4);
Console.WriteLine(DP.ProductValue());
Console.WriteLine(CP.ProductValue());
Console.WriteLine(EP.ProductValue());

