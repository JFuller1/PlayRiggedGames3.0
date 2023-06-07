using Microsoft.AspNetCore.Identity;
using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.ViewModels
{
    public class Admin_Users_ViewModel
    {
        public ApplicationUser User { get; set; }
        public IdentityRole Role { get; set; }
    }
}
