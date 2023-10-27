using Assignments.ExceptionMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class MedicalRecord:Patient
    {
        public int RecordId {  get; set; }
        public int TotalCost {  get; set; }
         public static List<MedicalRecord> MedicalRecordList= new List<MedicalRecord>();

        public MedicalRecord(int patientId, string? patientName, int age, string? diagonsis,int recordId,int totalCost) : base(patientId, patientName, age, diagonsis)
        {
            RecordId = recordId;
            TotalCost = totalCost;
        }

        public static void AddMedicalRecord(MedicalRecord medicalRecord)
        {
            
            if(String.IsNullOrEmpty(medicalRecord.PatientName))
            {
                throw new CustomException("Patient Name cannot null or empty");
            }
            if(String.IsNullOrEmpty(medicalRecord.Diagonsis))
            {
                throw new CustomException("Diagonsis cannot null or empty");
            }
            if(medicalRecord.TotalCost<0)
            {
                throw new CustomException("Total cost cannot be negative");
            }
            MedicalRecordList.Add(medicalRecord);

        }

    }
}
