using PlayRiggedGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models.DecoratorModels.LuckySlotsDecorators
{
    public class GoldCardSuits : SlotMachineDecorator
    {
        public GoldCardSuits(SlotMachine slotMachine)
        {
            SlotMachine = slotMachine;
        }

        public override List<SlotRowWin> CheckRowForWins(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols)
        {
            SlotRowWin? slotRowWin = CheckSpecialWin(row, new List<string> { "golddiamond", "goldheart", "goldclub", "goldspade" }, "All Suits!", 500, false);

            if (slotRowWin != null)
            {
                return SlotMachine.CheckRowForWins(row, symbols).Append(slotRowWin).ToList();
            }
            return SlotMachine.CheckRowForWins(row, symbols);
        }
    }
}
