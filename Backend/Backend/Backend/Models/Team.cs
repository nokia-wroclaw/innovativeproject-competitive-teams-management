using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();

    }
}
