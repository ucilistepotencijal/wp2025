using Microsoft.AspNetCore.Mvc;
using Modeli.Models;

namespace Modeli.Controllers
{
    public class OsobeController : Controller
    {
        public IActionResult PopuniOsobu()
        {
            return View();
        }

        [HttpPost]

        public IActionResult PrikaziOsobu(Osoba osoba)
        {
            return View(osoba);
        }
    }
}
