using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel:TourismDestination
    {
        public Hotel(string? name, string? country, int rating, double pricePerNight, string HotelRoomName,int availableRoom) : base(name, country, rating, pricePerNight)
        {
            AvilableRoom = availableRoom;
            Name= HotelRoomName;
        }

        public string? Name { get; set; }
         public int AvilableRoom {  get; set; }

        public async Task<bool> HotelBooking(int numberOfHotelRoom)
        {
            if(numberOfHotelRoom <= 0)
            {
                Console.WriteLine("invalid request");
            }
            if(numberOfHotelRoom<=AvilableRoom)
            {
                Console.WriteLine("Availabe Rooms:{0}", AvilableRoom);
                ReduceRoomNumber(numberOfHotelRoom);
                Console.WriteLine("Booking Confiremd Remaining Rooms:{0}", AvilableRoom);
                return true;
            }
            else
            {
                Console.WriteLine("Not Enough Rooms Availabe Available Rooms:{0}",AvilableRoom);
                return false;
            }
        }
        public void ReduceRoomNumber(int roomNumber)
        {
            AvilableRoom=AvilableRoom-roomNumber;
        }

    }
}
