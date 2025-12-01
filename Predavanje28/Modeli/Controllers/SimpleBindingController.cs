using Microsoft.AspNetCore.Mvc;

namespace Modeli.Controllers
{
    public class SimpleBindingController : Controller
    {
        public IActionResult SimpleBindMetoda()
        {
            return View("SimpleBind");
        }

        [HttpPost]
        public IActionResult SimpleBindMetoda(string ime)
        {
            string pozdravnaPoruka = $"Dobrodošli, {ime}!";
            return View("SimpleBind", pozdravnaPoruka);
        }
    }
}
