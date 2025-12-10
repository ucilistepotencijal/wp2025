using Microsoft.AspNetCore.Mvc;
using Validacije.Models;

namespace Validacije.Controllers
{
    public class ValidacijeController : Controller
    {
        public IActionResult IzdavanjeRacuna()
        {
            Racun racun = new Racun() { DatumRacuna = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year };
            return View(racun);
        }

        [HttpPost]
        public IActionResult IzdavanjeRacuna(Racun racun)
        {
            if (string.IsNullOrEmpty(racun.BrojRacuna))
            {
                ModelState[nameof(racun.BrojRacuna)].Errors.Clear();
                ModelState.AddModelError("BrojRacuna", "Broj računa je obavezan");
            }
            if (string.IsNullOrEmpty(racun.Zaposlenik))
            {
                ModelState[nameof(racun.Zaposlenik)].Errors.Clear();
                ModelState.AddModelError("Zaposlenik", "Zaposlenik je obavezan");
            }
            if (string.IsNullOrEmpty(racun.Kupac))
            {
                ModelState[nameof(racun.Kupac)].Errors.Clear();
                ModelState.AddModelError("Kupac", "Kupac je obavezan");
            }
            if (ModelState.IsValid)
            {
                return View("RacunIzdan", racun);
            }
            return View(racun);
        }

        public IActionResult MetaIzdavanjeRacuna()
        {
            MetaRacun racun = new MetaRacun() { DatumRacuna = DateTime.Now, BrojRacuna = "/" + DateTime.Now.Year };
            return View();
        }

        [HttpPost]
        public IActionResult MetaIzdavanjeRacuna(MetaRacun racun)
        {
            if (ModelState.IsValid)
            {
                return View("MetaRacunIzdan", racun);
            }
            return View(racun);
        }
    }       
}
