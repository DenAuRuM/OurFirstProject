using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class PlaceController : Controller
    {
        public Guid id { get; set; }
        public string adres { get; set; }
        public string time { get; set; }

    }
}
