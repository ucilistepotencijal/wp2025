using Microsoft.AspNetCore.Mvc;
using NarudzbaArtikla.Models;

namespace NarudzbaArtikla.Controllers
{
public class ArtiklController : Controller
    {
        [HttpGet]
        public ActionResult NaruciArtikal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NaruciArtikal(Artikl a)
        {
            if (a.Kolicina > 10)
            {
                ViewBag.Poruka = "Nedovoljna količina na skladištu!";
            }
            else
            {
                decimal ukupno = a.Cijena * a.Kolicina;
                ViewBag.Poruka = string.Format("Uspješna narudžba! Ukupna cijena: {0} EUR", ukupno);
            }

            return View(a);
        }
    }