﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PlayRiggedGames.Service.Controllers
{
    // [Authorize(Roles = "Admin")]
    [Authorize]
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
            if (_service.GetIdentityRoleOfUser(GetLoggedInUser()) == _service.GetIdentityRoleByName("Admin")) {
                // should contain links to other pages
                return View();
            }
            string host = HttpContext.Request.Host.Host;
            string port = HttpContext.Request.Host.Port.HasValue ? HttpContext.Request.Host.Port.Value.ToString() : string.Empty;

            string accessDeniedUrl = $"https://{host}:{port}/Identity/Account/AccessDenied";

            return Redirect(accessDeniedUrl);
        }

        //
        // User related
        //
        public IActionResult ApplicationUsers()
        {
            List<Admin_Users_ViewModel> returning = new();

            foreach (ApplicationUser user in _service.GetAllUsers())
            {
                returning.Add(new Admin_Users_ViewModel()
                {
                    User = user,
                    Role = _service.GetIdentityRoleOfUser(user)
                });
            }

            return View(returning);
        }

        public IActionResult ApplicationUser(string id)
        {
            ApplicationUser selectedUser = _service.GetUserById(id);

            Admin_User_ViewModel returning = new()
            {
                User = selectedUser,
                Role = _service.GetIdentityRoleOfUser(selectedUser),
                AllRoles = _service.GetAllIdentityRoles().ToList()
            };

            return View(returning);
        }

        [HttpPost]
        public IActionResult ApplicationUser(Admin_User_ViewModel vm)
        {
            // grabbing input values
            ApplicationUser selectedUser = _service.GetUserById(vm.UserId);
            IdentityRole newRole = _service.GetIdentityRoleById(vm.NewRoleId);

            // check if newRole, blacklisted is different from user info
            // if different change values
            // then return to User
            if (newRole != _service.GetIdentityRoleOfUser(selectedUser))
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
                Role = _service.GetIdentityRoleOfUser(returningUser),
                AllRoles = _service.GetAllIdentityRoles().ToList()
            };

            return View("ApplicationUser", returning);
        }

        //
        // Slot Machine related
        //
        public IActionResult SlotMachines()
        {
            return View(_service.GetAllSlotMachines().ToList());
        }

        public IActionResult SlotMachine(int id)
        {
            Admin_SlotMachine_ViewModel vm = new()
            {
                SlotMachine = _service.GetSlotMachineById(id),
                SlotSymbols = _service.GetSlotSymbolsBySlotMachineId(id).ToList()
            };

            return View(vm);
        }
        [HttpPost]
        public IActionResult SlotMachine(Admin_SlotMachine_ViewModel vm)
        {
            // making
            SlotMachine making = _service.GetSlotMachineById(vm.SlotMachineId);

            // apply change
            making.OutOfOrder = vm.IsNowOutofOrder;
            _service.UpdateSlotMachine(making);


            // remaking viewmodel
            SlotMachine refreshed = _service.GetSlotMachineById(making.Id);

            Admin_SlotMachine_ViewModel returning = new()
            {
                SlotMachine = refreshed,
                SlotSymbols = _service.GetSlotSymbolsBySlotMachineId(refreshed.Id).ToList()
            };

            return View("SlotMachine", returning);
        }

        //
        // Slot Symbol related
        //
        public IActionResult SlotSymbols()
        {
            return View(_service.GetAllSlotSymbols().ToList());
        }

        public IActionResult SlotSymbol(int id)
        {
            SlotSymbol selected = _service.GetSlotSymbolById(id);

            Admin_SlotSymbol_ViewModel returning = new()
            {
                SlotSymbol = selected,
                SlotMachine = _service.GetSlotMachineById(selected.SlotMachineId)
            };

            return View(returning);
        }
        [HttpPost]
        public IActionResult SlotSymbol(Admin_SlotSymbol_ViewModel vm)
        {
            // newly making
            SlotSymbol making = _service.GetSlotSymbolById(vm.SlotSymbolId);

            // apply change
            making.Value = vm.NewValue;
            making.Weight = vm.NewWeight;
            _service.UpdateSlotSymbol(making);

            // redisplaying
            SlotSymbol refreshed = _service.GetSlotSymbolById(vm.SlotSymbolId);
            Admin_SlotSymbol_ViewModel returning = new()
            {
                SlotSymbol = refreshed,
                SlotMachine = _service.GetSlotMachineById(refreshed.SlotMachineId)
            };

            return View("SlotSymbol", returning);
        }

        // 
        //  SlotGameLog related
        //
        public IActionResult SlotGameLogs()
        {
            return View(_service.GetAllSlotGameLogs().ToList());
        }
        public IActionResult SlotGameLog(int id)
        {
            SlotGameLog selected = _service.GetSlotGameLogById(id);
            List<SlotOutcome> slotOutcomes = _service.GetSlotOutcomesBySlotGameLogId(selected.Id).ToList();

            Admin_SlotGameLog_ViewModel returning = new()
            {
                SlotGameLog = selected,
                Player = _service.GetUserById(selected.PlayerId),
                SlotMachine = GetSlotMachineFromSlotOutComes(slotOutcomes)
            };

            return View(returning);
        }



        private ApplicationUser GetLoggedInUser()
        {
            // gets the id of the currently logged in user
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _service.GetUserById(userId);
        }

        // I honestly need this function for only one purpose and two uses so here it is
        public SlotMachine GetSlotMachineFromSlotOutComes(List<SlotOutcome> slotOutcomes)
        {
            // SlotOutcomes --> SlotOutcome --> SlotSymbol --> SlotSymbol.SlotMachineId --> SlotMachine
            SlotSymbol firstSymbol = _service.GetSlotSymbolById(slotOutcomes[0].SymbolId);

            SlotMachine slotMachine = _service.GetSlotMachineById(firstSymbol.SlotMachineId);

            return slotMachine;
        }
    }
}
