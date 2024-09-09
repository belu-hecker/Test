using ITNewsLetter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ITNewsLetter.Controllers
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
            ViewBag.vbMenuActive = "1";
            return View();
        }
        public IActionResult FeedBack()
        {
            ViewBag.vbMenuActive = "2";
            return View();
        }
        public IActionResult SepAddition()
        {
            ViewBag.vbMenuActive = "1";
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