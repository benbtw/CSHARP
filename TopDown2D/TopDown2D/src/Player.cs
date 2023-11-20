using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TopDown2D
{
    internal class Player
    {
        Texture2D player;
        Texture2D playerWalk;
        Texture2D playerIdle;
        Texture2D[] playerIdleAnim;
        Texture2D[] playerWalkAnim;
        private Vector2 position;
        private float movementSpeed;

        public Player()
        {
            position = new Vector2(10, 10);
            movementSpeed = 5f;
        }

        private void HandleInput(KeyboardState kbState)
        {
            bool upKeyPressed = kbState.IsKeyDown(Keys.W);
            bool downKeyPressed = kbState.IsKeyDown(Keys.S);
            bool leftKeyPressed = kbState.IsKeyDown(Keys.A);
            bool rightKeyPressed = kbState.IsKeyDown(Keys.D);

            if (upKeyPressed)
            {
                position.Y -= movementSpeed;
            }
            if (downKeyPressed)
            {
                position.Y += movementSpeed;
            }
            if (leftKeyPressed)
            {
                position.X -= movementSpeed;
            }
            if (rightKeyPressed)
            {
                position.X += movementSpeed;
            }
        }

        public void loadContent(Game1 main)
        {
            player = main.Content.Load<Texture2D>("Idle");
            playerIdle = main.Content.Load<Texture2D>("Idle");
            playerWalk = main.Content.Load<Texture2D>("Walk");

        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kbState = Keyboard.GetState();
            HandleInput(kbState);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(player, position, new Rectangle(0,0,16,16), Color.White);
        }
    }
}
