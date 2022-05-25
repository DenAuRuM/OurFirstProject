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

        // GET: DrinkController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DrinkController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DrinkController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DrinkController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DrinkController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DrinkController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DrinkController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
