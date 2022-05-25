using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Managers;

public interface ISnackManager
{
    Task<IList<Snack>> GetAll();
}