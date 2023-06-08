using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Models;
using PlayRiggedGames.Service.Controllers;
using PlayRiggedGames.Service;
using Newtonsoft.Json;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace PlayRiggedGames.Controllers
{
    [Authorize]
    public class SlotsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRiggedService _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public SlotsController(ILogger<HomeController> logger, IRiggedService service, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _service = service;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LuckySlots()
        {
            return View();
        }

        public IActionResult DailySpin()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GenerateSlotSymbols(int machineId, string selectedRows)
        {
            SlotMachine machine = _service.GetSlotMachineById(machineId);

            int totalSymbols = machine.Height * machine.Width;

            List<SlotSymbol> symbols = _service.GetAllSlotSymbols().Where(s => s.SlotMachineId == machine.Id).ToList();
            int totalWeight = symbols.Sum(s => s.Weight);

            string[] result = new string[totalSymbols];

            ApplicationUser user = GetLoggedInUser();


            if (machine.Id == 2)
            {
                if (!CanUserSpinDaily(user))
                {
                    return Json("");
                }
            }

            for (int i = 0; i < totalSymbols; i++)
            {
                int chosenSym = new Random().Next(1, totalWeight + 1);
                int curWeight = 0;
                int j = 0;
                while(curWeight < chosenSym)
                {
                    curWeight += symbols[j].Weight;
                    if(curWeight >= chosenSym)
                    {
                        result[i] = symbols[j].Name;
                        j = 0;
                        break;
                    } 
                    else
                    {
                        j++;
                    }
                }
            }

            List<int> paidRowIndexes = System.Text.Json.JsonSerializer.Deserialize<List<int>>(selectedRows);

            user.Money -= (machine.Cost * paidRowIndexes.Count);
            _service.UpdateUser(user);

            Dictionary<int, List<string>> paidRows = new Dictionary<int, List<string>>();
            List<string> resultList = result.ToList();

            foreach(int rowIndex in paidRowIndexes)
            {
                List<string> row = resultList.GetRange(rowIndex * machine.Width, machine.Width);
                paidRows.Add(rowIndex, row);
            }



            List<SlotRowWin> wins = new List<SlotRowWin>();

            foreach(KeyValuePair<int, List<string>> kvp in paidRows)
            {
                wins.AddRange(CheckRowForWins(kvp, symbols, machine.Name));
            }

            int pay = 0;

            if (wins.Count > 0)
            {
                pay = (int)Math.Floor(wins.Sum(w => w.Payout));

                user.Money += pay;
                _service.UpdateUser(user);
            }

            SlotGameLog log = new SlotGameLog(machine.Cost * paidRowIndexes.Count, pay, DateTime.Now, false, user.Id);
            _service.CreateSlotGameLog(log);

            for(int i = 0; i < resultList.Count(); i++)
            {
                SlotOutcome outcome = new SlotOutcome(i, _service.GetSlotSymbolIdByName(result[i]), machine.Id, log.Id);
                _service.CreateSlotOutcome(outcome);
            }

            return Json(JsonConvert.SerializeObject(new
            {
                wins = wins,
                result = resultList,
                pay = pay
            }));
        }

        public List<SlotRowWin> CheckRowForWins(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols, string machineName)
        {
            List<SlotRowWin> wins = new List<SlotRowWin>();

            //check for generic wins

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
                switch(kvp.Value)
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

            switch (machineName)
            {
                case "LuckySlots":
                    SlotRowWin? allFruits = CheckUniqueCombination(row, new List<string> { "banana", "cherry", "grapes", "lemon", "melon", "orange", "strawberry" }, "All fruits!", 50, true);
                    if (allFruits != null) wins.Add(allFruits);
                    SlotRowWin? luckItems = CheckUniqueCombination(row, new List<string> { "chip", "dice", "horseshoe", "clover" }, "Lucky!", 400, false);
                    if (luckItems != null) wins.Add(luckItems);
                    SlotRowWin? cardSuits = CheckUniqueCombination(row, new List<string> { "diamond", "heart", "club", "spade" }, "All Suits!", 250, false);
                    if (cardSuits != null) wins.Add(cardSuits);
                    SlotRowWin? valuables = CheckUniqueCombination(row, new List<string> { "coin", "crown", "emerald" }, "Riches!", 1000, false);
                    if (valuables != null) wins.Add(valuables);
                    break;
                case "DailySpin":
                    SlotRowWin? goldAllFruits = CheckUniqueCombination(row, new List<string> { "goldbanana", "goldcherry", "goldgrapes", "goldlemon", "goldmelon", "goldorange", "goldstrawberry" }, "All fruits!", 500, true);
                    if (goldAllFruits != null) wins.Add(goldAllFruits);
                    SlotRowWin? goldLuckItems = CheckUniqueCombination(row, new List<string> { "goldchip", "golddice", "goldhorseshoe", "goldclover" }, "Lucky!", 400, false);
                    if (goldLuckItems != null) wins.Add(goldLuckItems);
                    SlotRowWin? goldCardSuits = CheckUniqueCombination(row, new List<string> { "golddiamond", "goldheart", "goldclub", "goldspade" }, "All Suits!", 500, false);
                    if (goldCardSuits != null) wins.Add(goldCardSuits);
                    SlotRowWin? goldValuables = CheckUniqueCombination(row, new List<string> { "goldcoin", "goldcrown", "goldemerald" }, "Riches!", 1000, false);
                    if (goldValuables != null) wins.Add(goldValuables);
                    break;
            }

            foreach (SlotRowWin swin in wins)
            {
                Console.WriteLine($"\nmessage: {swin.Message}\npayout: ${swin.Payout}\nindex: {swin.Index}\nsymbol: {swin.Symbol}");
            }

            return wins;
        }

        public SlotRowWin? CheckUniqueCombination(KeyValuePair<int, List<string>> row, List<string> combination, string message, float pay, bool all)
        {
            if(!all)
            {
                if(combination.Intersect(row.Value).Count() == combination.Count())
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
                if(row.Value.All(s => combination.Contains(s)))
                {
                    return new SlotRowWin(message, null, pay, true, row.Key);
                }
                else
                {
                    return null;
                }
            }
        }

        private ApplicationUser GetLoggedInUser()
        {
            // gets the id of the currently logged in user
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _service.GetUserById(userId);
        }

        public bool CanUserSpinDaily(ApplicationUser user)
        {
            // last daily spin time is longer or equal to 24 hours ago when
            // compared to the user creation date
            List<SlotGameLog> dailySpinGameLogs = _service.GetAllSlotGameLogsByMachineId(2).ToList();

            if (dailySpinGameLogs.Count != 0)
            {
                SlotGameLog latestSpinOnDailySlots = dailySpinGameLogs.OrderByDescending(gameLog => gameLog.Time).First();

                //Console.WriteLine((DateTime.Now - latestSpinOnDailySlots.Time).TotalHours);

                return (DateTime.Now - latestSpinOnDailySlots.Time).TotalHours >= 24;
            } else
            {
                // has not spun the daily spin machine yet
                return true;
            }
        }
    }
}