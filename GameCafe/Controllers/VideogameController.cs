using Microsoft.AspNetCore.Http;
using GameCafe.Data;
using GameCafe.Managers;
using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Controllers
{
    public class VideogameController : Controller
    {
        private readonly IVideogameManager _manager;
        public VideogameController(IVideogameManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var games = await _manager.GetAll();
            return View(games);
        }
    }
}
