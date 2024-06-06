using Microsoft.AspNetCore.Mvc;

namespace Pexinxa.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
