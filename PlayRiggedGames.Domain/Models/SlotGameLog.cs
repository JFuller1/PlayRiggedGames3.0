using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models
{
    public class SlotGameLog
    {
        // Self prop
        public int Id { get; set; }
        public int MoneyInput { get; set; }
        public int MoneyOutput { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public bool Jackpot { get; set; } 

        // FK
        public string PlayerId { get; set;}

        // Nav
        public virtual ApplicationUser Player { get; set; }
        public virtual IEnumerable<SlotOutcome> SlotOutcomes { get; set; }
    } 
}
