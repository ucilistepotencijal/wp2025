using Microsoft.AspNetCore.Mvc;

namespace Kalkulator.Controllers
{
    public class KalkulatorController : Controller
    {
        [HttpGet]
        public IActionResult Izracunaj()
        {
            ViewBag.Broj1 = "";
            ViewBag.Broj2 = "";
            ViewBag.Rezultat = null;
            ViewBag.Greska = null;
            return View();
        }
        [HttpPost]
        public IActionResult Izracunaj(double broj1, double broj2, string operacija)
        {

            ViewBag.Broj1 = broj1;
            ViewBag.Broj2 = broj2;

            double rezultat = 0;
            switch (operacija)
            {
                case "Zbrajanje":
                    rezultat = broj1 + broj2;
                    break;
                case "Oduzimanje":
                    rezultat = broj1 - broj2;
                    break;
                case "Mnozenje":
                    rezultat = broj1 * broj2;
                    break;
                case "Dijeljenje":
                    if (broj2 != 0)
                    {
                        rezultat = broj1 / broj2;
                    }
                    else
                    {
                        ViewBag.Greska = "Dijeljenje s nulom nije dozvoljeno.";
                        return View();
                    }
                    break;
                default:
                    ViewBag.Greska = "Nepoznata operacija.";
                    return View();
            }
            ViewBag.Rezultat = rezultat;
            return View();
        }
    }
}
