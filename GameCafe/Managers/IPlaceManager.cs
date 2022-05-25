using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Managers;

public interface IPlaceManager
{
    Task<IList<Place>> GetAll();
}