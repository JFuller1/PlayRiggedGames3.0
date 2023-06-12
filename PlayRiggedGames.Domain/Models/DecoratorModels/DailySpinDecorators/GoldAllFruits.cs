using PlayRiggedGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models.DecoratorModels.LuckySlotsDecorators
{
    public class GoldAllFruits : SlotMachineDecorator
    {
        public GoldAllFruits(SlotMachine slotMachine)
        {
            SlotMachine = slotMachine;
        }

        public override List<SlotRowWin> CheckRowForWins(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols)
        {
            SlotRowWin? slotRowWin = CheckSpecialWin(row, new List<string> { "goldbanana", "goldcherry", "goldgrapes", "goldlemon", "goldmelon", "goldorange", "goldstrawberry" }, "All fruits!", 500, true);

            if(slotRowWin != null)
            {
                return SlotMachine.CheckRowForWins(row, symbols).Append(slotRowWin).ToList();
            }
            return SlotMachine.CheckRowForWins(row, symbols);
        }
    }
}
