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
using PlayRiggedGames.Domain.Models.DecoratorModels.LuckySlotsDecorators;

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
                wins.AddRange(AssignWinTypesToMachines(kvp, symbols, machine));
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

        public List<SlotRowWin> AssignWinTypesToMachines(KeyValuePair<int, List<string>> row, List<SlotSymbol> symbols, SlotMachine machine)
        {
            switch (machine.Name)
            {
                case "LuckySlots":
                    machine = new AllFruits(machine);
                    machine = new CardSuits(machine);
                    machine = new LuckItems(machine);
                    machine = new Valuables(machine);
                    break;
                case "DailySpin":
                    machine = new GoldAllFruits(machine);
                    machine = new GoldCardSuits(machine);
                    machine = new GoldLuckItems(machine);
                    machine = new GoldValuables(machine);
                    break;
            }

            return machine.CheckRowForWins(row, symbols);
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