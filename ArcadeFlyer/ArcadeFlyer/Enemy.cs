using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ArcadeFlyer
{
    internal class Enemy : Sprite
    {
        private Game1 root;
        private Vector2 velocity;

        private Timer projectileCoolDown;

        public Enemy(Game1 root, Vector2 position) : base(position)
        {
            this.root = root;
            this.position = position;
            this.SpriteWidth = 128.0f;
            this.velocity = new Vector2(-3.0f, 10.0f);
            projectileCoolDown = new Timer(0.5f);


            LoadContent();
        }

        public void LoadContent()
        {
            this.SpriteImage = root.Content.Load<Texture2D>("Enemy");
        }

        public void Update(GameTime gameTime)
        {
            position += velocity;

            if (position.Y < 0 || position.Y > (root.ScreenHeight - SpriteHeight))
            {
                velocity.Y *= -1;
            }

            if (!projectileCoolDown.Active) 
            { 
                Vector2 projectilePosition = new Vector2(position.X, position.Y + SpriteHeight / 2);
                Vector2 projectileVelocity = new Vector2(-10.0f, 0.0f);

                root.FireProjectile(projectilePosition, projectileVelocity, ProjectileType.Enemy);
                projectileCoolDown.StartTimer();
            }
            projectileCoolDown.Update(gameTime);
        }
    }
}
