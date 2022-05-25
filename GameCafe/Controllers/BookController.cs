using GameCafe.Data;
using GameCafe.Managers;
using Microsoft.AspNetCore.Mvc;


namespace GameCafe.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookManager _manager;
        public BookController(IBookManager manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Index()
        {
            var books = await _manager.GetAll();
            return View(books);
        }
    }
}
