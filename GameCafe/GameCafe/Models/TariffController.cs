using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class TariffController : Controller
    {
        public Guid id { get; set; }
        public string title { get; set; }
        public int cost { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public bool snak { get; set; }
        public bool drink { get; set; }
        public bool alkodrink { get; set; }
    }
}
