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
            kalkulator.Dijeli();
            return View("Index", kalkulator);
        }

    }
}
