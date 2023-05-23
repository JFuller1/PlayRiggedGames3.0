using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models
{
    public class SlotOutcome
    {
        // Self prop
        public int Location { get; set; }

        // FK
        public int SymbolId { get; set; }
        public int SlotMachineId { get; set; }
        public int GameId { get; set; }
        

        // Nav
        public virtual SlotSymbol Symbol { get; set; }
        public virtual SlotGameLog Game { get; set; }
    }
}
