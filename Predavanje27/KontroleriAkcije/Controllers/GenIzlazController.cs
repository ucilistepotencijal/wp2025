using Microsoft.AspNetCore.Mvc;

namespace KontroleriAkcije.Controllers
{
    public class GenIzlazController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Vrijeme = DateTime.Now.ToShortTimeString();
            TempData["broj1"] = 5;
            TempData["broj2"] = 10;

            return View("PrimjerPogleda");
        }

        public RedirectResult PreusmjeriNaIndex()
        {
            return Redirect("/Home/Index");
        }

        public RedirectToActionResult PreusmjeriNaAkcijuIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
