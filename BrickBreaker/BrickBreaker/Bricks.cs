using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BrickBreaker.Player;


namespace BrickBreaker
{
    class Bricks
    {

        public int brickCount = 0;

        public Char[,] brickMap = {
                {'#','-','-','-','-','-','-','-','-','-','-','#'},
                {'#', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#',' ', ' ', '=','=','=','=','=','=',' ',' ','#'},
                {'#', ' ', ' ', '=','=','=','=','=','=',' ',' ','#'},
                {'#', ' ', ' ', '=','=','=','=','=','=',' ',' ','#'},
                {'#', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {'#', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','#'},
                {' ', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ',' '},
                {' ', ' ', ' ', ' ',' ',' ',' ',' ',' ',' ',' ',' '}
            };

        public void printMap()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(brickMap[i, j]);
                    if (brickMap[i, j] == '=')
                        brickCount++;
                }
                Console.WriteLine();
            }
            brickCount = 0;
        }

        public void setPlayerPos(int x, int y, int px)
        {
            brickMap[y, px] = ' ';
            brickMap[y, px+1] = ' ';
            brickMap[y, px+2] = ' ';
            brickMap[y, x] = '_';
            brickMap[y, x+2] = '_';
            brickMap[y, x+1] = '_';
        }

        public void setBallPos(int x, int y, int px, int py)
        {
            brickMap[py, px] = ' ';
            brickMap[y, x] = 'o';
        }
    }
}
