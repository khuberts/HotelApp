using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }

        public string Description { get; set; }
    }
}
