using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class SnackManager : ISnackManager
    {
        private readonly GameCafeContext _context;
        public SnackManager(GameCafeContext context)
        {
            _context = context;
        }


        public async Task<IList<Snack>> GetAll() => await _context.Snacks.ToListAsync();
    }
}