using System;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Booking
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }
        [Display(Name = "Guest Name")]
        public int GuestId { get; set; }
        public Guest Guest { get; set; }
        [Display(Name = "Room Number")]
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
