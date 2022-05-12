using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geekroad.Storage.Entity
{
    public class ReplyProto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public string Date;
        public UserProto Author { get; set; }

        public ReplyProto(Guid id, string name, string shorttext, string text, UserProto author)
        {
            Id = id;
            Text = text;
            Author = author;
            Date = DateTime.Now.ToString();
        }
    }
}
