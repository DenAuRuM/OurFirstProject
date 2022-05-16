using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class BoardGamesController : Controller
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int people { get; set; }

    }
}
