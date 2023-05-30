﻿using Microsoft.AspNetCore.Identity;
using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.ViewModels
{
    public class Admin_User_ViewModel
    {
        // To view
        public ApplicationUser User { get; set; }
        public IdentityRole Role { get; set; }

        public List<IdentityRole> AllRoles { get; set; }

        // To grab
        public IdentityRole NewRole { get; set; }
        public bool NowBlacklist { get; set; }
    }
}
