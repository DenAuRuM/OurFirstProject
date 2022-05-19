namespace GameCafe.Storage.Entity
{
    public class VideoGameGenre
    {
        public int Id { get; set; }
        public string Genre { get; set; }
         public int? VideogameId { get; set; }
        public List<Videogame> Videogame { get; set; }

    }
}
