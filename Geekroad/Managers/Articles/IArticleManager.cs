using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geekroad.Storage.Entity;

namespace Geekroad.Managers.Articles
{
    public interface IArticleManager
    {
        ICollection<ArticleProto> GetAll();
        ICollection<ArticleProto> GetArticleByAuthor(Guid authorId);
        ICollection<ArticleProto> GetArticleById(Guid Id);
        void Delete(Guid ArticleId); 
    }
}
