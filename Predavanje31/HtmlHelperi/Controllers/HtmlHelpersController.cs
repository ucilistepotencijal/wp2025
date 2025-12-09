using HtmlHelperi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            "Varaždin"
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

        public IActionResult StrongTypedHelper()
        {
            ViewBag.Mjesta = mjesta;    
            return View(new Osoba());
        }

        [HttpPost]
        public IActionResult StrongTypedHelper(Osoba osoba)
        {
            ViewBag.Mjesta = mjesta;
            ViewBag.Poruka = "Podaci uspješno uneseni!";
            return View(osoba);
        }


        public IActionResult Generated()
        {
            ViewBag.Mjesta = mjesta.Select(m => new SelectListItem { Value = m, Text = m }).ToList();
            return View(new Osoba());
        }

        [HttpPost]
        public IActionResult Generated(Osoba osoba)
        {
            ViewBag.Mjesta = mjesta.Select(m => new SelectListItem { Value = m, Text = m }).ToList();
            ViewBag.Poruka = "Podaci uspješno uneseni!";
            return View(osoba);
        }

    }
}
