namespace GameCafe.Storage.Entity
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }

        public string Length { get; set; }
    }
}
