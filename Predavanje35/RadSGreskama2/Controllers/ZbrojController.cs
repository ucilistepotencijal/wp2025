using Microsoft.AspNetCore.Mvc;
using RadSGreskama2.Models;

namespace RadSGreskama2.Controllers
{
    public class ZbrojController : Controller
    {
        public IActionResult Zbroj()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Zbroj(decimal brojA, decimal brojB)
        {
            if (brojA == null || brojB == null || !ModelState.IsValid)
            {
                return View("Error", new ErrorViewModel());
            }
            decimal rezultat = brojA + brojB;
            ViewBag.Rezultat = rezultat;

            return View();
        }
    }
}
