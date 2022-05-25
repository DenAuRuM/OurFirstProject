using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GameCafe.Data;
using GameCafe.Managers;
using GameCafe.Storage.Entity;

namespace GameCafe.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieManager _manager;

        public MovieController(IMovieManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var Movies = await _manager.GetAll();
            return View(Movies);
        }
    }
}
