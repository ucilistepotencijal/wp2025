using Microsoft.AspNetCore.Mvc;
using RadSGreskama.Models;

namespace RadSGreskama.Controllers
{
    public class BezHvatanjaKalkulatorController : Controller
    {
        public IActionResult Index()
        {
            Kalkulator kalkulator = new Kalkulator()
            {
                DrugiBroj = 0,
                PrviBroj = 0
            };

            return View(kalkulator);
        }

        [HttpPost]
        public IActionResult Dijeli(Kalkulator kalkulator)
        {
            if (kalkulator.DrugiBroj == 0)
            {
                ModelState.AddModelError(nameof(kalkulator.DrugiBroj), "Drugi broj ne smije biti 0.");
                return View("Index", kalkulator);
            }

            if (kalkulator.DrugiBroj == 0)
            {
                ModelState.AddModelError(nameof(kalkulator.DrugiBroj), "Drugi broj ne smije biti 0.");
                return View("Index", kalkulator);
            }

            kalkulator.Dijeli();
            return View("Index", kalkulator);
        }

        [Route("/Error")]
        public IActionResult Error()
        {
            return View();
        }

    }
}
