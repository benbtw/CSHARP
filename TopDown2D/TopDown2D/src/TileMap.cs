using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using TopDown2D.src;

namespace TopDown2D
{
    public class TileMap
    {
        Texture2D natureTileSet;
        Texture2D floorTileSet;
        Texture2D houseTileSet;
        Texture2D waterTileSet;
        public List<Rectangle> colTiles = new List<Rectangle>();
        private Levels levels;

        public TileMap() 
        {
            levels = new Levels();
        }

        public void loadContent(Game1 main)
        {
            natureTileSet = main.Content.Load<Texture2D>("TilesetNature");
            floorTileSet = main.Content.Load<Texture2D>("TilesetFloor");
            houseTileSet = main.Content.Load<Texture2D>("TilesetHouse");
            waterTileSet = main.Content.Load<Texture2D>("TilesetWater");
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //ground/base layer
            levels.drawLvl1(gameTime, spriteBatch, floorTileSet, houseTileSet, waterTileSet, colTiles);
        }
    }
}
