using System;
using System.Collections.Generic;
using System.Linq;
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
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index()
        {
            // Include osigurava da imamo podatke o psu, usluzi i korisniku (emailu) za tablicu
            var bookings = _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType)
                .Include(b => b.User);
            return View(await bookings.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (booking == null) return NotFound();

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            // Provjeravamo ima li u bazi ijedan pas (ako želiš strože, provjeri ima li pas za trenutnog korisnika)
            var hasPets = _context.Pets.Any();

            if (!hasPets)
            {
                // Ako nema pasa, šaljemo korisnika na stranicu za dodavanje psa uz poruku
                TempData["Message"] = "Morate dodati barem jednog ljubimca prije nego što napravite rezervaciju!";
                return RedirectToAction("Create", "Pets");
            }

            ViewData["PetId"] = new SelectList(_context.Pets, "Id", "Name");
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");

            return View();
        }
        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,Notes,CreatedAt,Status,PetId,ServiceTypeId,UserId")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Ako dođe do greške, ponovno punimo liste (prikazujemo Email)
            ViewData["PetId"] = new SelectList(_context.Pets, "Id", "Name", booking.PetId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", booking.ServiceTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null) return NotFound();

            ViewData["PetId"] = new SelectList(_context.Pets, "Id", "Name", booking.PetId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", booking.ServiceTypeId);

            // POPRAVLJENO: Prikazuje Email kod uređivanja
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", booking.UserId);

            return View(booking);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,EndDate,Notes,CreatedAt,Status,PetId,ServiceTypeId,UserId")] Booking booking)
        {
            if (id != booking.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["PetId"] = new SelectList(_context.Pets, "Id", "Name", booking.PetId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", booking.ServiceTypeId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email", booking.UserId);
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType)
                .Include(b => b.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (booking == null) return NotFound();

            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}