using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    public class KontekstController : Controller
    {
        public string Index()
        {
            return DateTime.Now.ToLongDateString();
        }

        public string QueryPodaci(string ime, string prezime)
        {
            return ime + " " + prezime;
        }

        public IActionResult QueryPodaci2()
        {
            string ime = Request.Query["ime"];
            string prezime = Request.Query["prezime"];
            string combined = ime + " " + prezime;

            // Ensure the response uses UTF-8 so Croatian characters display correctly            
            return Content(combined, "text/html; charset=utf-8");
        }

        public IActionResult PodaciRute() {
            string kontroler = (string)RouteData.Values["controller"];
            string akcija = (string)RouteData.Values["action"];
            string id = (string)RouteData.Values["id"];// ?? "nema id-a";

            string rezultat = $"Kontroler: {kontroler} <br>Akcija: {akcija} <br>Id: {id}";
            return Content(rezultat, "text/html; charset=utf-8");
        }
    }
}
