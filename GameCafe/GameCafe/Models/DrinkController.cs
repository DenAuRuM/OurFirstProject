using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class DrinkController : Controller
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public int size { get; set; }
        public bool alkodrink { get; set; }
    }
}
