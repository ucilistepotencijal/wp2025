using HtmlHelperi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HtmlHelperi.Controllers
{
    public class HtmlHelpersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private string[] mjesta = new string[]
        {
            "Zagreb",
            "Split",
            "Rijeka",
            "Osijek",
            "Zadar"
        };

        public IActionResult FormHelper()
        {
            ViewBag.Mjesta = mjesta;
            return View(new Osoba());
        }

        [HttpPost]
        public IActionResult FormHelper(Osoba osoba)
        {
            ViewBag.Mjesta = mjesta;
            ViewBag.Poruka = "Podaci uspješno uneseni!";
            return View(osoba);
        }
    }
}
