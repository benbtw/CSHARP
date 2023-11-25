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
    public class TileMap : Levels
    {
        Texture2D natureTileSet;
        Texture2D floorTileSet;
        Texture2D houseTileSet;
        Texture2D waterTileSet;
        public List<Rectangle> colTiles = new List<Rectangle>();
        int[,] currentlvl = Levels.level1;

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
            for(int i = 0; i < currentlvl.GetLength(0); i++) 
            {
                for(int j = 0; j < currentlvl.GetLength(1); j++)
                {
                    if (currentlvl[i, j] == 0)
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 16, 16, 16), Color.White);
                    if (currentlvl[i, j] == 1)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 0, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 64, 32));
                    }
                    if (currentlvl[i, j] == 2)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 0, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 3)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 0, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 4)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 32, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64 +32, 64, 32));
                    }
                    if (currentlvl[i, j] == 5)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 16, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 6)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 16, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64+32, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 7)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 32, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 8)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 32, 16, 16), Color.White);
                    }
                } 
            }
            //ontop of ground stuff
            for (int i = 0; i < currentlvl.GetLength(0); i++)
            {
                for (int j = 0; j < currentlvl.GetLength(1); j++)
                {
                    if (currentlvl[i, j] == 9) 
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 16, 16, 16), Color.White);
                        spriteBatch.Draw(houseTileSet, new Rectangle(j * 64, i * 64, 160, 160), new Rectangle(64, 0, 64, 48), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 150, 150));
                    }
                    if (currentlvl[i, j] == 10)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 16, 16, 16), Color.White);
                        spriteBatch.Draw(waterTileSet, new Rectangle(j * 64, i * 64, 160, 160), new Rectangle(0,0,64,64), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64+20, 160, 160));
                    }
                }
            }
        }
    }
}
