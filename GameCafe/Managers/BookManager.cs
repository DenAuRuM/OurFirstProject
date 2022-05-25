using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class BookManager : IBookManager
    {
        private readonly GameCafeContext _context;
        public BookManager(GameCafeContext context) 
        {
            _context = context;
        }


        public async Task<IList<Book>> GetAll() => await _context.Books.ToListAsync();
    }
}