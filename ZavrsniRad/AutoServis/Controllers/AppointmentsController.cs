using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AutoServis.Data;
using AutoServis.Models;

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

        private string GetCurrentUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        private bool IsElevatedUser()
        {
            return User.IsInRole("Admin");
        }

        // GET: Appointments
        public async Task<IActionResult> Index()
        {
            var query = _context.Appointments
                .Include(a => a.ServiceType)
                .Include(a => a.User)
                .Include(a => a.Vehicle)
                .AsQueryable();

            if (!IsElevatedUser())
            {
                var currentUserId = GetCurrentUserId();
                query = query.Where(a => a.UserId == currentUserId);
            }

            return View(await query.ToListAsync());
        }

        // GET: Appointments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var appointment = await _context.Appointments
                .Include(a => a.ServiceType)
                .Include(a => a.User)
                .Include(a => a.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (appointment == null) return NotFound();

            if (!IsElevatedUser() && appointment.UserId != GetCurrentUserId())
            {
                return Forbid();
            }

            return View(appointment);
        }

        // GET: Appointments/Create
        public IActionResult Create()
        {
            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name");

            if (IsElevatedUser())
            {
                ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            }
            else
            {
                var currentUserId = GetCurrentUserId();
                ViewData["UserId"] = new SelectList(_context.Users.Where(u => u.Id == currentUserId), "Id", "Id", currentUserId);
            }

            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "LicensePlate");
            return View();
        }

        // POST: Appointments/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ServiceTypeId,UserId,VehicleId,ScheduledDate,Status,Notes")] Appointment appointment)
        {
            if (!IsElevatedUser())
            {
                // Force the appointment to belong to the current user
                appointment.UserId = GetCurrentUserId();
            }

            // Server-side defaults
            appointment.CreatedAt = DateTime.UtcNow;

            if (ModelState.IsValid)
            {
                _context.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", appointment.ServiceTypeId);

            if (IsElevatedUser())
            {
                ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", appointment.UserId);
            }
            else
            {
                ViewData["UserId"] = new SelectList(_context.Users.Where(u => u.Id == appointment.UserId), "Id", "Id", appointment.UserId);
            }

            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "LicensePlate", appointment.VehicleId);
            return View(appointment);
        }

        // GET: Appointments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null) return NotFound();

            if (!IsElevatedUser() && appointment.UserId != GetCurrentUserId())
            {
                return Forbid();
            }

            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", appointment.ServiceTypeId);

            if (IsElevatedUser())
            {
                ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", appointment.UserId);
            }
            else
            {
                ViewData["UserId"] = new SelectList(_context.Users.Where(u => u.Id == appointment.UserId), "Id", "Id", appointment.UserId);
            }

            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "LicensePlate", appointment.VehicleId);
            return View(appointment);
        }

        // POST: Appointments/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ServiceTypeId,VehicleId,ScheduledDate,Status,Notes")] Appointment input)
        {
            if (id != input.Id) return NotFound();

            var appointmentToUpdate = await _context.Appointments.FindAsync(id);
            if (appointmentToUpdate == null) return NotFound();

            if (!IsElevatedUser() && appointmentToUpdate.UserId != GetCurrentUserId())
            {
                return Forbid();
            }

            // Update allowed fields only (prevent overposting of UserId and CreatedAt)
            appointmentToUpdate.ServiceTypeId = input.ServiceTypeId;
            appointmentToUpdate.VehicleId = input.VehicleId;
            appointmentToUpdate.ScheduledDate = input.ScheduledDate;
            appointmentToUpdate.Status = input.Status;
            appointmentToUpdate.Notes = input.Notes;

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appointmentToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppointmentExists(appointmentToUpdate.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["ServiceTypeId"] = new SelectList(_context.ServiceTypes, "Id", "Name", appointmentToUpdate.ServiceTypeId);

            if (IsElevatedUser())
            {
                ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", appointmentToUpdate.UserId);
            }
            else
            {
                ViewData["UserId"] = new SelectList(_context.Users.Where(u => u.Id == appointmentToUpdate.UserId), "Id", "Id", appointmentToUpdate.UserId);
            }

            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "LicensePlate", appointmentToUpdate.VehicleId);
            return View(appointmentToUpdate);
        }

        // GET: Appointments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();

            var appointment = await _context.Appointments
                .Include(a => a.ServiceType)
                .Include(a => a.User)
                .Include(a => a.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (appointment == null) return NotFound();

            if (!IsElevatedUser() && appointment.UserId != GetCurrentUserId())
            {
                return Forbid();
            }

            return View(appointment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var appointment = await _context.Appointments.FindAsync(id);
            if (appointment == null) return NotFound();

            if (!IsElevatedUser() && appointment.UserId != GetCurrentUserId())
            {
                return Forbid();
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppointmentExists(int id)
        {
            return _context.Appointments.Any(e => e.Id == id);
        }
    }
}