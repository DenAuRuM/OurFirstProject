using GameCafe.Storage.Entity;

namespace GameCafe.Managers
{
    public interface IReviewManager
    {
        Task<IList<Review>> GetAll();

        Task Create(string text, string name);
    }
}
