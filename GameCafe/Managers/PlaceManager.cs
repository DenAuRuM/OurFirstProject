using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class PlaceManager : IPlaceManager
    {
        private readonly GameCafeContext _context;
        public PlaceManager(GameCafeContext context)
        {
            _context = context;
        }


        public async Task<IList<Place>> GetAll() => await _context.Places.ToListAsync();
    }
}