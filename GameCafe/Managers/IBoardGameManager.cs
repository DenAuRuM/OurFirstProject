using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Managers;

public interface IBoardGameManager
{
    Task<IList<BoardGame>> GetAll();
}