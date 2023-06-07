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
using System.Runtime.CompilerServices;
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
            if (UserIsAdmin())
            {
                // should contain links to other pages
                return View();
            }
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        //
        // User related
        //
        public IActionResult ApplicationUsers()
        {
            if (UserIsAdmin())
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
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        public IActionResult ApplicationUser(string id)
        {
            if (UserIsAdmin())
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
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        [HttpPost]
        public IActionResult ApplicationUser(Admin_User_ViewModel vm)
        {
            if (UserIsAdmin())
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
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        //
        // Slot Machine related
        //
        public IActionResult SlotMachines()
        {
            if (UserIsAdmin())
            {
                return View(_service.GetAllSlotMachines().ToList());
            }
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        public IActionResult SlotMachine(int id)
        {
            if (UserIsAdmin())
            {
                Admin_SlotMachine_ViewModel vm = new()
                {
                    SlotMachine = _service.GetSlotMachineById(id),
                    SlotSymbols = _service.GetSlotSymbolsBySlotMachineId(id).ToList()
                };

                return View(vm);
            }
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }
        [HttpPost]
        public IActionResult SlotMachine(Admin_SlotMachine_ViewModel vm)
        {
            if (UserIsAdmin())
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
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        //
        // Slot Symbol related
        //
        public IActionResult SlotSymbols()
        {
            if (UserIsAdmin())
            {
                return View(_service.GetAllSlotSymbols().ToList());
            }
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        public IActionResult SlotSymbol(int id)
        {
            if (UserIsAdmin())
            {
                SlotSymbol selected = _service.GetSlotSymbolById(id);

                Admin_SlotSymbol_ViewModel returning = new()
                {
                    SlotSymbol = selected,
                    SlotMachine = _service.GetSlotMachineById(selected.SlotMachineId)
                };

                return View(returning);
            }
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }
        [HttpPost]
        public IActionResult SlotSymbol(Admin_SlotSymbol_ViewModel vm)
        {
            if (UserIsAdmin())
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
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }

        // 
        //  SlotGameLog related
        //
        public IActionResult SlotGameLogs()
        {
            if (UserIsAdmin())
            {
                return View(_service.GetAllSlotGameLogs().ToList());
            }
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }
        public IActionResult SlotGameLog(int id)
        {
            if (UserIsAdmin())
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
            else
            {
                return Redirect(AccessDeniedPageUrl());
            }
        }


        //
        //  Private functions
        //
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
        private bool UserIsAdmin()
        {
            if (_service.GetIdentityRoleOfUser(GetLoggedInUser()) == _service.GetIdentityRoleByName("Admin"))
            {
                return true;
            }
            return false;
        }
        private string AccessDeniedPageUrl()
        {
            string host = HttpContext.Request.Host.Host;
            string port = HttpContext.Request.Host.Port.HasValue ? HttpContext.Request.Host.Port.Value.ToString() : string.Empty;

            return $"https://{host}:{port}/Identity/Account/AccessDenied";
        }
    }
}
