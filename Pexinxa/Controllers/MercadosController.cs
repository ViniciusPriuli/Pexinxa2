using Microsoft.AspNetCore.Mvc;

namespace Pexinxa.Controllers
{
    public class MercadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
