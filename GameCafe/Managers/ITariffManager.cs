using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Managers;

public interface ITariffManager
{
    Task<IList<Tariff>> GetAll();
}