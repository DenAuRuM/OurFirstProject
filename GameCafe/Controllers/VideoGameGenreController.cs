using Microsoft.AspNetCore.Http;
using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Controllers
{
    public class VideoGameGenreController : Controller
    {
        private readonly GameCafeContext _context;

        public VideoGameGenreController(GameCafeContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {
            return View(_context.VideoGameGenres.ToList());
        }

        // GET: VideoGameGenreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VideoGameGenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VideoGameGenreController/Create
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

        // GET: VideoGameGenreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VideoGameGenreController/Edit/5
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

        // GET: VideoGameGenreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VideoGameGenreController/Delete/5
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
