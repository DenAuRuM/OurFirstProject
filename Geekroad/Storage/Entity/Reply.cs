using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geekroad.Storage.Entity
{
    public class Reply
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public string Date;
        public User Author { get; set; }

        public Reply(Guid id, string name, string shorttext, string text, User author)
        {
            Id = id;
            Text = text;
            Author = author;
            Date = DateTime.Now.ToString();
        }
    }
}
