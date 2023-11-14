using Microsoft.Xna.Framework;

namespace ArcadeFlyer
{
    internal class Timer
    {
        private float totalTime;
        private float timer;
        public bool Active { get; private set; }
        
        public Timer(float totalTime)
        {
            this.totalTime = totalTime;
            this.timer = 0.0f;
            this.Active = false;
        }

        public void StartTimer()
        {
            Active = true;
            timer = 0.0f;
        }

        public void Update(GameTime gameTime)
        {
            if(Active)
            {
                timer += (float)gameTime.ElapsedGameTime.TotalSeconds;

                if(timer >= totalTime)
                {
                    Active = false;
                }
            }
        }
    }
}
