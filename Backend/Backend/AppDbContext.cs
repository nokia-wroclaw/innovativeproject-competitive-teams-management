﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Backend.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }//enabling to use Add,Delete,Edit functions

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
               
        }
       



    }
}
