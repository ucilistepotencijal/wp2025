using Microsoft.AspNetCore.Mvc;

namespace PozdravSvijetu.Controllers
{
    public class PozdravSvijeteController : Controller
    {
        public IActionResult Index()
        {
            string model = "Pozdrav svijetu iz ASP.NET Core MVC!";
            return View((Object)model);
        }

        public IActionResult Operacija() 
        {
            string izraz = "Rezultat operacije 4 + 3 je: ";
            return View((Object)izraz);
        }
    }
}
