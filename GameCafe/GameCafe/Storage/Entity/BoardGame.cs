﻿namespace GameCafe.Storage.Entity
{
    public class BoardGame
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string PlayersAmount { get; set; }
    }
}
