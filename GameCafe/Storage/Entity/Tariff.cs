namespace GameCafe.Storage.Entity
{
    public class Tariff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Length { get; set; }
        public string DayTime { get; set; }
        public string Picture { get; set; }
        public bool IsSnacks { get; set; }
        public bool IsDrink { get; set; } 
        public bool IsAlcoholDrink { get; set; }

    }
}
