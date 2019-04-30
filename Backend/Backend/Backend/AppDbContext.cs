using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class AppDbContext : DbContext
    {
     

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>()
            //    .HasOne<Team>(s => s.Team)
            //    .WithMany(g => g.Users);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
