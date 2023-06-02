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

        //
        // User related
        //
        public IActionResult Users()
        {
            List<Admin_Users_ViewModel> returning = new();

            foreach(ApplicationUser user in _service.GetAllUsers())
            {
                returning.Add(new Admin_Users_ViewModel()
                {
                    User = user,
                    Role = _service.GetIdentityRoleByUser(user)
                });
            }

            return View(returning);
        }

        public IActionResult User(string id)
        {
            ApplicationUser selectedUser = _service.GetUserById(id);

            Admin_User_ViewModel returning = new()
            {
                User = selectedUser,
                Role = _service.GetIdentityRoleByUser(selectedUser),
                AllRoles = _service.GetAllIdentityRoles().ToList()
            };

            return View(returning);
        }

        [HttpPost] 
        public IActionResult User(Admin_User_ViewModel vm)
        {
            // grabbing input values
            ApplicationUser selectedUser = _service.GetUserById(vm.UserId);
            IdentityRole newRole = _service.GetIdentityRoleById(vm.NewRoleId);

            // check if newRole, blacklisted is different from user info
            // if different change values
            // then return to User
            if (newRole != _service.GetIdentityRoleByUser(selectedUser))
            {
                // given role does not match
                // need to change value
                _service.UpdateIdentityUserRole(selectedUser, newRole);
            }
            if (vm.NowBlacklist != selectedUser.BlackListed)
            {
                // blacklist has been toggled 
                // need to change value
                selectedUser.BlackListed = vm.NowBlacklist;

                _service.UpdateUser(selectedUser);
            }

            // remaking viewmodel
            ApplicationUser returningUser = _service.GetUserById(selectedUser.Id);

            Admin_User_ViewModel returning = new()
            {
                User = returningUser,
                Role = _service.GetIdentityRoleByUser(returningUser),
                AllRoles = _service.GetAllIdentityRoles().ToList()
            };

            return View("User", returning);
        }

        //
        // Slot Machine related
        //
        public IActionResult SlotMachines()
        {
            return View(_service.GetAllSlotMachines().ToList());
        }

        public IActionResult SlotMachine(int slotMachineId) 
        {
            Admin_SlotMachine_ViewModel vm = new()
            {
                SlotMachine = _service.GetSlotMachineById(slotMachineId),
                SlotSymbols = _service.GetSlotSymbolBySlotMachineId(slotMachineId).ToList()
            };

            return View(vm);
        }
        [HttpPost]
        public IActionResult SlotMachine(Admin_SlotMachine_ViewModel vm)
        {
            // grabbing input values
            SlotMachine selectedSlotMachine = _service.GetSlotMachineById(vm.SlotMachineId);

            if (vm.IsNowOutofOrder != selectedSlotMachine.OutOfOrder)
            {
                selectedSlotMachine.OutOfOrder = vm.IsNowOutofOrder;

                _service.UpdateSlotMachine(selectedSlotMachine);
            }

            // remaking viewmodel
            SlotMachine returningSlotMachine = _service.GetSlotMachineById(selectedSlotMachine.Id);

            Admin_SlotMachine_ViewModel returning = new()
            {
                SlotMachine = returningSlotMachine,
                SlotSymbols = _service.GetSlotSymbolBySlotMachineId(returningSlotMachine.Id).ToList()
            };

            return View("SlotMachine", returning);
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
