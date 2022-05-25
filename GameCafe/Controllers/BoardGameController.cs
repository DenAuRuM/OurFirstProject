using GameCafe.Data;
using GameCafe.Managers;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Controllers
{
    public class BoardGameController : Controller
    {
        private readonly IBoardGameManager _manager;

        public BoardGameController(IBoardGameManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var boardgames = await _manager.GetAll();
            return View(boardgames);
        }
       
    }
}
