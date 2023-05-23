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
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _db = db;
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
        public IActionResult UserDetails()
        {
            ApplicationUser user = GetLoggedInUser();
            List<SlotGameLog> slotLogs = _db.SlotGameLogs.Where(gamelog => gamelog.PlayerId == user.Id).ToList();
            return View(new Home_UserDetails_ViewModel(user, slotLogs, _db.SlotMachines.ToList()));
        }

        public ApplicationUser GetLoggedInUser()
        {
            // gets the id of the currently logged in user
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _db.ApplicationUsers.First(user => user.Id == userId);
        }
    }
}