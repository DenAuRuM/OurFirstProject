using Microsoft.AspNetCore.Http;
using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Controllers
{
    public class TariffController : Controller
    {
        private readonly GameCafeContext _context;

        public TariffController(GameCafeContext context)
        {
            _context = context;
        }


        public ActionResult Index()
        {
            return View(_context.Tariffs.ToList());
        }

        // GET: TariffController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TariffController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TariffController/Create
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

        // GET: TariffController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TariffController/Edit/5
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

        // GET: TariffController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TariffController/Delete/5
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
