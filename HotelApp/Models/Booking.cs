using System;
using System.ComponentModel.DataAnnotations;

namespace HotelApp.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        public string ApplicationUserId { get; set; }
        
        [Required]
        public ApplicationUser ApplicationUser { get; set; }
        
        [Display(Name = "Room Number")]
        public int RoomId { get; set; }

        [Required]
        public Room Room { get; set; }
    }
}
