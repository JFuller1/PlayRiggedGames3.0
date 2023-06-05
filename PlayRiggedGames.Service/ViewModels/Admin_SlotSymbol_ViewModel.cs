using PlayRiggedGames.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.ViewModels
{
    public class Admin_SlotSymbol_ViewModel
    {
        // To view
        public SlotSymbol SlotSymbol { get; set; }
        public SlotMachine SlotMachine { get; set; }
        
        // To grab
        public int SlotSymbolId { get; set; }
        public int NewWeight { get; set; }
        public int NewValue { get; set;}
    }
}
