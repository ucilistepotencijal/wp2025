using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetHotel.Data;
using PetHotel.Models;
using System.Security.Claims;

namespace PetHotel.Controllers
{
    [Authorize]
    public class PetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pets
        public async Task<IActionResult> Index()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var petsQuery = _context.Pets.Include(p => p.User).AsQueryable();

            if (!User.IsInRole("Admin"))
            {
                petsQuery = petsQuery.Where(p => p.UserId == currentUserId);
            }

            return View(await petsQuery.ToListAsync());
        }

        // GET: Pets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var pet = await _context.Pets
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pet == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (pet.UserId != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            return View(pet);
        }

        // GET: Pets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pet pet)
        {
            pet.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ModelState.Remove("UserId");
            ModelState.Remove("User");

            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(pet);
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var pet = await _context.Pets.FindAsync(id);
            if (pet == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (pet.UserId != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            return View(pet);
        }

        // POST: Pets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Pet pet)
        {
            if (id != pet.Id) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!User.IsInRole("Admin"))
            {
                pet.UserId = currentUserId;
            }

            ModelState.Remove("UserId");
            ModelState.Remove("User");

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pet);
        }

        // GET: Pets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var pet = await _context.Pets
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pet == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (pet.UserId != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            return View(pet);
        }

        // POST: Pets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // PRONAĐI PSA UKLJUČUJUĆI NJEGOVE REZERVACIJE
            var pet = await _context.Pets
                .Include(p => p.Bookings) // Važno: uključujemo listu rezervacija
                .FirstOrDefaultAsync(m => m.Id == id);

            if (pet != null)
            {
                var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                // Provjera vlasništva ili admin prava
                if (pet.UserId == currentUserId || User.IsInRole("Admin"))
                {
                    // 1. Ručno obriši sve rezervacije povezane s tim psom
                    if (pet.Bookings != null && pet.Bookings.Any())
                    {
                        _context.Bookings.RemoveRange(pet.Bookings);
                    }

                    // 2. Sada obriši samog psa
                    _context.Pets.Remove(pet);

                    await _context.SaveChangesAsync();
                }
            }

            return RedirectToAction(nameof(Index));
        }

        private bool PetExists(int id)
        {
            return _context.Pets.Any(e => e.Id == id);
        }
    }
}