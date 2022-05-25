using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;
using GameCafe.Managers;

namespace GameCafe.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewManager _manager;

        public ReviewController(IReviewManager manager)
        {
            _manager = manager;
        }



        public async Task<IActionResult> Index()
        {
            var reviews = await _manager.GetAll();
            return View(reviews);
        }


        // GET: ReviewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReviewController/Create
        public IActionResult CreatePage()
        {
            return View();
        }


        [HttpPost]
        [Route("reviews")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Author,Text")] Review review)
        {
            await _manager.Create(review.Text, review.Author);
            return RedirectToAction(nameof(Index));
        }


        // GET: ReviewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ReviewController/Edit/5
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

        // GET: ReviewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReviewController/Delete/5
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
