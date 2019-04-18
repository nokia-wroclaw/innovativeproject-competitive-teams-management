using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Services;

namespace Backend.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.AddRange
                    (
                        new User { FirstName = "Jan", LastName = "Kowalski"},
                        new User { FirstName = "Karol", LastName = "Nowak" },
                        new User { FirstName = "Jarosław", LastName = "Psikuta" }
                    );

            }

            if (!context.Teams.Any())
            {
                context.AddRange
                (
                    new Team { Name = "Dziki z Nokii"},
            
                    new Team { Name = "Nie W4rto"}
                );

            }

            context.SaveChanges();
        }
    }
}
