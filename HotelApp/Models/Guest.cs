using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
