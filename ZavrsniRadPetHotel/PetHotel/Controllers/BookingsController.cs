using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims; // Potrebno za ClaimTypes
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetHotel.Data;
using PetHotel.Models;

namespace PetHotel.Controllers
{
    [Authorize] // Zaključava cijeli kontroler - samo za prijavljene
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

            IQueryable<Booking> bookingsQuery = _context.Bookings
                .Include(b => b.Pet)
                .Include(b => b.ServiceType);

            // Ako nije Admin, filtriraj samo njegove rezervacije
            if (!User.IsInRole("Admin"))
            {
                // Filtriramo rezervacije čiji ljubimci pripadaju trenutnom korisniku
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

            // Sigurnosna provjera
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

            // Korisnik u padajućem izborniku vidi SAMO SVOJE ljubimce
            var mojiLjubimci = _context.Pets.Where(p => p.UserId == currentUserId).ToList();

            ViewData["PetId"] = new SelectList(mojiLjubimci, "Id", "Name");
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");
            return View();
        }

        // POST: Bookings/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StartDate,EndDate,PetId,ServiceTypeId,Notes")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ViewData["PetId"] = new SelectList(_context.Pets.Where(p => p.UserId == currentUserId), "Id", "Name", booking.PetId);
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", booking.ServiceTypeId);
            return View(booking);
        }

        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var booking = await _context.Bookings.Include(b => b.Pet).FirstOrDefaultAsync(x => x.Id == id);
            if (booking == null) return NotFound();

            // Sigurnosna provjera
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,StartDate,EndDate,PetId,ServiceTypeId,Notes")] Booking booking)
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

            // Sigurnosna provjera
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