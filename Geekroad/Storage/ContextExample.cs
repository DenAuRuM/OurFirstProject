using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Geekroad.Storage.Entity;

namespace Geekroad.Storage
{
    public class ContextExample
    {
        public List<Article> Articles { get; set; }

        public List<User> Users { get; set; }


        public ContextExample()
        {
            Users = new List<User>();
            Articles = new List<Article>();

            var author1 = new User(Guid.NewGuid(), "MegaLeha", "Aboba1234", "lehich@mylom.sru");
            var author2 = new User(Guid.NewGuid(), "Sanya33", "helloworld777", "sanchezz@mylom.sru");

            Articles.Add(new Article(Guid.NewGuid(), "Короткое название статьи", "Описание, которое должно заинтересовать читателя", "*ну тут короче текст длиннющий*", author1));
            Articles.Add(new Article(Guid.NewGuid(), "Новое дополнение для Stellaris", "Долгожданное Stellaris:Overlord теперь в продаже! Что же нового предлагают игрокам Paradox?", "*ну тут короче текст длиннющий*", author2));

            Users.Add(author1);
            Users.Add(author2);
        }
    }
}
