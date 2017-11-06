using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HotelApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HotelAppContext(
                serviceProvider.GetRequiredService<DbContextOptions<HotelAppContext>>()))
            {
                // Look for any movies.
                if (context.Room.Any())
                {
                    return; // DB has been seeded
                }

                context.Room.AddRange(
                    new Room
                    {
                        RoomNumber = "1",
                        Description = "Basis Kamer"
                    },

                    new Room
                    {
                        RoomNumber = "2",
                        Description = "Basis Kamer"
                    },

                    new Room
                    {
                        RoomNumber = "3",
                        Description = "Luxe Kamer"
                    },

                    new Room
                    {
                        RoomNumber = "4",
                        Description = "Luxe Kamer"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
