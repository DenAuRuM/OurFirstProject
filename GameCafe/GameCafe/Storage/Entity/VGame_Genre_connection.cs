namespace GameCafe.Storage.Entity
{
    public class VGame_Genre_connection
    {
        public Guid Id { get; set; }
        public Videogame Videogame { get; set; }
        public VideoGameGenre VideoGameGenre { get; set; }
    }
}
