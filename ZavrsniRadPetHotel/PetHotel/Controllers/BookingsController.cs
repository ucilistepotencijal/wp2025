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
                // Običan korisnik vidi samo rezervacije za svoje ljubimce
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

            // Korisnik bira samo svoje ljubimce
            var mojiLjubimci = _context.Pets.Where(p => p.UserId == currentUserId);

            ViewData["PetId"] = new SelectList(mojiLjubimci, "Id", "Name");
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Booking booking)
        {
            // 1. OBAVEZNO: Uzmi ID korisnika i dodijeli ga rezervaciji
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            booking.UserId = userId;

            // 2. Očisti validaciju za navigacijska polja
            ModelState.Remove("Pet");
            ModelState.Remove("ServiceType");
            ModelState.Remove("UserId");
            ModelState.Remove("User");

            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync(); // Ovo više neće bacati SQL Foreign Key grešku
                return RedirectToAction(nameof(Index));
            }

            // Ako dođe do greške, ponovno napuni padajuće izbornike
            ViewData["PetId"] = new SelectList(_context.Pets.Where(p => p.UserId == userId), "Id", "Name", booking.PetId);
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

            ViewData["PetId"] = new SelectList(_context.Pets.Where(p => p.UserId == currentUserId), "Id", "Name", booking.PetId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", booking.ServiceTypeId);
            return View(booking);
        }

        // POST: Bookings/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Booking booking)
        {
            if (id != booking.Id) return NotFound();

            // Osiguraj UserId i u editu
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            booking.UserId = currentUserId;

            ModelState.Remove("Pet");
            ModelState.Remove("ServiceType");
            ModelState.Remove("UserId");
            ModelState.Remove("User");

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

            ViewData["PetId"] = new SelectList(_context.Pets.Where(p => p.UserId == currentUserId), "Id", "Name", booking.PetId);
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

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.Id == id);
        }
    }
}