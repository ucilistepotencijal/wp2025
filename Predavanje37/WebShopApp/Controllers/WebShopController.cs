using Microsoft.AspNetCore.Mvc;
using WebShopApp.Models;

namespace WebShopApp.Controllers
{
    public class WebShopController : Controller
    {
        private readonly WebshopdbContext _context;
        private const string CART_KEY = "proizvodi";    
        public WebShopController(WebshopdbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Proizvodi> proizvodi = _context.Proizvodis.ToList();

            int cartCount = 0;
            var sessionData = HttpContext.Session.GetString(CART_KEY);
            if (sessionData != null)
            {
                var proizvodIds = System.Text.Json.JsonSerializer.Deserialize<List<int>>(sessionData);
                if (proizvodIds != null)
                {
                    cartCount = proizvodIds.Count;
                }
            }
            ViewBag.CartCount = cartCount;
            return View(proizvodi);
        }
    }
}
