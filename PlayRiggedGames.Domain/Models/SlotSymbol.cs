using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models
{
    public class SlotSymbol
    {
        // Self prop
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; } 

        // FK 
        public int SlotMachineId { get; set; }
        
        // Nav
        public virtual SlotMachine SlotMachine { get; set; }
    }
}
