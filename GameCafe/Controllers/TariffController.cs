using Microsoft.AspNetCore.Http;
using GameCafe.Data;
using GameCafe.Managers;
using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Controllers
{
    public class TariffController : Controller
    {
        private readonly ITariffManager _manager;
        public TariffController(ITariffManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var Tariffs = await _manager.GetAll();
            return View(Tariffs);
        }
    }
}
