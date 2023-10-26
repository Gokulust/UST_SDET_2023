using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecords
    {
        public CallRecords(int callId, long phoneNumber, double callTime)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int CallId { get; set; }
        public long PhoneNumber { get; set; }
        public double CallTime { get; set; }

        public static List<CallRecords> CallRecordsList= new List<CallRecords>();

        public static void GetCallRecord(long phoneNumber)
        {
            var records= CallRecordsList.FindAll(x => x.PhoneNumber == phoneNumber);
            if (records != null)
            {
                foreach (var record in records)
                {
                    Console.WriteLine("Call Id :{0} Call Time:{1}", record.CallId, record.CallTime);
                }
                
            }
            else
            {
                Console.WriteLine("Call Record Not Found");
            }
        }

        public static void GetAllCallCountByPhoneNumber()
        {
            Dictionary<double,int>CallDictionary= new Dictionary<double,int>();
            foreach(var record in CallRecordsList)
            {
                 if(CallDictionary.ContainsKey(record.PhoneNumber))
                {
                    CallDictionary[record.PhoneNumber]++;
                }
                else
                {
                    CallDictionary.Add(record.PhoneNumber, 1);
                }
            }
            foreach(var record in CallDictionary)
            {
                Console.WriteLine("Count For {0} : {1}",record.Key, record.Value);
            }

        }

    }
}
