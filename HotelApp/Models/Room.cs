using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HotelApp.Models.Enums;

namespace HotelApp.Models
{
    public class Room
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        public string RoomNumber { get; set; }

        public string Description { get; set; }

        [Required]
        public RoomType RoomType { get; set; }

        [Required]
        public RoomSize RoomSize { get; set; }
        
        [NotMapped]
        public string RoomDescription => $"{RoomNumber}: {Description} - {RoomType} - {RoomSize}";
    }
}
