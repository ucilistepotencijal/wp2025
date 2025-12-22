using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebShopApp.Models;

namespace WebShopApp.Controllers
{
    public class ProizvodiController : Controller
    {
        private readonly WebshopdbContext _context;

        public ProizvodiController(WebshopdbContext context)
        {
            _context = context;
        }

        // GET: Proizvodi
        public async Task<IActionResult> Index()
        {
            var webshopdbContext = _context.Proizvodis.Include(p => p.MjereProizvoda);
            return View(await webshopdbContext.ToListAsync());
        }

        // GET: Proizvodi/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvodi = await _context.Proizvodis
                .Include(p => p.MjereProizvoda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            return View(proizvodi);
        }

        // GET: Proizvodi/Create
        public IActionResult Create()
        {
            ViewData["MjereProizvoda"] = new SelectList(_context.MjereProizvoda, "Naziv", "Naziv");
            return View();
        }

        // POST: Proizvodi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MjereProizvodaId,VrijemeKreiranja,Naziv,Cijena,Dostupan")] Proizvodi proizvodi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(proizvodi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MjereProizvodaId"] = new SelectList(_context.MjereProizvoda, "Id", "Id", proizvodi.MjereProizvodaId);
            return View(proizvodi);
        }

        // GET: Proizvodi/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvodi = await _context.Proizvodis.FindAsync(id);
            if (proizvodi == null)
            {
                return NotFound();
            }
            ViewData["MjereProizvodaId"] = new SelectList(_context.MjereProizvoda, "Id", "Id", proizvodi.MjereProizvodaId);
            return View(proizvodi);
        }

        // POST: Proizvodi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MjereProizvodaId,VrijemeKreiranja,Naziv,Cijena,Dostupan")] Proizvodi proizvodi)
        {
            if (id != proizvodi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(proizvodi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProizvodiExists(proizvodi.Id))
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
            ViewData["MjereProizvodaId"] = new SelectList(_context.MjereProizvoda, "Id", "Id", proizvodi.MjereProizvodaId);
            return View(proizvodi);
        }

        // GET: Proizvodi/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var proizvodi = await _context.Proizvodis
                .Include(p => p.MjereProizvoda)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (proizvodi == null)
            {
                return NotFound();
            }

            return View(proizvodi);
        }

        // POST: Proizvodi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var proizvodi = await _context.Proizvodis.FindAsync(id);
            if (proizvodi != null)
            {
                _context.Proizvodis.Remove(proizvodi);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProizvodiExists(int id)
        {
            return _context.Proizvodis.Any(e => e.Id == id);
        }
    }
}
