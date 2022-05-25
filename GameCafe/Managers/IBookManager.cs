using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Managers;

public interface IBookManager
{
    Task<IList<Book>> GetAll();
}