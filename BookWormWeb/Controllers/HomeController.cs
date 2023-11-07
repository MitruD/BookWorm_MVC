using BookWormWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookWormWeb.Controllers
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
            //if not indicated in brackets, returns the view with the name of action method,
            //in this case - Index, from folder Views, next it's child folder with the same name as controller - Home.
            //return View("Privacy") - will open Privacy page;
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