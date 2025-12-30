using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims; // Dodano za prepoznavanje korisnika
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetHotel.Data;
using PetHotel.Models;

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
            // Dohvaćamo ID trenutno prijavljenog korisnika
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            IQueryable<Pet> petsQuery;

            // Ako želiš da Admin vidi sve, a ostali samo svoje:
            if (User.IsInRole("Admin"))
            {
                petsQuery = _context.Pets.Include(p => p.User);
            }
            else
            {
                // Običan korisnik vidi samo svoje ljubimce
                petsQuery = _context.Pets
                    .Where(p => p.UserId == currentUserId)
                    .Include(p => p.User);
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

            // Sigurnosna provjera: Ne dopusti korisniku da gleda tuđeg ljubimca preko linka
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
            // Prikazujemo Email umjesto ID-a u padajućem izborniku
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Pets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Breed,Size,BirthYear,MicrochipNumber,IsSocialized,PersonalNotes,IsActive,UserId")] Pet pet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", pet.UserId);
            return View(pet);
        }

        // GET: Pets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var pet = await _context.Pets.FindAsync(id);
            if (pet == null) return NotFound();

            // Sigurnosna provjera za Edit
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (pet.UserId != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", pet.UserId);
            return View(pet);
        }

        // POST: Pets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Breed,Size,BirthYear,MicrochipNumber,IsSocialized,PersonalNotes,IsActive,UserId")] Pet pet)
        {
            if (id != pet.Id) return NotFound();

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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", pet.UserId);
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

            // Sigurnosna provjera za Delete
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
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PetExists(int id)
        {
            return _context.Pets.Any(e => e.Id == id);
        }
    }
}