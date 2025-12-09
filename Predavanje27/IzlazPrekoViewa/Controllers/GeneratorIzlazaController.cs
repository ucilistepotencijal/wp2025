using Microsoft.AspNetCore.Mvc;

namespace IzlazPrekoViewa.Controllers
{
    public class GeneratorIzlazaController : Controller
    {
        public IActionResult PopisKosarice()
        {
            return View();
        }

        public ViewResult ListaArtikala()
        {
            ViewBag.Artikl1 = "Laptop";
            ViewBag.Artikl2 = "Tablet";
            return View();
        }

        public IActionResult ListaArtikala2()
        {
            List<string> artikli = new List<string>
            {
                "Monitor",
                "Tipkovnica",
                "Miš",
                "Slušalice",
                "Web kamera"
            };
            ViewBag.Artikli = artikli;
            return View();
        }

        public IActionResult RedirektNaPogled(string id)
        {
            if (id.ToLower() == "kosarica")
            {
                return View("PopisKosarice");
            }

            List<string> artikli = new List<string>
            {
                "Monitor",
                "Tipkovnica",
                "Miš",
            };
            ViewBag.Artikli = artikli;
            return View("ListaArtikala2");
        }
    }
}
