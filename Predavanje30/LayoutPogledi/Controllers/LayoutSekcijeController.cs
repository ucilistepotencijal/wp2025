using Microsoft.AspNetCore.Mvc;

namespace LayoutPogledi.Controllers
{
    public class LayoutSekcijeController : Controller
    {
        public IActionResult Stranica1()
        {
            return View();
        }

        public IActionResult Stranica2()
        {
            return View();

        }
    }
}
