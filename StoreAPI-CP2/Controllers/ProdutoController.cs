using Microsoft.AspNetCore.Mvc;

namespace StoreAPI_CP2.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
