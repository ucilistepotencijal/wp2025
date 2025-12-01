using Microsoft.AspNetCore.Mvc;
using Modeli.Models;

namespace Modeli.Controllers
{
    public class Osobe2Controller : Controller
    {

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Details(Osoba osoba)
        {
            return View(osoba);
        }
    }
}