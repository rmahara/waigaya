using _04_4_ASPCoreDI.Models;
using _04_4_ASPCoreDI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _04_4_ASPCoreDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherService weatherService;
        private readonly IMessengerService messengerService;

        public HomeController(ILogger<HomeController> logger,
            IWeatherService weatherService,
            IMessengerService messengerService)
        {
            _logger = logger;
            this.weatherService = weatherService;
            this.messengerService = messengerService;
        }

        public IActionResult Index()
        {
            string message = messengerService.GetMessage();

            return View(null, message);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
