using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class TariffManager : ITariffManager
    {
        private readonly GameCafeContext _context;
        public TariffManager(GameCafeContext context)
        {
            _context = context;
        }


        public async Task<IList<Tariff>> GetAll() => await _context.Tariffs.ToListAsync();
    }
}