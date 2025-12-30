using AutoServis.Data;
using AutoServis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Controllers
{
    [Authorize]
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public VehiclesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        private bool IsAdmin() => User.IsInRole("Admin");

        private async Task PopulateUsersAsync(string? selectedUserId = null)
        {
            var users = await _context.Users
                .OrderBy(u => u.Email)
                .Select(u => new
                {
                    u.Id,
                    Text = (u.Email ?? u.UserName)
                })
                .ToListAsync();

            ViewData["UserId"] = new SelectList(users, "Id", "Text", selectedUserId);
        }

        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            var query = _context.Vehicles
                .Include(v => v.User)
                .AsQueryable();

            if (!IsAdmin())
            {
                var userId = _userManager.GetUserId(User);
                query = query.Where(v => v.UserId == userId && v.IsActive);
            }

            var vehicles = await query
                .OrderByDescending(v => v.Id)
                .ToListAsync();

            return View(vehicles);
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var query = _context.Vehicles
                .Include(v => v.User)
                .AsQueryable();

            if (!IsAdmin())
            {
                var userId = _userManager.GetUserId(User);
                query = query.Where(v => v.UserId == userId && v.IsActive);
            }

            var vehicle = await query.FirstOrDefaultAsync(v => v.Id == id);
            if (vehicle == null) return NotFound();

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public async Task<IActionResult> Create()
        {
            if (IsAdmin())
                await PopulateUsersAsync();

            // customeru ne prikazujemo UserId/IsActive, ali model može imati default
            return View(new Vehicle { IsActive = true });
        }

        // POST: Vehicles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Make,Model,Year,LicensePlate,Vin,UserId,IsActive")] Vehicle input)
        {
            if (!IsAdmin())
            {
                // Customer: uvijek za sebe i uvijek aktivno
                input.UserId = _userManager.GetUserId(User)!;
                input.IsActive = true;
            }
            else
            {
                // Admin: mora odabrati vlasnika (ili možeš dopustiti null ako želiš)
                if (string.IsNullOrWhiteSpace(input.UserId))
                    ModelState.AddModelError("UserId", "Vlasnik je obavezan.");
            }

            if (!ModelState.IsValid)
            {
                if (IsAdmin()) await PopulateUsersAsync(input.UserId);
                return View(input);
            }

            _context.Vehicles.Add(input);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var query = _context.Vehicles
                .Include(v => v.User)
                .AsQueryable();

            if (!IsAdmin())
            {
                var userId = _userManager.GetUserId(User);
                query = query.Where(v => v.UserId == userId && v.IsActive);
            }

            var vehicle = await query.FirstOrDefaultAsync(v => v.Id == id);
            if (vehicle == null) return NotFound();

            if (IsAdmin())
                await PopulateUsersAsync(vehicle.UserId);

            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Make,Model,Year,LicensePlate,Vin,UserId,IsActive")] Vehicle input)
        {
            if (id != input.Id) return NotFound();

            var query = _context.Vehicles.AsQueryable();

            if (!IsAdmin())
            {
                var userId = _userManager.GetUserId(User);
                query = query.Where(v => v.UserId == userId && v.IsActive);
            }

            var vehicle = await query.FirstOrDefaultAsync(v => v.Id == id);
            if (vehicle == null) return NotFound();

            // Customer ne smije mijenjati vlasnika ni status
            if (!IsAdmin())
            {
                input.UserId = vehicle.UserId;
                input.IsActive = vehicle.IsActive;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(input.UserId))
                    ModelState.AddModelError("UserId", "Vlasnik je obavezan.");
            }

            if (!ModelState.IsValid)
            {
                if (IsAdmin()) await PopulateUsersAsync(input.UserId);
                return View(input);
            }

            vehicle.Make = input.Make;
            vehicle.Model = input.Model;
            vehicle.Year = input.Year;
            vehicle.LicensePlate = input.LicensePlate;
            vehicle.Vin = input.Vin;

            if (IsAdmin())
            {
                vehicle.UserId = input.UserId;
                vehicle.IsActive = input.IsActive;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Vehicles/Delete/5 (admin-only)
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            if (!IsAdmin())
                return Forbid();

            var vehicle = await _context.Vehicles
                .Include(v => v.User)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (vehicle == null) return NotFound();

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5 (admin-only, fizičko brisanje)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (!IsAdmin())
                return Forbid();

            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null) return NotFound();

            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // POST: Vehicles/ToggleActive (admin-only)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleActive(int id)
        {
            if (!IsAdmin())
                return Forbid();

            var vehicle = await _context.Vehicles.FindAsync(id);
            if (vehicle == null) return NotFound();

            vehicle.IsActive = !vehicle.IsActive;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}

