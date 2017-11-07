using Microsoft.EntityFrameworkCore;
using HotelApp.Models;

namespace HotelApp.Data
{
    public class HotelAppContext : DbContext
    {
        public HotelAppContext (DbContextOptions<HotelAppContext> options)
            : base(options)
        {
        }

        public DbSet<HotelApp.Models.Room> Room { get; set; }

        public DbSet<HotelApp.Models.Guest> Guest { get; set; }
    }
}
