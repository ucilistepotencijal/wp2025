using Microsoft.AspNetCore.Mvc;
using Artikli.Models;
using System.Text.Json;
using System.Collections.Generic;

namespace Artikli.Controllers
{
    public class ListaArtikalaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UnesiArtikl()
        {
            ViewBag.Kategorije = new string[]
            {
                "Hrana", "Piće", "Elektronika", "Odjeća"
            };

            return View(new Artikl());
        }

        [HttpPost]
        public IActionResult DodajArtikl(Artikl artikl)
        {
            ViewBag.Kategorije = new string[]
            {
                "Hrana", "Piće", "Elektronika", "Odjeća"
            };

            if (!ModelState.IsValid)
            {

                return View("UnesiArtikl", artikl);
            }

            var listaJson = HttpContext.Session.GetString("Artikli");
            List<Artikl> lista = string.IsNullOrEmpty(listaJson)
                ? new List<Artikl>()
                : JsonSerializer.Deserialize<List<Artikl>>(listaJson);

            lista.Add(artikl);

            HttpContext.Session.SetString("Artikli", JsonSerializer.Serialize(lista));

            return View("DodajArtikl", lista);
        }


        public IActionResult DodajArtikl()
        {
            var listaJson = HttpContext.Session.GetString("Artikli");
            List<Artikl> lista = string.IsNullOrEmpty(listaJson) 
                ? new List<Artikl>() 
                : JsonSerializer.Deserialize<List<Artikl>>(listaJson);
            return View(lista);
        }

    }
}
