using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class FilmController : Controller
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string genre { get; set; }
        public int time { get; set; }

    }
}
