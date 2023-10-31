using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class HotelEvent
    {
        public HotelEvent(string? eventName, string? eventDtae, string? eventLocation, int capacity)
        {
            EventName = eventName;
            EventDtae = eventDtae;
            EventLocation = eventLocation;
            Capacity = capacity;
        }

        public string? EventName { get; set; }
        public string? EventDtae { get; set; }

        public string? EventLocation { get; set; }

        public int Capacity { get; set; }

        public  static string SentNotification(string msg)
        {
            return msg;
        }
    }
}
