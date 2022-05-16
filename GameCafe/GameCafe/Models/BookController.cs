using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class BookController : Controller
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public string type { get; set; }
        public string Author { get; set; }
    }
}
