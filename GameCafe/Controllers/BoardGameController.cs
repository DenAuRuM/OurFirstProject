using GameCafe.Data;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Controllers
{
    public class BoardGameController : Controller
    {
        private readonly GameCafeContext _context;

        public BoardGameController(GameCafeContext context)
        {
            _context = context;
        }

        // GET: BoardGameController
        public ActionResult Index()
        {
            return View(_context.BoardGames.ToList());
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
