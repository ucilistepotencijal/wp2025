using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            // Include details and the related Proizvod so Model.NarudzbeDetaljis[*].Proizvod is populated
            var narudzba = _context.Narudzbes
                .Include(n => n.NarudzbeDetaljis)
                    .ThenInclude(d => d.Proizvod)
                .FirstOrDefault(n => n.Id == orderId);

            if (narudzba == null)
            {
                return NotFound();
            }

            // keep compatibility with existing views that use ViewBag.Detalji
            ViewBag.Detalji = narudzba.NarudzbeDetaljis?.ToList() ?? new List<NarudzbeDetalji>();
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