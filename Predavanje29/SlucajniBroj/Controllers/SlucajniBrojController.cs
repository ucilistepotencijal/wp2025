using Microsoft.AspNetCore.Mvc;

namespace SlucajniBroj.Controllers
{
    public class SlucajniBrojController : Controller
    {
        public IActionResult RazvrstajSlucajniBroj()
        {
            Random rand = new Random();
            int slucajniBroj = rand.Next(1, 1000);
            return View(slucajniBroj);
        }
    }
}


