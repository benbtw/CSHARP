using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{

    class Player
    {
        public int PLposX = 4, PLposY = 11, PLprevX = 4;

        Bricks brick = new();
        public void Move()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.LeftArrow && PLposX - 1 > 0)
                {
                    PLprevX = PLposX;
                    PLposX--;
                }
                else if (key.Key == ConsoleKey.RightArrow && PLposX + 1 < 11)
                {
                    PLprevX = PLposX;
                    PLposX++;
                }
            }
        }
    }
}
