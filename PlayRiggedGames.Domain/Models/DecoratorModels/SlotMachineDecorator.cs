using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models.DecoratorModels
{
    public abstract class SlotMachineDecorator : SlotMachine
    {
        protected SlotMachine SlotMachine { get; set; }
    }
}
