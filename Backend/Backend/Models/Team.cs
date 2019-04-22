using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public List<User> Users { get; set; } = new List<User>();// = new List<User>();

    }
}
