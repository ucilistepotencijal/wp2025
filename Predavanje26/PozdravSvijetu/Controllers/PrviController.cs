using Microsoft.AspNetCore.Mvc;

namespace PozdravSvijetu.Controllers
{
    public class PrviController : Controller
    {
        public string Pozdrav()
        {
            return "Pozdrav s prvog kontrolera.";
        }

        public IActionResult ImeStroja()
        {
            string imeStroja = "<h2>" + Environment.MachineName + "</h2>";
            return Content(imeStroja, "text/html");
        }
    }
}
