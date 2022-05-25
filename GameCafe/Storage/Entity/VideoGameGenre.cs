using System.ComponentModel.DataAnnotations;

namespace GameCafe.Storage.Entity
{
    public class VideoGameGenre
    {
        [Key]
        public int Id { get; set; }
        public string Genre { get; set; }

    }
}
