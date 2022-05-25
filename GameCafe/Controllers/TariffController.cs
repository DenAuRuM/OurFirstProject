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
