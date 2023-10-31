// See https://aka.ms/new-console-template for more information
using Assignments;
using Assignments.ExceptionMessage;

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

//ElectronicsProducts EP = new ElectronicsProducts(12, "Refrigerator", 30000, 2);
//EP.DisplayWarrantyPeriod();
//Console.WriteLine(EP.ProductValue());

//DigitalProduct DP = new DigitalProduct("jpg", 12, "Image", 30000, 2);
//DP.DisplayWarrantyPeriod();
//DP.DisplayFileFormat();
//Console.WriteLine(DP.ProductValue());

//ClothingProduct CP = new ClothingProduct("L", "T-shirt", 12000, 4);
//Console.WriteLine(DP.ProductValue());
//Console.WriteLine(CP.ProductValue());
//Console.WriteLine(EP.ProductValue());

//23-10-2023

//Employee employee = new("Gokul", "Raj", 18, 249214);
//employee.DisplayInfo();

//Circle circle = new Circle();
//circle.Radius = 10;
//circle.Draw();

//Rectangle rectangle = new Rectangle();
//rectangle.Width = 10;
//rectangle.Length = 10;
//rectangle.Draw();

//25-10-2023

//InsurancePolicy insurancePolicy = new("Life", 2198, 10000);
//insurancePolicy.RenewPolicy();
//insurancePolicy.DisplayRenewdAmount();
//insurancePolicy.RenewPolicy(20000);
//insurancePolicy.DisplayRenewdAmount();

//LifeInsurance lifeInsurance = new LifeInsurance("Gokul", 24);
//lifeInsurance.PolicyName = "tcs";
//lifeInsurance.PolicyId = 324;
//lifeInsurance.PremiumAmount = 24000;
//Console.WriteLine("Sanctioned amount: {0}", lifeInsurance.CalculatePermium());

//CarInsurance carInsurance = new CarInsurance();
//carInsurance.PolicyName = "Sbi";
//carInsurance.PolicyId = 9086;
//carInsurance.PremiumAmount = 60000;
//carInsurance.CustomerName = "shirin";
//carInsurance.VehicleType = "scooter";
//carInsurance.KilometerUsed = 9000;
//Console.WriteLine("Sanctioned amount: {0}", lifeInsurance.CalculatePermium());

//26-10-2023

//Customer customer = new(249213, "Gokul",735674989, 498);
//Customer customer2 = new(4567, "shirin", 679856347, 66);
//Customer customer3 = new(8976, "vishnu", 897653726, 121);
//Customer.CustomerList.Add(customer);
//Customer.CustomerList.Add(customer2);
//Customer.CustomerList.Add(customer3);
//Customer.GetCustomerByPhoneNumber(735674989);
//Customer.DisplayAllCustomer();
//Customer.GetCustomerByPhoneNumber(98767);

//CallRecords callRecordOne = new(567, 7356749899, 8.5);
//CallRecords callRecordTwo = new(987, 7356749899, 9.8);
//CallRecords callRecordThree = new(786, 9895302408, 7.24);
//CallRecords callRecordFour = new(786, 9895302408, 6.7);
//CallRecords.CallRecordsList.Add(callRecordOne);
//CallRecords.CallRecordsList.Add(callRecordTwo);
//CallRecords.CallRecordsList.Add((callRecordThree));
//CallRecords.CallRecordsList.Add((callRecordFour));
//CallRecords.GetCallRecord(7356749899);
//CallRecords.GetAllCallCountByPhoneNumber();
//try
//{
//    Patient.AddPatients(8765, "gokul", 24, "fever");
//    Patient.AddPatients(9088, "", 45, "fever");
//}
//catch(CustomException ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Patient.Display();

//27-10-2023


//MedicalRecord medicalRecord = new MedicalRecord(123,"gokul",30,"fever",12,100);

//try
//{
//    MedicalRecord.AddMedicalRecord(medicalRecord);
//}
//catch (CustomException ex)
//{
//    Console.Write(ex.Message);
//}
//int n = 1;
//while (n == 1)
//{
//    Console.WriteLine("1.Add Medical Record 2.View Medical Record Details 3.Search patient");
//    int choice = Convert.ToInt32(Console.ReadLine());
//    switch (choice)
//    {
//        case 1:
//            Console.WriteLine("Enter the Reord id:");
//            int recordId = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Patient id:");
//            int patientid = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter the Description:");
//            string description = Console.ReadLine();
//            Console.WriteLine("Enter the Time:");
//            double Time = Convert.ToDouble(Console.ReadLine());
//            MedicalHistory medicalHistory=new(recordId,patientid, description, Time);
//            MedicalHistory.AddMedicalRecord(medicalHistory);
//            medicalHistory.WriteMedicalRecordDetailsToFile();
//            break;
//        case 2:
//            MedicalHistory.DisplayMedicalHistoryDetailsFromFile();
//            break;
//        case 3:
//            Console.WriteLine("Enter the Patient id");
//            string patientId=Console.ReadLine();
//            MedicalHistory.GetPatientFromFile(patientId);
//            break;
//    }
//    Console.WriteLine("Press 1 to contine");
//    choice = Convert.ToInt32(Console.ReadLine());
//}

//30-10-2023
//Console.WriteLine("Enter the Room number:");
//int roomNumber=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter the Room Type");
//string roomType=Console.ReadLine();
//Console.Write("Enter the Room Status");
//bool status=Convert.ToBoolean(Console.ReadLine());
//HotelRoom room = new(roomNumber,roomType,status);
//RoomReservation<HotelRoom> reservation = new RoomReservation<HotelRoom>();
//reservation.BookRoom(room);
//Console.WriteLine("Enter the room number to Cancel booking");
//int cnumber=Convert.ToInt32(Console.ReadLine());
//HotelRoom isRoom=RoomReservation<HotelRoom>.HotelRooms.Find(x=>x.RoomNumber== cnumber);
//reservation.CancelBooking(isRoom);

//31-10-2023
class Program
{
    public delegate double DelegateOne(EmployeeNew employee);
    public delegate string DelegateTwo(string msg);
    public static void Main(string[] args)
    {
        EmployeeNew employee = new(12, "gokul", 4);
        EmployeeNew employeeTwo = new(13, "vishnu", 2);
        DelegateOne del = EmployeeNew.BonusCalculation;
        DelegateOne del2 = EmployeeNew.BonusCalculationAccount;
        Console.WriteLine(del(employee));
        Console.WriteLine(del2(employeeTwo));
        HotelEvent hotelEvent = new("Foundation Day", "23-10-2023", "UST", 7000);
        DelegateTwo del3 = HotelEvent.SentNotification;
        if(hotelEvent!=null)

        {
            Console.WriteLine(del3("Event Registered Successfully"));
        }
        else
        {
            Console.WriteLine(del3("Event Not Registered Successfully"));
        }
       
    }
}

