using System.Security.Claims;
using AutoServis.Data;
using AutoServis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Controllers
{
    [Authorize]
    public class AppointmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppointmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        private string CurrentUserId() => User.FindFirstValue(ClaimTypes.NameIdentifier)!;
        private bool IsAdmin() => User.IsInRole("Admin");

        private async Task PopulateDropdownsAsync(string? selectedUserId, int? selectedVehicleId, int? selectedServiceTypeId)
        {
            // Service types (samo aktivni ako imaš IsActive, inače svi)
            ViewData["ServiceTypeId"] = new SelectList(
                await _context.ServiceTypes.OrderBy(s => s.Name).ToListAsync(),
                "Id", "Name", selectedServiceTypeId
            );

            if (IsAdmin())
            {
                // Admin bira usera (prikaz email)
                var users = await _context.Users
                    .OrderBy(u => u.Email)
                    .Select(u => new { u.Id, Text = (u.Email ?? u.UserName) })
                    .ToListAsync();

                ViewData["UserId"] = new SelectList(users, "Id", "Text", selectedUserId);

                // Admin bira vozilo (prikaz registracija + vlasnik)
                var vehicles = await _context.Vehicles
                    .Include(v => v.User)
                    .Where(v => v.IsActive)
                    .OrderBy(v => v.LicensePlate)
                    .Select(v => new
                    {
                        v.Id,
                        Text = $"{v.LicensePlate} ({(v.User.Email ?? v.User.UserName)})",
                        v.UserId
                    })
                    .ToListAsync();

                ViewData["VehicleId"] = new SelectList(vehicles, "Id", "Text", selectedVehicleId);
            }
            else
            {
                var userId = CurrentUserId();

                // User ne bira usera (ali dropdown i dalje postoji ako neki scaffold view očekuje)
                ViewData["UserId"] = new SelectList(new[] { new { Id = userId, Text = "" } }, "Id", "Text", userId);

                // User bira samo svoja aktivna vozila
                var vehicles = await _context.Vehicles
                    .Where(v => v.UserId == userId && v.IsActive)
                    .OrderBy(v => v.LicensePlate)
                    .Select(v => new { v.Id, Text = v.LicensePlate })
                    .ToListAsync();

                ViewData["VehicleId"] = new SelectList(vehicles, "Id", "Text", selectedVehicleId);
            }
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            var query = _context.Appointments
                .Include(a => a.ServiceType)
                .Include(a => a.User)
                .Include(a => a.Vehicle)
                .AsQueryable();

            if (!IsAdmin())
            {
                var uid = CurrentUserId();
                query = query.Where(a => a.UserId == uid);
            }

            var list = await query
                .OrderByDescending(a => a.ScheduledDate)
                .ToListAsync();

            return View(list);
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var appt = await _context.Appointments
                .Include(a => a.ServiceType)
                .Include(a => a.User)
                .Include(a => a.Vehicle)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appt == null) return NotFound();

            if (!IsAdmin() && appt.UserId != CurrentUserId())
                return Forbid();

            return View(appt);
        }

        // GET: Appointments/Create
        public async Task<IActionResult> Create()
        {
            var selectedUserId = IsAdmin() ? null : CurrentUserId();
            await PopulateDropdownsAsync(selectedUserId, null, null);

            // useru ne daj status/createdAt u formi
            return View(new Appointment
            {
                ScheduledDate = DateTime.Now.AddDays(1),
                Status = AppointmentStatus.Scheduled
            });
        }

        // POST: Appointments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceTypeId,UserId,VehicleId,ScheduledDate,Status,Notes")] Appointment input)
        {
            if (!IsAdmin())
            {
                // user: uvijek za sebe
                input.UserId = CurrentUserId();
                // user: status se ne bira
                input.Status = AppointmentStatus.Scheduled;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(input.UserId))
                    ModelState.AddModelError("UserId", "Korisnik je obavezan.");
            }

            // Validacija vozila:
            // - user ne smije birati tuđe vozilo
            // - admin: vozilo mora odgovarati izabranom useru (da se ne “pomiješa”)
            var vehicle = await _context.Vehicles.FirstOrDefaultAsync(v => v.Id == input.VehicleId);
            if (vehicle == null || !vehicle.IsActive)
            {
                ModelState.AddModelError("VehicleId", "Odabrano vozilo nije valjano.");
            }
            else
            {
                if (!IsAdmin() && vehicle.UserId != input.UserId)
                    ModelState.AddModelError("VehicleId", "Možete odabrati samo svoje vozilo.");

                if (IsAdmin() && vehicle.UserId != input.UserId)
                    ModelState.AddModelError("VehicleId", "Odabrano vozilo ne pripada odabranom korisniku.");
            }

            input.CreatedAt = DateTime.UtcNow;

            if (!ModelState.IsValid)
            {
                await PopulateDropdownsAsync(
                    IsAdmin() ? input.UserId : CurrentUserId(),
                    input.VehicleId,
                    input.ServiceTypeId
                );
                return View(input);
            }

            _context.Appointments.Add(input);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var appt = await _context.Appointments.FindAsync(id);
            if (appt == null) return NotFound();

            if (!IsAdmin() && appt.UserId != CurrentUserId())
                return Forbid();

            await PopulateDropdownsAsync(
                IsAdmin() ? appt.UserId : CurrentUserId(),
                appt.VehicleId,
                appt.ServiceTypeId
            );

            return View(appt);
        }

        // POST: Appointments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ServiceTypeId,UserId,VehicleId,ScheduledDate,Status,Notes")] Appointment input)
        {
            if (id != input.Id) return NotFound();

            var appt = await _context.Appointments.FindAsync(id);
            if (appt == null) return NotFound();

            if (!IsAdmin() && appt.UserId != CurrentUserId())
                return Forbid();

            // User: ne smije mijenjati UserId ni Status
            if (!IsAdmin())
            {
                input.UserId = appt.UserId;
                input.Status = appt.Status;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(input.UserId))
                    ModelState.AddModelError("UserId", "Korisnik je obavezan.");
            }

            // Validacija vozila (isto kao Create)
            var vehicle = await _context.Vehicles.FirstOrDefaultAsync(v => v.Id == input.VehicleId);
            if (vehicle == null || !vehicle.IsActive)
            {
                ModelState.AddModelError("VehicleId", "Odabrano vozilo nije valjano.");
            }
            else
            {
                if (!IsAdmin() && vehicle.UserId != input.UserId)
                    ModelState.AddModelError("VehicleId", "Možete odabrati samo svoje vozilo.");

                if (IsAdmin() && vehicle.UserId != input.UserId)
                    ModelState.AddModelError("VehicleId", "Odabrano vozilo ne pripada odabranom korisniku.");
            }

            if (!ModelState.IsValid)
            {
                await PopulateDropdownsAsync(
                    IsAdmin() ? input.UserId : CurrentUserId(),
                    input.VehicleId,
                    input.ServiceTypeId
                );
                return View(input);
            }

            // Update allowed fields
            appt.ServiceTypeId = input.ServiceTypeId;
            appt.VehicleId = input.VehicleId;
            appt.ScheduledDate = input.ScheduledDate;
            appt.Notes = input.Notes;

            if (IsAdmin())
            {
                appt.UserId = input.UserId;
                appt.Status = input.Status;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var appt = await _context.Appointments
                .Include(a => a.ServiceType)
                .Include(a => a.User)
                .Include(a => a.Vehicle)
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appt == null) return NotFound();

            if (!IsAdmin() && appt.UserId != CurrentUserId())
                return Forbid();

            return View(appt);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appt = await _context.Appointments.FindAsync(id);
            if (appt == null) return NotFound();

            if (!IsAdmin() && appt.UserId != CurrentUserId())
                return Forbid();

            _context.Appointments.Remove(appt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}