using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geekroad.Storage.Entity;

namespace Geekroad.Managers.Articles
{
    public interface IArticleManager
    {
        ICollection<Article> GetAll();
        ICollection<Article> GetArticleByAuthor(Guid authorId);
        ICollection<Article> GetArticleById(Guid Id);
        void Delete(Guid ArticleId); 
    }
}
