using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class DrinkManager : IDrinkManager
    {
        private readonly GameCafeContext _context;
        public DrinkManager(GameCafeContext context)
        {
            _context = context;
        }


        public async Task<IList<Drink>> GetAll() => await _context.Drinks.ToListAsync();
    }
}