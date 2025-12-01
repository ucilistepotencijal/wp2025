using Microsoft.AspNetCore.Mvc;

namespace Pogledi.Controllers
{
    public class RazorSintaksaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SwitchPogled()
        {
            return View();
        }

        public IActionResult ForPogled()
        {
            string[] voce = new string["Jabuka", "Banana", "Kruska", "Ananas", "Jagoda"];
            return View(voce);
        }

        public IActionResult WhilePogled()
        {
            string[] povrce = new string["Kupus", "Krompir", "Celer", "Pasulj", "Boranija"];
            return View(povrce);
        }
    }
}
