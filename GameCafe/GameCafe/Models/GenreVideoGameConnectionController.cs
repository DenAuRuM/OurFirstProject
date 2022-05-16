using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class GenreVideoGameConnectionController : Controller
    {
        public Guid idgame { get; set; }
        public Guid idrtype { get; set; }

    }
}
