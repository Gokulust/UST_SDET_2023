using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class RoomReservation<T>
    {
        public static List<T> HotelRooms = new List<T>();
        public void BookRoom(T room)
        {
           HotelRooms.Add(room);
        }
        public void CancelBooking(T room)
        {
            HotelRooms.Remove(room);
        }
    }
}
