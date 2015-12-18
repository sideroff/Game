﻿namespace Teamwork_OOP.Interfaces
{
    public interface IMap
    {
        string Src { get; set; }

        ITile[,] Tiles { get; set; }
        
        int TileWidth { get; }

        int TileHeight { get; }

        void Initialize(IMapFactory mapFactory, ITileFactory tileFactory);
    }
}