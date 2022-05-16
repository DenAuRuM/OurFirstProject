using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class VideoGameController : Controller
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public string picture { get; set; }
        public int cost { get; set; }
        public string people { get; set; }

    }
}
