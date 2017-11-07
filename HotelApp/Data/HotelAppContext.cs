using Microsoft.EntityFrameworkCore;
using HotelApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace HotelApp.Data
{
    public class HotelAppContext : IdentityDbContext<ApplicationUser>
    {
        public HotelAppContext (DbContextOptions<HotelAppContext> options)
            : base(options)
        {
        }

        public DbSet<HotelApp.Models.Room> Room { get; set; }

        public DbSet<HotelApp.Models.Booking> Booking { get; set; }
    }
}
