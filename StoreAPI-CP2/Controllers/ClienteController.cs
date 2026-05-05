using Microsoft.AspNetCore.Mvc;

namespace StoreAPI_CP2.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
