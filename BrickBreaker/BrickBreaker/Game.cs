using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    class Game
    {

        Bricks bricks = new Bricks();
        Player player = new Player();
        Ball ball = new Ball();
        int index = 0;

        public Game() {
            Run();
        }

        void Run()
        {

            Console.CursorVisible = false;

            int FPS = 30;
            int deltaTimeMS = 1000 / FPS;

            while (true)
            {
                index++;
                Console.WriteLine(index);
                bricks.setPlayerPos(player.PLposX, player.PLposY, player.PLprevX);
                bricks.setBallPos(ball.ballX, ball.ballY, ball.ballPX, ball.ballPY);
                ball.update(bricks.brickMap);
                player.Move();
                bricks.printMap();
                Console.WriteLine(bricks.brickCount);
                Thread.Sleep(deltaTimeMS);
                Console.Clear();
            }
        }
    }
}
