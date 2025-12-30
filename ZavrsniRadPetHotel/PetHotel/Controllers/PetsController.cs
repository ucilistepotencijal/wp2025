using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetHotel.Data;
using PetHotel.Models;

namespace PetHotel.Controllers
{
    [Authorize] // Osigurava da samo prijavljeni korisnici mogu pristupiti kontroleru
    public class PetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PetsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pets
        // Prikazuje samo ljubimce trenutnog korisnika (ili sve ako je Admin)
        public async Task<IActionResult> Index()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Osnovni upit s uključenim podacima o korisniku/vlasniku
            var petsQuery = _context.Pets.Include(p => p.User).AsQueryable();

            // Ako korisnik nije Admin, filtriraj samo njegove ljubimce
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

            // Sigurnosna provjera: Ne dopusti pristup tuđim ljubimcima
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
            // 1. Automatski dodijeli ID trenutno prijavljenog korisnika
            pet.UserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // 2. Ručno ukloni UserId i User iz validacije (za svaki slučaj uz [ValidateNever])
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

            // Sigurnosna provjera za Edit
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

            // Ponovno dodijeli UserId kako bi se spriječilo "otimanje" ljubimca promjenom ID-a u formi
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Ako nije admin, forsiraj vlasništvo na trenutnog korisnika
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
                // Dodatna sigurnosna provjera prije brisanja
                var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
                if (pet.UserId == currentUserId || User.IsInRole("Admin"))
                {
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