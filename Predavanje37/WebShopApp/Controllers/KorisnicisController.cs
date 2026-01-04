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
    public class KorisnicisController : Controller
    {
        private readonly WebshopdbContext _context;

        public KorisnicisController(WebshopdbContext context)
        {
            _context = context;
        }

        // GET: Korisnicis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Korisnicis.ToListAsync());
        }

        // GET: Korisnicis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnici = await _context.Korisnicis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return View(korisnici);
        }

        // GET: Korisnicis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Korisnicis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ime,Prezime,Email,AdresaDostave,Kontakt,Napomena")] Korisnici korisnici)
        {
            if (ModelState.IsValid)
            {
                _context.Add(korisnici);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(korisnici);
        }

        // GET: Korisnicis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnici = await _context.Korisnicis.FindAsync(id);
            if (korisnici == null)
            {
                return NotFound();
            }
            return View(korisnici);
        }

        // POST: Korisnicis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ime,Prezime,Email,AdresaDostave,Kontakt,Napomena")] Korisnici korisnici)
        {
            if (id != korisnici.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(korisnici);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KorisniciExists(korisnici.Id))
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
            return View(korisnici);
        }

        // GET: Korisnicis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var korisnici = await _context.Korisnicis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (korisnici == null)
            {
                return NotFound();
            }

            return View(korisnici);
        }

        // POST: Korisnicis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var korisnici = await _context.Korisnicis.FindAsync(id);
            if (korisnici != null)
            {
                _context.Korisnicis.Remove(korisnici);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KorisniciExists(int id)
        {
            return _context.Korisnicis.Any(e => e.Id == id);
        }
    }
}
