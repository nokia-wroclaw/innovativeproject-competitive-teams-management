using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                        new User { FirstName = "Jan", LastName = "Kowalski", Nick="Pingwin"},
                        new User { FirstName = "Karol", LastName = "Nowak",Nick="Nowy" },
                        new User { FirstName = "Jarosław", LastName = "Psikuta", Nick="Mistrz" }
                    );

            }

            if (!context.Teams.Any())
            {
                context.AddRange
                (
                    //new Team {Name = "Dziki z Nokii", Users = new User() {FirstName= "Frodo", LastName="Baggins",Nick="Powiernik" } },
                    //new Team { Name = "Nie W4rto", Users = new List<User>() }
                );

            }

            context.SaveChanges();
        }
    }
}
