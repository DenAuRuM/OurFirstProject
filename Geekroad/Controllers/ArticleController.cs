using Geekroad.Managers.Articles;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geekroad.Storage;

namespace Geekroad.Controllers
{
    public class ArticleController : Controller
    {

        private IArticleManager _manager;

        public ArticleController(IArticleManager manager)
        {
            _manager = manager;
        }
        public IActionResult Index()
        {
            var articles = _manager.GetAll();
            return View(articles);
        }

        public IActionResult Article(Guid articleId)
        {
            return View(articleId);
        }
    }
}
