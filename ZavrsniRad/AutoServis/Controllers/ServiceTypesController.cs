using AutoServis.Data;
using AutoServis.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoServis.Controllers
{
    public class ServiceTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServiceTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // 🔓 SVI (gost, customer, admin) MOGU VIDJETI POPIS USLUGA
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var services = await _context.ServiceTypes
                .Where(s => s.IsActive)
                .OrderBy(s => s.Name)
                .ToListAsync();

            return View(services);
        }

        // 🔒 SAMO ADMIN MOŽE VIDJETI DETALJE
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType == null)
                return NotFound();

            return View(serviceType);
        }

        // 🔒 SAMO ADMIN
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // 🔒 SAMO ADMIN
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ServiceType serviceType)
        {
            if (!ModelState.IsValid)
                return View(serviceType);

            _context.ServiceTypes.Add(serviceType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // 🔒 SAMO ADMIN
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType == null)
                return NotFound();

            return View(serviceType);
        }

        // 🔒 SAMO ADMIN
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, ServiceType serviceType)
        {
            if (id != serviceType.Id)
                return NotFound();

            if (!ModelState.IsValid)
                return View(serviceType);

            _context.Update(serviceType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // 🔒 SAMO ADMIN
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType == null)
                return NotFound();

            return View(serviceType);
        }

        // 🔒 SAMO ADMIN
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var serviceType = await _context.ServiceTypes.FindAsync(id);
            if (serviceType != null)
            {
                _context.ServiceTypes.Remove(serviceType);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
