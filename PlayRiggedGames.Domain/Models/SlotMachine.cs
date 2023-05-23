using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models
{
    public class SlotMachine
    {
        // Self prop
        public int Id { get; set; } 
        public int Width { get; set; }
        public int Height { get; set; }
        public string Name { get; set; }
        public bool OutOfOrder { get; set; } = false;
        
        // Nav
        public virtual IEnumerable<SlotSymbol> Values { get; set; }
    }
}
