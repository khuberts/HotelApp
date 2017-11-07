using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int GuestId { get; set; }
        public Guest Guest { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
