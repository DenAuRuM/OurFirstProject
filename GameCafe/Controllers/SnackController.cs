using Microsoft.AspNetCore.Http;
using GameCafe.Data;
using GameCafe.Managers;
using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Controllers
{
    public class SnackController : Controller
    {
        private readonly ISnackManager _manager;

        public SnackController(ISnackManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var Snacks = await _manager.GetAll();
            return View(Snacks);
        }
    }
}
