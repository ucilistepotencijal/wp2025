using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebShopApp.Models;

namespace WebShopApp.Controllers
{
    public class CartController : Controller
    {
        private readonly WebshopdbContext _context;
        private const string CART_KEY = "proizvodi";
        public CartController(WebshopdbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Proizvodi> proizvodi = new ();
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
            return View(proizvodi);
        }

        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            List<int> proizvodIds = new ();
            var sessionData = HttpContext.Session.GetString(CART_KEY);
            if (sessionData != null)
            {
                var existingIds = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sessionData);
                if (existingIds != null)
                {
                    proizvodIds = existingIds;
                }
            }
            proizvodIds.Add(id);
            sessionData = System.Text.Json.JsonSerializer.Serialize(proizvodIds);
            HttpContext.Session.SetString(CART_KEY, sessionData);
            return RedirectToAction("Index", "WebShop");
        }

        public RedirectToActionResult RemoveFromCart(int id)
        {
            var sessionData = HttpContext.Session.GetString(CART_KEY);
            if (sessionData != null)
            {
                var proizvodIds = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sessionData);
                if (proizvodIds != null && proizvodIds.Contains(id))
                {
                    proizvodIds.Remove(id);
                    sessionData = System.Text.Json.JsonSerializer.Serialize(proizvodIds);
                    HttpContext.Session.SetString(CART_KEY, sessionData);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
