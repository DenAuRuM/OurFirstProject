using Microsoft.AspNetCore.Http;
using GameCafe.Data;
using GameCafe.Storage.Entity;
using GameCafe.Managers;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Controllers
{
    public class PlaceController : Controller
    {
        private readonly IPlaceManager _manager;

        public PlaceController(IPlaceManager manager)
        {
            _manager = manager;
        }


        public async Task<IActionResult> Index()
        {
            var places = await _manager.GetAll();
            return View(places);
        }
    }
}
