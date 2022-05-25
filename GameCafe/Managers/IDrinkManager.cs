using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Managers;

public interface IDrinkManager
{
    Task<IList<Drink>> GetAll();
}