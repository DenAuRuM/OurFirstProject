using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geekroad.Storage;
using Geekroad.Storage.Entity;

namespace Geekroad.Managers.Articles
{
    public class ArticleManager : IArticleManager
    {
        private ContextExample _context;

        
        public ArticleManager(ContextExample context)
        {
            _context = context;
        }

        public void Delete(Guid ArticleId)
        {
            var article = _context.Articles.FirstOrDefault(art => art.Id == ArticleId);

            if (article != null)
                _context.Articles.Remove(article);
        }

        public ICollection<ArticleProto> GetAll()
        {
            return _context.Articles;
        }

        public ICollection<ArticleProto> GetArticleByAuthor(Guid authorId)
        {
            return _context.Articles.Where(art => art.Author.Id == authorId).ToList();
        }


        public ICollection<ArticleProto> GetArticleById(Guid Id)
        {
            return _context.Articles.Where(art => art.Id == Id).ToList();
        }
    }


}
