using GameCafe.Storage.Entity;

namespace GameCafe.Managers
{
    public interface IVideogameManager
    {
        Task<IList<Videogame>> GetAll();
    }
}
