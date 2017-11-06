using Microsoft.EntityFrameworkCore;

namespace HotelApp.Data
{
    public class HotelAppContext : DbContext
    {
        public HotelAppContext (DbContextOptions<HotelAppContext> options)
            : base(options)
        {
        }

        public DbSet<HotelApp.Models.Room> Room { get; set; }
    }
}
