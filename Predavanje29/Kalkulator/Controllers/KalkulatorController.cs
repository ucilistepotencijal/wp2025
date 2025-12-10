using Microsoft.AspNetCore.Mvc;

namespace Kalkulator.Controllers
{
    public class KalkulatorController : Controller
    {
        public IActionResult Izracunaj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Izracunaj(decimal broj1, decimal broj2, string operacija)
        {
            ViewBag.Broj1 = broj1;
            ViewBag.Broj2 = broj2;
            ViewBag.Operacija = operacija;
            decimal rezultat = 0;
            switch (operacija)
            {
                case "+":
                    rezultat = broj1 + broj2;
                    break;
                case "-":
                    rezultat = broj1 - broj2;
                    break;
                case "*":
                    rezultat = broj1 * broj2;
                    break;
                case "/":
                    if (broj2 != 0)
                    {
                        rezultat = broj1 / broj2;
                    }
                    else
                    {
                        return View((object)"= N/A");
                    }
                    break;
            }
            return View((object)("= " + rezultat.ToString()));
        }
    }
}
