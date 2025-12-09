using Microsoft.AspNetCore.Mvc;

namespace Vjezba.Controllers
{
    public class TocanOdgovorController : Controller
    {
        public IActionResult ProvjeriOdgovor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ProvjeriOdgovor(string odgovor)
        {
            if (odgovor == "8")
            {
                ViewBag.Poruka = "Točno";
            }
            else
            {
                ViewBag.Poruka = "Netočno";
            }
            return View();
        }
    }
}
