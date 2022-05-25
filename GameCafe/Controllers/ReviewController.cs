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
    }
}
