using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.ViewModels
{
    public class Admin_SlotGameLog_ViewModel
    {
        // To View
        public SlotGameLog SlotGameLog { get; set; }
        public ApplicationUser Player { get; set; }
        public SlotMachine SlotMachine { get; set; }
        public Dictionary<int, SlotSymbol> SlotOutcomes { get; set; }
    }
}
