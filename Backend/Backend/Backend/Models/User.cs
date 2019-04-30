    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
        public string Nick { get; set; }
        public Team Team { get; set; }
       

    }
}
