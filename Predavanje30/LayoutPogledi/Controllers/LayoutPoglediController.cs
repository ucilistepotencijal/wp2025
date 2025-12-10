using Microsoft.AspNetCore.Mvc;

namespace LayoutPogledi.Controllers
{
    public class LayoutPoglediController : Controller
    {
        public IActionResult PogledSaLayoutom()
        {
            return View();
        }

        public IActionResult PogledSaSekcijama()
        {
            return View();
        }
    }
}
