// See https://aka.ms/new-console-template for more information

using Basic_Programs;
using Basic_Programs.ExceptionMessages;
using System.Security.Cryptography.X509Certificates;

//18-10-2023

//Calculation calculation = new Calculation();
//Console.WriteLine("Enter 2 numbers");
//int numberOne, numberTwo, result;
//numberOne=Convert.ToInt32(Console.ReadLine());
//numberTwo=Convert.ToInt32(Console.ReadLine());
//result = calculation.Add(numberOne, numberTwo);
//Console.WriteLine($"{numberOne}+{numberTwo}={result}");

//Electricity electricity=new Electricity(12345,8000,8300,"gokul");
//Console.WriteLine(electricity.CalculateBill());
//Employee employee=new Employee(249214,"gokul","IT",8000);
//Console.WriteLine(employee.EmpolyeeId);
//Console.WriteLine(employee.EmployeeName);
//Console.WriteLine(employee.GetSalary());

//19-10-2023

//ArrayEx arrayEx = new ArrayEx();
//arrayEx.OneDim();
//arrayEx.TwoDim();
//arrayEx.jaggered();

//20-10-2023

//StudentMarks marks = new StudentMarks();
//StudentGrade grade = new StudentGrade();
//grade.Mark1 = 98;
//grade.Mark2 = 78;
//grade.Mark3 = 89;
//Console.WriteLine(grade.CalculateTotal());
//Console.WriteLine(grade.CalculateAverage());
//Console.WriteLine(grade.CalculateGrade());
//Console.WriteLine("1.ts 2.NTs 3.Student");
//switch(Convert.ToInt32(Console.ReadLine()))
//{
//        case 1:
//        TeachingStaff teachingStaff = new TeachingStaff();
//        teachingStaff.Staffid = 111;
//        teachingStaff.Name = "TS1";
//        teachingStaff.Department = "Cs";
//        teachingStaff.Specialization = "phd";
//        teachingStaff.Sem = 6;
//        teachingStaff.DisplayteachingStaffDetails();
//        teachingStaff.DisplayStaffDetails();
//        break;
//        case 2:
//        NonTeachingStaff nonTeachingStaff = new NonTeachingStaff();
//        nonTeachingStaff.Staffid = 123;
//        nonTeachingStaff.Name = "Nts";
//        nonTeachingStaff.Department = "admin";
//        nonTeachingStaff.Responsibilities = "attendence";
//        nonTeachingStaff.Experience = 7;
//        nonTeachingStaff.DisplayStaffDetails();
//        nonTeachingStaff.DisplayNonTeachingStaffDetails();
//        break;





//}

//ElectricVehicle electricVehicle = new ElectricVehicle();
//electricVehicle.Vehnum = 100;
//electricVehicle.Model = "xxxx";
//electricVehicle.Brand = "AA";
//Console.WriteLine(electricVehicle.setTypeForVeh());

//21-10-2023

//Doctor doctor = new Doctor();
//doctor.AddNewDoctor();
//doctor.DisplayDoctorDetails();
//doctor.BookAppointment(9087, "vishnu");
//doctor.DeleteAppointment("vyshnav");

//23-10-2023

//Bank bank1 = new BankDetailsNew(249214,678934567L, "Gokul", "Active");
//Bank bank1 = new Bank();
//bank1.WelcomeMessage();
//Console.WriteLine("1.Customer Id 2.Account Number 3.Name");
//int ch=Convert.ToInt32(Console.ReadLine());
//switch(ch)
//{
//    case 1:
//        Console.WriteLine("Enter the customer Id: ");
//        bank1.GetAccountDetails(Convert.ToInt32(Console.ReadLine()));
//        break;
//    case 2:
//        Console.WriteLine("Enter the Account Number :");
//        bank1.GetAccountDetails(Convert.ToInt64(Console.ReadLine()));
//        break;
//    case 3:
//        Console.WriteLine("Enter the Name");
//        bank1.GetAccountDetails(Console.ReadLine());
//        break;
//}
//bank1.GetAccountDetails("Gokul");
//bank1.GetAccountDetails(249214);
//bank1.GetAccountDetails(678934567L);

//25-10-2023

//NonGeneric nonGeneric = new NonGeneric();
//nonGeneric.ArrayListHandling();
//nonGeneric.StackHandling();
//nonGeneric.QueueHandling();
//nonGeneric.HashTableHandling();

//Generic generic = new Generic();
//generic.ArrayListHandling();
//generic.StackHandling();
//generic.QueueHandling();
//generic.DictionaryHandling();

//26-10-2023

//ExceptionHandling exceptionHandling = new ExceptionHandling();
//exceptionHandling.NumberOne = 20;
//exceptionHandling.NumberTwo=0;
//exceptionHandling.Divide();

//try
//{
//    exceptionHandling.NumCheck();
//}
//catch(ArgumentException ex)
//{
//    Console.WriteLine(MyException.exMessagesList[4]);
//}
//catch(NumberOneException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//27-10-2023

//FileOperations fileOperations = new FileOperations();
//fileOperations.CreateFile();
//fileOperations.WriteData();
//fileOperations.ReadData();
//fileOperations.CopyMoveFile();
//fileOperations.DeleteFile();

//30-10-2023

//GenericExample<int> g1 = new GenericExample<int>(10, 20);
//Console.WriteLine(g1.ValueOne + " " + g1.ValueTwo1);
//GenericExample<double>d1= new GenericExample<double>(10.5, 20.5);
//Console.WriteLine(d1.ValueOne+" "+d1.ValueTwo1);
//GenericExample<int> a1=new GenericExample<int>(new int[2] {2,3});
//a1.Display();

//31-10-2023

//public delegate void DelegateOne();
//public delegate void DelegateTwo(int num1,int num2);
//class Program
//{

//    public static DelegateOne MethodA;
//    public static void Main(string[] args)
//    {

//        DelegateOne del = MethodA;

//        DelegateExample delobj= new DelegateExample();
//        DelegateTwo del2 = delobj.Add;
//        del2(2,3);
//        DelegateTwo del3 = delobj.Sub;
//        del3(5, 2);
//        DelegateTwo dobjallop = del2 + del3;
//        dobjallop(10, 2);
//    }
//}

//2-11-2023

//ThreadsExample.ThreadEx();
//AsyncAwait.Example();
