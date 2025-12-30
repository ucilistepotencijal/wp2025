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
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var bookingsQuery = _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType)
                .AsQueryable();

            if (!User.IsInRole("Admin"))
            {
                bookingsQuery = bookingsQuery.Where(b => b.Pet.UserId == currentUserId);
            }

            return View(await bookingsQuery.ToListAsync());
        }

        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (booking == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (booking.Pet.UserId != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            return View(booking);
        }

        // GET: Bookings/Create
        public IActionResult Create()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // ADMIN vidi sve ljubimce u sustavu, KORISNIK samo svoje
            var ljubimciZaOdabir = User.IsInRole("Admin")
                ? _context.Pets
                : _context.Pets.Where(p => p.UserId == currentUserId);

            ViewData["PetId"] = new SelectList(ljubimciZaOdabir, "Id", "Name");
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PetId,ServiceTypeId,StartDate,EndDate,Status,Notes")] Booking booking)
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Postavljamo UserId na trenutnog korisnika
            booking.UserId = currentUserId;

            // Čišćenje validacije za navigacijska polja (Pet, ServiceType, User)
            ModelState.Remove("Pet");
            ModelState.Remove("ServiceType");
            ModelState.Remove("User");
            ModelState.Remove("UserId");

            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Ako validacija ne prođe, ponovno napuni liste
            var ljubimciZaOdabir = User.IsInRole("Admin")
                ? _context.Pets
                : _context.Pets.Where(p => p.UserId == currentUserId);

            ViewData["PetId"] = new SelectList(ljubimciZaOdabir, "Id", "Name", booking.PetId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", booking.ServiceTypeId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings.Include(b => b.Pet).FirstOrDefaultAsync(b => b.Id == id);
            if (booking == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (booking.Pet.UserId != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

            var ljubimciZaOdabir = User.IsInRole("Admin")
                ? _context.Pets
                : _context.Pets.Where(p => p.UserId == booking.Pet.UserId);

            ViewData["PetId"] = new SelectList(ljubimciZaOdabir, "Id", "Name", booking.PetId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", booking.ServiceTypeId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Booking booking)
        {
            if (id != booking.Id) return NotFound();

            // Zadržavamo originalni UserId pri uređivanju
            ModelState.Remove("Pet");
            ModelState.Remove("ServiceType");
            ModelState.Remove("User");
            ModelState.Remove("UserId");

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
            return View(booking);
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (booking == null) return NotFound();

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (booking.Pet.UserId != currentUserId && !User.IsInRole("Admin"))
            {
                return Forbid();
            }

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
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        // METODA ZA IZVJEŠTAJ KOJA JE NEDOSTAJALA
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminReport()
        {
            var reportData = await _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType)
                .OrderByDescending(b => b.StartDate)
                .AsNoTracking()
                .ToListAsync();

            return View(reportData);
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}