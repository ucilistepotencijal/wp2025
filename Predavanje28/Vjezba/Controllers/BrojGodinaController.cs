using Microsoft.AspNetCore.Mvc;

namespace Vjezba.Controllers
{
    public class BrojGodinaController : Controller
    {
        [HttpGet]
        public IActionResult RacunajBrojGodina()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RacunajBrojGodina(DateTime datumRodjenja)
        {
            int brojGodina = DateTime.Now.Year - datumRodjenja.Year;
            if (DateTime.Now < datumRodjenja.AddYears(brojGodina))
            {
                brojGodina--;
            }
            ViewBag.BrojGodina = brojGodina;
            return View();
        }
    }
}
