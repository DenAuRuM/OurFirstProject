using GameCafe.Data;
using GameCafe.Storage.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameCafe.Managers
{
    public class ReviewManager: IReviewManager
    {
        private readonly GameCafeContext _context;
        public ReviewManager(GameCafeContext context)
        {
            _context = context;
        }

        public async Task Create(string text,string name)
        {
            var review = new Review { Author = name, Text = text };
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Review>> GetAll() => await _context.Reviews.ToListAsync();
    }
}
