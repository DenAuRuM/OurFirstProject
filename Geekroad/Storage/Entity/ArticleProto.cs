using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geekroad.Storage.Entity
{
    public class ArticleProto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortText { get; set; }
        public string Text { get; set; }

        public string Date;
        public UserProto Author { get; set; }

        public ArticleProto(Guid id, string name, string shorttext, string text, UserProto author)
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
