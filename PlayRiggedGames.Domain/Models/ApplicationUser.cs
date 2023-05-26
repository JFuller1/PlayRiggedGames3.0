using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Self prop
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Money { get; set; } = 100;
        public DateTime Birthday { get; set; } = DateTime.Now;
        public bool BlackListed { get; set; } = false;
    }
}
