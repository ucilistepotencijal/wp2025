using Microsoft.AspNetCore.Mvc;

namespace RadSGreskama2.Controllers
{
    public class DijeljenjeController : Controller
    {
        public IActionResult Dijeli()
        {
            try
            {
                decimal brojA = decimal.Parse(Request.Query["brojA"]);
                decimal brojB = decimal.Parse(Request.Query["brojB"]);
                decimal rezultat = brojA / brojB;
                ViewBag.Rezultat = rezultat;
            }
            catch (Exception ex)
            {
                ViewBag.Greska = "Došlo je do greške prilikom dijeljenja: " + ex.Message;
            }
            return View();
        }

        public IActionResult Dijeli2(decimal brojA, decimal brojB)
        {
            try
            {
                decimal rezultat = brojA / brojB;
                ViewBag.Rezultat = rezultat;
            }
            catch (Exception ex)
            {
                ViewBag.Greska = "Došlo je do greške prilikom dijeljenja: " + ex.Message;
            }
            return View("Dijeli");
        }
    }
}
