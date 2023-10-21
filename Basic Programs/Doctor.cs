using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Doctor:IDoctor,IAppointment
    {
        public int Did { get; set; }

        public string? DName { get; set; }

        public void AddNewDoctor()
        {
            Did = 1;
            DName = "Gokul";
        }
       

        public void ModifyDoctor()
        {
            Did = 9878;
            DName = "shirin";
        }

        public  void DisplayDoctorDetails()
        {
            Console.WriteLine("Did : {0} \nDName: {1}",Did,DName);
        }

        public void BookAppointment(int doctorId, string patientName)
        {
            Console.WriteLine("Appointment Booked for {0} with doctor {1}",patientName,doctorId);
        }

        public void DeleteAppointment(string patientName)
        {
            Console.WriteLine("Appointent Deleted for {0}",patientName);
        }
    }
}
