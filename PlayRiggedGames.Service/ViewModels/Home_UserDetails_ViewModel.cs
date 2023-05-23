using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.ViewModels
{
    public class Home_UserDetails_ViewModel
    {
        public ApplicationUser User { get; set; }
        public List<SlotGameLog> SlotGameLogs { get; set; } = new List<SlotGameLog>();
        public List<SlotMachine> SlotMachines { get; set; }

        public Home_UserDetails_ViewModel(ApplicationUser user, List<SlotGameLog> logs, List<SlotMachine> slots)
        {
            User = user;
            SlotGameLogs = logs;
            SlotMachines = slots;
        }
    }
}
