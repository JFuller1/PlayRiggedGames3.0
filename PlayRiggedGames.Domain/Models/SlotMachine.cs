using PlayRiggedGames.Models;
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
        public int Cost { get; set; }
        public List<SlotRowWin> CurWins { get; set; } = new List<SlotRowWin>();

        // Nav
        public virtual IEnumerable<SlotSymbol> Values { get; set; }

        public virtual List<SlotRowWin> CheckRowForWins(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols)
        {
            List<SlotRowWin> wins = new List<SlotRowWin>();

            wins.AddRange(CheckGenericWin(row, symbols));

            return wins;
        }

        public List<SlotRowWin> CheckGenericWin(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols)
        {
            List<SlotRowWin> wins = new List<SlotRowWin>();

            Dictionary<string, int> slotOccurence = new Dictionary<string, int>();

            foreach (string s in row.Value)
            {
                slotOccurence.TryAdd(s, 0);
                slotOccurence[s]++;
            }

            foreach (KeyValuePair<string, int> kvp in slotOccurence.Where(s => s.Value >= 3))
            {
                float svalue = symbols.FirstOrDefault(s => s.Name == kvp.Key).Value;
                float pay = 0;
                switch (kvp.Value)
                {
                    case 3:
                        pay = svalue;
                        break;
                    case 4:
                        pay = svalue * 1.5f;
                        break;
                    case 5:
                        pay = svalue * 2.5f;
                        break;
                    case 6:
                        pay = svalue * 10;
                        break;
                    case 7:
                        pay = svalue * 25;
                        break;
                }
                wins.Add(new SlotRowWin($"{kvp.Value}x {kvp.Key}", kvp.Key, pay, false, row.Key));
            }

            return wins;
        }

        public SlotRowWin? CheckSpecialWin(KeyValuePair<int, List<string>> row, List<string> combination, string message, float pay, bool all)
        {
            if (!all)
            {
                if (combination.Intersect(row.Value).Count() == combination.Count())
                {
                    return new SlotRowWin(message, null, pay, true, row.Key);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (row.Value.All(s => combination.Contains(s)))
                {
                    return new SlotRowWin(message, null, pay, true, row.Key);
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
