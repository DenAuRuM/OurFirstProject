using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geekroad.Storage.Entity;

namespace Geekroad.Storage
{
    public class ContextExample
    {
        public List<ArticleProto> Articles { get; set; }

        public List<UserProto> Authors { get; set; }


        public ContextExample()
        {
            Authors = new List<UserProto>();
            Articles = new List<ArticleProto>();

            var author1 = new UserProto(Guid.NewGuid(), "MegaLeha", "Aboba1234", "lehich@mylom.sru");
            var author2 = new UserProto(Guid.NewGuid(), "Sanya33", "helloworld777", "sanchezz@mylom.sru");

            Articles.Add(new ArticleProto(Guid.NewGuid(), "Короткое название статьи", "Описание, которое должно заинтересовать читателя", "*ну тут короче текст длиннющий*", author1));
            Articles.Add(new ArticleProto(Guid.NewGuid(), "Новое дополнение для Stellaris", "Долгожданное Stellaris:Overlord теперь в продаже! Что же нового предлагают игрокам Paradox?", "*ну тут короче текст длиннющий*", author2));

            Authors.Add(author1);
            Authors.Add(author2);
        }
    }
}
