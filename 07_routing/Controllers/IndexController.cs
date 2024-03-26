using Microsoft.AspNetCore.Mvc;

namespace _07_routing.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
