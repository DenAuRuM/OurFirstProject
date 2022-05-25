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

        // GET: BoardGameController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BoardGameController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BoardGameController/Create
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

        // GET: BoardGameController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BoardGameController/Edit/5
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

        // GET: BoardGameController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BoardGameController/Delete/5
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
