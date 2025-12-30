using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace PetHotel.Controllers
{
    // [Authorize(Roles = "Admin")] // Ovu liniju ćemo otkomentirati kasnije kad sredimo uloge
    public class AdminUsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        // Konstruktor - tražimo od sustava da nam da alat za rad s korisnicima
        public AdminUsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        // Akcija koja otvara popis korisnika
        public async Task<IActionResult> Index()
        {
            var korisnici = await _userManager.Users.ToListAsync();
            return View(korisnici);
        }
    }
}