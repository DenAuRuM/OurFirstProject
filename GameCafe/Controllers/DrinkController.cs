using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GameCafe.Data;
using GameCafe.Managers;
using GameCafe.Storage.Entity;

namespace GameCafe.Controllers
{
    public class DrinkController : Controller
    {
        private readonly IDrinkManager _manager;

        public DrinkController(IDrinkManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var drinks = await _manager.GetAll();
            return View(drinks);
        }

    }
}
