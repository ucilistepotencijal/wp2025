using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using WebShopApp.Models;

namespace WebShopApp.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly WebshopdbContext _context;
        private const string CART_KEY = "proizvodi";
        private const string ORDER_KEY = "narudzbaId";
        public CheckoutController(WebshopdbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(Korisnici korisnik)
        {
            if (!ModelState.IsValid)
            {
                return View(korisnik);
            }  
            _context.Korisnicis.Add(korisnik);
            _context.SaveChanges();
            return RedirectToAction("CreateOrder", new { korisnikId = korisnik.Id });
        }

        public IActionResult CreateOrder(int korisnikId)
        {
            List<Proizvodi> proizvodi = new();
            var sessionData = HttpContext.Session.GetString(CART_KEY);
            if (sessionData != null)
            {
                var proizvodIds = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sessionData);
                if (proizvodIds != null && proizvodIds.Count > 0)
                {
                    proizvodi = _context.Proizvodis
                        .Where(p => proizvodIds.Contains(p.Id))
                        .ToList();
                }
            }
            Narudzbe novaNarudzba = new()
            {
                KorisnikId = korisnikId,
                DatumKreiranja = DateTime.Now,
                JeDostavljeno = false,

            };
            _context.Narudzbes.Add(novaNarudzba);
            _context.SaveChanges();
            foreach (var proizvod in proizvodi)
            {
                NarudzbeDetalji detalj = new()
                {
                    NarudzbaId = novaNarudzba.Id,
                    ProizvodId = proizvod.Id,
                    Kolicina = 1,
                    JedCijena = proizvod.Cijena
                };
                _context.NarudzbeDetaljis.Add(detalj);
            }
            _context.SaveChanges();
            HttpContext.Session.SetString(ORDER_KEY, novaNarudzba.Id.ToString());
            return RedirectToAction("OrderDetails", new { orderId = novaNarudzba.Id });
        }

        public IActionResult OrderDetails(int orderId)
        {
            var narudzba = _context.Narudzbes
                .Where(n => n.Id == orderId)
                .FirstOrDefault();
            if (narudzba == null)
            {
                return NotFound();
            }
            var detalji = _context.NarudzbeDetaljis
                .Where(d => d.NarudzbaId == orderId)
                .ToList();
            ViewBag.Detalji = detalji;
            ViewBag.Narudba = narudzba;
            return View(narudzba);
        }

        public IActionResult Confirm()
        {
            HttpContext.Session.Remove(CART_KEY);   
            HttpContext.Session.Remove(ORDER_KEY);

            return RedirectToAction("Index", "WebShop");
        }
    }
}
