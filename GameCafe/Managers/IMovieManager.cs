﻿using GameCafe.Storage.Entity;
using Microsoft.AspNetCore.Mvc;

namespace GameCafe.Managers;

public interface IMovieManager
{
    Task<IList<Movie>> GetAll();
}