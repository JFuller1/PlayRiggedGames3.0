using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayRiggedGames.DataAccess.Data;
using PlayRiggedGames.Domain.Models;
using PlayRiggedGames.Service.ViewModels;
using System.Diagnostics;
using System.Security.Claims;

namespace PlayRiggedGames.Service.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // ensure to use the INTERFACE not the HARDCODED stuff when injecting
        private readonly IRiggedService _service;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, IRiggedService service, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _service = service;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Authorize]
        public IActionResult UserDetails()
        {
            ApplicationUser user = GetLoggedInUser();
            List<SlotGameLog> slotLogs = _service.GetAllSlotGameLogs().Where(x => x.Player == user).ToList();
            List<SlotMachine> slotMachines = _service.GetAllSlotMachines().ToList();

            return View(new Home_UserDetails_ViewModel(user, slotLogs, slotMachines));
        }

        private ApplicationUser GetLoggedInUser()
        {
            // gets the id of the currently logged in user
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _service.GetUserById(userId);
        }
    }
}