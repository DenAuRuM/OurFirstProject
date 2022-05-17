using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameCafe.Storage.Entity;


namespace GameCafe.Data
{
    public class GameCafeContext : DbContext
    {
        public GameCafeContext(DbContextOptions<GameCafeContext> options)
            : base(options)
        {

        }

        public DbSet<GameCafe.Storage.Entity.Book> Books { get; set; }
        public DbSet<GameCafe.Storage.Entity.BoardGame> BoardGames { get; set; }
        public DbSet<GameCafe.Storage.Entity.Drink> Drinks { get; set; }
        public DbSet<GameCafe.Storage.Entity.Movie> Movies { get; set; }
        public DbSet<GameCafe.Storage.Entity.Place> Places { get; set; }
        public DbSet<GameCafe.Storage.Entity.Review> Reviews { get; set; }
        public DbSet<GameCafe.Storage.Entity.Snack> Snacks { get; set; }
        public DbSet<GameCafe.Storage.Entity.Tariff> Tariffs { get; set; }
        public DbSet<GameCafe.Storage.Entity.Videogame> Videogames { get; set; }
        public DbSet<GameCafe.Storage.Entity.VideoGameGenre> VideoGameGenres { get; set; }

    }
}