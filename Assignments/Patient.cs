using Assignments.ExceptionMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Patient
    {
       
        public int PatientId {  get; set; }
        public string? PatientName { get; set;}
        public int Age { get; set; }

        public string? Diagonsis { get; set; }

        public static List<Patient> PatientList = new List<Patient>();

        public Patient(int patientId, string? patientName, int age, string? diagonsis)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagonsis = diagonsis;
        }

        public static void  AddPatients(Patient p)
        {
            if(!(p.Age>0 && p.Age<120))
            {
                throw new CustomException("Age must be between 1 and 119");
            }
            if(String.IsNullOrEmpty(p.PatientName))
            {
                throw new CustomException("patient Name cannot be null or empty");
            }
            if(String.IsNullOrEmpty(p.Diagonsis))
            {
                throw new CustomException("diagonsis cannot be null or empty");
            }
           
            PatientList.Add(p);


        }
        public void WritePatientDetailsToFile()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\FileOperations\\PatientRecord\\PatientDetails.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("Patient Id: {0} Patient Name: {1} Patient Age :{2} Diagonsis :{3}", PatientId, PatientName, Age, Diagonsis);
            writer.Close();
            fileStream.Close();
        }
        public static void Display()
        {
            foreach(Patient patient in PatientList)
            {
                Console.WriteLine("Patient Name:{0} Patient Age :{1} Diagonsis:{2}", patient.PatientName, patient.Age, patient.Diagonsis);
            }
        }
        public static void DisplayPatientDetailsFromFile()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\FileOperations\\PatientRecord\\PatientDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string str=streamReader.ReadToEnd();
            Console.WriteLine(str);
            streamReader.Close();
            
            
        }
    }
}
