using System.Diagnostics;
using ClimbingPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClimbingPage.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //Link to the index page
        public IActionResult Index()
        {
            return View();
        }

        // link to the lesson calculator page
        public IActionResult Lessons()
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
