using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameCafe.Storage.Entity
{
    public class Videogame
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string PlayersAmount { get; set; }

        [Required]
        public int VideoGameGenreId { get; set; }

        [ForeignKey(nameof(VideoGameGenreId))]

        public virtual VideoGameGenre VideoGameGenre { get; set; }
    }
}
