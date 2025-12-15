using Microsoft.AspNetCore.Mvc;

namespace RadSGreskama2.Controllers
{
    public class KorijenController : Controller
    {
        public IActionResult Korijen()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Korijen(double broj)
        {
            try
            {               
                decimal rezultat = (decimal)Math.Sqrt(broj);
                ViewBag.Rezultat = rezultat;
            }
            catch (Exception ex)
            {
                ViewBag.Greska = "Došlo je do greške prilikom izračunavanja korijena: " + ex.Message;
            }
            return View();
        }
    }
}
