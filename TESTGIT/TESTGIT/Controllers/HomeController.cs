using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TESTGIT.Models;

namespace TESTGIT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string draganinString = "Cao Dragana";

            string filipovString = "Cao Filipeee OVO JE TEST IZMENA";

            ViewBag.fString = filipovString;
            return View();
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