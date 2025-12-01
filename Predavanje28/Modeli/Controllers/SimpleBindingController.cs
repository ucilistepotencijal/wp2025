using Microsoft.AspNetCore.Mvc;

namespace Modeli.Controllers
{
    public class SimpleBindingController : Controller
    {
        public IActionResult SimpleBindMetoda()
        {
            return View("SimpleBind");
        }

        [HttpGet]

        public IActionResult SimpleBindMetoda(string ime)
        {
            string pozdravPoruka = $"Dobrodošli, {ime}!";
            return View("SimpleBind", pozdravPoruka);
        }
    }
}
