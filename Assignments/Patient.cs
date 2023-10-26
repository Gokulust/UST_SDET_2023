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

        public static void  AddPatients(int patientId,string patientName,int age,string diagonsis)
        {
            if(!(age>0 && age<120))
            {
                throw new CustomException("Age must be between 1 and 119");
            }
            if(String.IsNullOrEmpty(patientName))
            {
                throw new CustomException("patient Name cannot be null or empty");
            }
            if(String.IsNullOrEmpty(diagonsis))
            {
                throw new CustomException("diagonsis cannot be null or empty");
            }
            Patient patient = new Patient();
            patient.PatientId = patientId;
            patient.PatientName = patientName;
            patient.Age = age;
            patient.Diagonsis = diagonsis;
            PatientList.Add(patient);


        }
        public static void Display()
        {
            foreach(Patient patient in PatientList)
            {
                Console.WriteLine("Patient Name:{0} Patient Age :{1} Diagonsis:{2}", patient.PatientName, patient.Age, patient.Diagonsis);
            }
        }
    }
}
