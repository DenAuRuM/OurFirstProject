namespace GameCafe.Storage.Entity
{
    public class Review
    {
        public Guid Id { get; set; }
        public string Author { get; set; }
        public string Text  { get; set; }
        public Place Place { get; set; }
    }
}
