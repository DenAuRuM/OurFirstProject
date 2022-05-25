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

        // GET: VideogameController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VideogameController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideogameController1/Create
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

        // GET: VideogameController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VideogameController1/Edit/5
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

        // GET: VideogameController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideogameController1/Delete/5
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
