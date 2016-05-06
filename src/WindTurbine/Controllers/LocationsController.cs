using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;
using System.Security.Claims;
using WindTurbine.Models;
using Microsoft.AspNet.Identity;

namespace WindTurbine.Controllers
{
    [Authorize]
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public LocationsController(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext db    
        )
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
            return View(_db.Locations.Where(x => x.User.Id == currentUser.Id));
        }

        public IActionResult Details(int id)
        {
            var thisLocation = _db.Locations.FirstOrDefault(locations => locations.LocationId == id);
            return View(thisLocation);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Location location)
        {
            var currentUser = await _userManager.FindByIdAsync(User.GetUserId());
            location.User = currentUser;

            DateTime timeStamp = DateTime.Now;
            location.Time = timeStamp;
            _db.Locations.Add(location);

            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}