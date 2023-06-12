using PlayRiggedGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models.DecoratorModels.LuckySlotsDecorators
{
    public class Valuables : SlotMachineDecorator
    {
        public Valuables(SlotMachine slotMachine)
        {
            SlotMachine = slotMachine;
        }

        public override List<SlotRowWin> CheckRowForWins(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols)
        {
            SlotRowWin? slotRowWin = CheckSpecialWin(row, new List<string> { "chip", "dice", "horseshoe", "clover" }, "Lucky!", 400, false);

            if (slotRowWin != null)
            {
                return SlotMachine.CheckRowForWins(row, symbols).Append(slotRowWin).ToList();
            }
            return SlotMachine.CheckRowForWins(row, symbols);
        }
    }
}
