using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
namespace TopDown2D.src
{
    public class Levels
    {

        public  int[,] currentlvl = new int[11, 20];

        public  void changeLevel(int level)
        {
            if (level == 1)
                currentlvl = level1;
            if (level == 2)
                currentlvl = level2;
            if (level == 3)
                currentlvl = level3;
            if (level == 4)
                currentlvl = level4;
        }

        public  int[,] level1 = new int[,] { //y = 11 x = 20
            {2, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 3},
            {5, 0, 9, 0, 0, 9, 0, 0, 0, 0, 0, 9, 0, 0, 9, 0, 0, 9, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 10, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {7, 4, 4, 4, 4, 4, 4, 4, 0, 0, 0, 0, 4, 4, 4, 4, 4, 4, 4, 8}
        };

        public  int[,] level2 = new int[,] { //y = 11 x = 20
            {2, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 3},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {7, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 8}
        };

        public  int[,] level3 = new int[,] { //y = 11 x = 20
            {2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {7, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 8}
        };

        public  int[,] level4 = new int[,] { //y = 11 x = 20
            {2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 3},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6},
            {7, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 8}
        };

        public void drawLvl1(GameTime gameTime, SpriteBatch spriteBatch, Texture2D floorTileSet, Texture2D houseTileSet, Texture2D waterTileSet, List<Rectangle> colTiles)
        {
            //ground/base layer
            currentlvl = level1;
            for (int i = 0; i < currentlvl.GetLength(0); i++)
            {
                for (int j = 0; j < currentlvl.GetLength(1); j++)
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
                        colTiles.Add(new Rectangle(j * 64, i * 64 + 48, 64, 32));
                    }
                    if (currentlvl[i, j] == 5)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 16, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 6)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 16, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64 + 32, i * 64, 32, 64));
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
                        spriteBatch.Draw(waterTileSet, new Rectangle(j * 64, i * 64, 160, 160), new Rectangle(0, 0, 64, 64), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64 + 20, 160, 160));
                    }
                }
            }
        }

        public  void drawLvl2(GameTime gameTime, SpriteBatch spriteBatch, Texture2D floorTileSet, List<Rectangle> colTiles)
        {
            currentlvl = level2;
            //ground/base layer
            for (int i = 0; i < currentlvl.GetLength(0); i++)
            {
                for (int j = 0; j < currentlvl.GetLength(1); j++)
                {
                    if (currentlvl[i, j] == 0)
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 128, 16, 16), Color.White);
                    if (currentlvl[i, j] == 1)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 112, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 64, 32));
                    }
                    if (currentlvl[i, j] == 2)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 112, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 3)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 112, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 4)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 144, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64 + 48, 64, 32));
                    }
                    if (currentlvl[i, j] == 5)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 128, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 6)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 128, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64 + 32, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 7)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 144, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 8)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 144, 16, 16), Color.White);
                    }
                }
            }
        }

        public void drawLvl3(GameTime gameTime, SpriteBatch spriteBatch, Texture2D floorTileSet, List<Rectangle> colTiles)
        {
            currentlvl = level3;
            //ground/base layer
            for (int i = 0; i < currentlvl.GetLength(0); i++)
            {
                for (int j = 0; j < currentlvl.GetLength(1); j++)
                {
                    if (currentlvl[i, j] == 0)
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(192, 128, 16, 16), Color.White);
                    if (currentlvl[i, j] == 1)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(192, 112, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 64, 32));
                    }
                    if (currentlvl[i, j] == 2)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(176, 112, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 3)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(208, 112, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 4)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(192, 144, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64 + 48, 64, 32));
                    }
                    if (currentlvl[i, j] == 5)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(176, 128, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 6)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(208, 128, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64 + 32, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 7)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(176, 144, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 8)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(208, 144, 16, 16), Color.White);
                    }
                }
            }
        }
        public void drawLvl4(GameTime gameTime, SpriteBatch spriteBatch, Texture2D floorTileSet, List<Rectangle> colTiles)
        {
            currentlvl = level4;
            //ground/base layer
            for (int i = 0; i < currentlvl.GetLength(0); i++)
            {
                for (int j = 0; j < currentlvl.GetLength(1); j++)
                {
                    if (currentlvl[i, j] == 0)
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 352, 16, 16), Color.White);
                    if (currentlvl[i, j] == 1)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 336, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 64, 32));
                    }
                    if (currentlvl[i, j] == 2)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 336, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 3)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 336, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 4)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(16, 368, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64 + 48, 64, 32));
                    }
                    if (currentlvl[i, j] == 5)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 352, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 6)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 352, 16, 16), Color.White);
                        colTiles.Add(new Rectangle(j * 64 + 32, i * 64, 32, 64));
                    }
                    if (currentlvl[i, j] == 7)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(0, 368, 16, 16), Color.White);
                    }
                    if (currentlvl[i, j] == 8)
                    {
                        spriteBatch.Draw(floorTileSet, new Rectangle(j * 64, i * 64, 64, 64), new Rectangle(32, 368, 16, 16), Color.White);
                    }
                }

            }
        }
    }
}
