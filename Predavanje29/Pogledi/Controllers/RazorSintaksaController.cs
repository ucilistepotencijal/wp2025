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
            string[] voce = new string[] { "jabuka", "banana", "kruška", "breskva", "šljiva" };
            return View(voce);
        }

        public IActionResult WhilePogled()
        {
            string[] povrce = new string[] { "mrkva", "rajčica", "krastavac", "zelena salata", "celer" };
            return View(povrce);
        }
    }
}
