using System.Diagnostics;
using AutoServis.Data;
using AutoServis.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Top 4 aktivne usluge za poèetnu stranicu
            var services = await _context.ServiceTypes
                .Where(s => s.IsActive)
                .OrderBy(s => s.Name)
                .Take(4)
                .ToListAsync();

            // Mini statistika (vidljivo samo adminu u viewu)
            ViewBag.VehicleCount = await _context.Vehicles
                .CountAsync(v => v.IsActive);

            ViewBag.TodayAppointments = await _context.Appointments
                .CountAsync(a => a.ScheduledDate.Date == DateTime.Today);

            return View(services);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
