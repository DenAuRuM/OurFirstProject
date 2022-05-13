using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geekroad.Storage.Entity
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortText { get; set; }
        public string Text { get; set; }
        public string Date;
        public User Author { get; set; }
        public Article(Guid id, string name, string shorttext, string text, User author)
        {
            Id = id;
            Name = name;
            ShortText = shorttext;
            Text = text;
            Author = author;
            Date = DateTime.Now.ToString();
        }

    }
}
