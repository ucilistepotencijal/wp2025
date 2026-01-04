using AutoServis.Data;
using AutoServis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.ActiveVehicles = await _context.Vehicles
                .CountAsync(v => v.IsActive);

            ViewBag.TodayAppointments = await _context.Appointments
                .CountAsync(a => a.ScheduledDate.Date == DateTime.Today);

            ViewBag.Scheduled = await _context.Appointments
                .CountAsync(a => a.Status == AppointmentStatus.Scheduled);

            ViewBag.InProgress = await _context.Appointments
                .CountAsync(a => a.Status == AppointmentStatus.InProgress);

            ViewBag.Completed = await _context.Appointments
                .CountAsync(a => a.Status == AppointmentStatus.Completed);

            ViewBag.Cancelled = await _context.Appointments
                .CountAsync(a => a.Status == AppointmentStatus.Canceled);

            return View();
        }
    }
}
