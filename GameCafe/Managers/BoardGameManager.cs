using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class BoardGameManager : IBoardGameManager
    {
        private readonly GameCafeContext _context;
        public BoardGameManager(GameCafeContext context)
        {
            _context = context;
        }

        
        public async Task<IList<BoardGame>> GetAll() => await _context.BoardGames.ToListAsync();
    }
}