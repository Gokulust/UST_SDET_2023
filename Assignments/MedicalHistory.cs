using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalHistory
    {
        public MedicalHistory(int recordId, int patientId, string? description, double time)
        {
            RecordId = recordId;
            PatientId = patientId;
            Description = description;
            Time = time;
        }

        public int RecordId { get; set; }
        public int PatientId {  get; set; }
        public string? Description {  get; set; }

        public double Time { get; set; }
        public static List<MedicalHistory> MedicalHistoryList = new List<MedicalHistory>();

        public static void AddMedicalRecord(MedicalHistory record)
        {
            MedicalHistoryList.Add(record);
        }
        public void WriteMedicalRecordDetailsToFile()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\FileOperations\\PatientRecord\\MedicalRecordDetails.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            writer.WriteLine("Record Id: {0} Patient Id: {1} Description :{2} Time :{3}", RecordId, PatientId, Description, Time);
            writer.Close();
            fileStream.Close();
        }
        public static void DisplayMedicalHistoryDetailsFromFile()
        {
            FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Desktop\\FileOperations\\PatientRecord\\MedicalRecordDetails.txt", FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string str = streamReader.ReadToEnd();
            Console.WriteLine(str);
            streamReader.Close();


        }


    }
}
