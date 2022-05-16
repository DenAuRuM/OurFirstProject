using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class GenreVideoGameController : Controller
    {
        public Guid id { get; set; }
        public string title { get; set; }

    }
}
