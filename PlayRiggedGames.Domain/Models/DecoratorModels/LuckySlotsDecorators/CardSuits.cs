using PlayRiggedGames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Domain.Models.DecoratorModels.LuckySlotsDecorators
{
    public class CardSuits : SlotMachineDecorator
    {
        public CardSuits(SlotMachine slotMachine)
        {
            SlotMachine = slotMachine;
        }

        public override List<SlotRowWin> CheckRowForWins(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols)
        {
            SlotRowWin? slotRowWin = CheckSpecialWin(row, new List<string> { "diamond", "heart", "club", "spade" }, "All Suits!", 250, false);

            if (slotRowWin != null)
            {
                return SlotMachine.CheckRowForWins(row, symbols).Append(slotRowWin).ToList();
            }
            return SlotMachine.CheckRowForWins(row, symbols);
        }
    }
}
