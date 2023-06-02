using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.ViewModels
{
    public class Admin_SlotMachine_ViewModel
    {
        // To view
        public SlotMachine SlotMachine { get; set; }
        public List<SlotSymbol> SlotSymbols { get; set; }

        // To get
        public int SlotMachineId { get; set; }
        public bool IsNowOutofOrder { get; set; }
    }
}
