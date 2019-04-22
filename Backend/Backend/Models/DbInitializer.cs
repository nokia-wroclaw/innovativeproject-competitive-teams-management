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
                context.Users.AddRange
                    (
                        new User { FirstName = "Jan", LastName = "Kowalski"},
                        new User { FirstName = "Karol", LastName = "Nowak" },
                        new User { FirstName = "Jarosław", LastName = "Psikuta" }
                    );

            }

            if (!context.Teams.Any())
            {
                /*
                var special = new Team()//initializing Team with user
               {
                   Name = "Dziki z Nokii",
                   TeamMembers.Add() //= new List<User>()
                   //{
                       //TeamMembers = new List<User> { new User {FirstName = "Maciej",LastName="Cukierek"
                   //}
               };

               context.Teams.Add(special);
               */
                context.Teams.Add(
                 new Team
                 {
                     Name = "dziki z Nokii",
                     //TeamMembers = new List<User>(),// (new User() { FirstName = "Dzialaj", LastName="Prosze" }) //= new List<User>()
                     Users = new List<User>
                     {
                         new User{FirstName="Janek", LastName="Dzialacz"}
                     }

                 }
                );
                
                //context.SaveChanges();
                /*
                context.AddRange
                (
                    //new Team { Name = "Dziki z Nokii"},
                    new Team { Name = "Dzikiii z Nokii", TeamMembers = new List<User> { new User {FirstName = "Maciej",LastName="Cukierek" } }  },
                    new Team { Name = "Nie W4rto"}
                );
                */
            }

            context.SaveChanges();
        }
    }
}
