namespace BrickBreaker
{
    class Ball
    {
        int ticks = 0;

        public int ballX = 2, ballY = 5, ballPX = 2, ballPY = 5;
        public bool negX = false, negY = false;

        public void update(Char[,] map)
        {
            //slows ball down
            if (ticks == 2)
            {
                //Collision for when it hits player
                if (map[ballY + 1, ballX + 1] == '_')
                {
                    negY = true;
                    negX = false;
                }
                else if (map[ballY + 1, ballX - 1] == '_')
                {
                    negY = true;
                    negX = false;
                }

                //Collision for walls |
                if (map[ballY + 1, ballY + 1] == '#')
                {
                    negX = true;
                    negY = false;

                }
                else if (map[ballY + 1, ballX - 1] == '#')
                {
                    negX = false;
                    negY = false;
                }
                else if (map[ballY - 1, ballX - 1] == '#')
                {
                    negX = false;
                    negY = true;
                }
                else if (map[ballY - 1, ballX + 1] == '#')
                {
                    negX = true;
                    negY = true;
                }


                //Collision for ceiling -
                if (map[ballY - 1, ballX - 1] == '-')
                {
                    negX = true;
                    negY = false;
                }
                else if (map[ballY - 1, ballX + 1] == '-')
                {
                    negY = false;
                    negX = false;
                }

                ballPX = ballX;
                ballPY = ballY;
                if (negX)
                    ballX--;
                else
                    ballX++;

                if (negY)
                    ballY--;
                else
                    ballY++;

                ticks = 0;
            }
            ticks++;
        }

    }
}