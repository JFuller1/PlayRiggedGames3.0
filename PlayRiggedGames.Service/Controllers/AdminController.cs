using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.Controllers
{
    // [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // ensure to use the INTERFACE not the HARDCODED stuff when injecting
        private readonly IRiggedService _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(ILogger<HomeController> logger, IRiggedService service, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _service = service;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            // should contain links to other pages
            return View();
        }

        public IActionResult Users()
        {
            List<Admin_Users_ViewModel> returning = new();

            foreach(ApplicationUser user in _service.GetAllUsers())
            {

            }

            return View();
        }

        //
        // Slot Machine related
        //
        public IActionResult SlotMachines()
        {
            return View(_service.GetAllSlotMachines());
        }

        public IActionResult SlotMachine(int slotMachineId) 
        {
            // admin only change money input amount
            // view should have simple if statement to check if model null or not
            return View(_service.GetSlotMachineById(slotMachineId));
        }

        //
        // Slot Symbol related
        //
        public IActionResult SlotSymbols(int slotMachineId)
        {
            return View(_service.GetSlotSymbolBySlotMachineId(slotMachineId));
        }

        public IActionResult SlotSymbol(int slotSymbolId)
        {
            // admin only change value and weight
            // view should have simple if statement to check if model null or not
            return View(_service.GetSlotSymbolById(slotSymbolId));
        }
    }
}
