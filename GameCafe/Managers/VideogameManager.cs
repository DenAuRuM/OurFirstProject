using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{

    public class VideogameManager : IVideogameManager
    {
        private readonly GameCafeContext _context;
        public VideogameManager(GameCafeContext context)
        {
            _context = context;
        }
        public async Task<IList<Videogame>> GetAll() => await _context.Videogames.Include(x => x.VideoGameGenre).ToListAsync();
    }
}
