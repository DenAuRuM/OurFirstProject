namespace GameCafe.Storage.Entity
{
    public class Drink
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public double Volume { get; set; }
        public bool isAlcohol { get; set; }
    }
}
