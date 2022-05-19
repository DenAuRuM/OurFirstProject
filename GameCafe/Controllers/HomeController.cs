using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GameCafe.Data;

namespace GameCafe.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameCafeContext _context;

        public HomeController(GameCafeContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Tariffs.ToList());
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