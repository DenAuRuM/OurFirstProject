using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Models
{
    public class SnakController : Controller
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
        public int cost { get; set; }
       
    }
}
