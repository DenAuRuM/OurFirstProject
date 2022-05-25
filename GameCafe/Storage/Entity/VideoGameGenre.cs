using System.ComponentModel.DataAnnotations;

namespace GameCafe.Storage.Entity
{
    public class VideoGameGenre
    {
        [Key]
        public int Id { get; set; }
        public string Genre { get; set; }
        public IList<Videogame> Videogames { get; set; }

        public VideoGameGenre()
        {
            Videogames = new List<Videogame>(); 
        }
    }
}
