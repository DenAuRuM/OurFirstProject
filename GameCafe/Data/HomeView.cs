using GameCafe.Storage.Entity;

namespace GameCafe.Data
{
    public class HomeView
    {
        public IEnumerable<Tariff> Tariffs { get; set; }
        public IEnumerable<Place> Places { get; set; }
    }
}
