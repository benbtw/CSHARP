using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Xml.Linq;

namespace ArcadeFlyer
{
    internal class Player : Sprite
    {
        private Game1 root;
        private float movementSpeed = 4.0f;

        private Timer projectileCoolDown;

        public Player(Game1 root, Vector2 position) : base(position)
        {
            this.root = root;
            this.position = position;
            this.SpriteWidth = 128.0f;

            projectileCoolDown = new Timer(0.5f);

            LoadContent();
        }

        private void HandleInput(KeyboardState currentKeyboardState)
        {
            bool upKeyPressed = currentKeyboardState.IsKeyDown(Keys.W);
            bool downKeyPressed = currentKeyboardState.IsKeyDown(Keys.S);
            bool leftKeyPressed = currentKeyboardState.IsKeyDown(Keys.A);
            bool rightKeyPressed = currentKeyboardState.IsKeyDown(Keys.D);

            if(upKeyPressed)
            {
                position.Y -= movementSpeed;
            }
            if(downKeyPressed) 
            {
                position.Y += movementSpeed;
            }
            if(leftKeyPressed) 
            {
                position.X -= movementSpeed;
            }
            if(rightKeyPressed)
            {
                position.X += movementSpeed;
            }

            if(!projectileCoolDown.Active && currentKeyboardState.IsKeyDown(Keys.Space)) 
            {
                Vector2 projectilePosition = new Vector2(position.X + SpriteWidth, position.Y + SpriteHeight / 2);
                Vector2 projectileVelocity = new Vector2(10.0f, 0.0f);

                root.FireProjectile(projectilePosition, projectileVelocity, ProjectileType.Player);
                projectileCoolDown.StartTimer();
            }
        }

        public void LoadContent() 
        {
            this.SpriteImage = root.Content.Load<Texture2D>("MainChar");
        }

        public void Update(GameTime gameTime) 
        {
            KeyboardState currentKeyboardState = Keyboard.GetState();
            HandleInput(currentKeyboardState);
            projectileCoolDown.Update(gameTime);
        }
    }
}
