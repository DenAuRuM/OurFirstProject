using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class MovieManager : IMovieManager
    {
        private readonly GameCafeContext _context;
        public MovieManager(GameCafeContext context)
        {
            _context = context;
        }


        public async Task<IList<Movie>> GetAll() => await _context.Movies.ToListAsync();
    }
}