using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TopDown2D
{
    internal class Player
    {
        Texture2D player;
        Rectangle[] playerIdleAnim;
        Rectangle[] playerUpAnim;
        Rectangle[] playerDownAnim;
        Rectangle[] playerLeftAnim;
        Rectangle[] playerRightAnim;
        private Vector2 position;
        private float movementSpeed;
        private Rectangle spriteSelector;
        bool facing_right, facing_up, facing_down, facing_left;
        int index = 0;
        int delay = 0;

        public Player()
        {
            position = new Vector2(10, 10);
            spriteSelector = new Rectangle(0, 0, 16, 16);
            movementSpeed = 4f;
            
            //player animations
            playerUpAnim = new Rectangle[4];
            playerUpAnim[0] = new Rectangle(16, 0, 16, 16);
            playerUpAnim[1] = new Rectangle(16, 16, 16, 16);
            playerUpAnim[2] = new Rectangle(16, 32, 16, 16);
            playerUpAnim[3] = new Rectangle(16, 48, 16, 16);


            playerDownAnim = new Rectangle[4];
            playerDownAnim[0] = new Rectangle(0, 0, 16, 16);
            playerDownAnim[1] = new Rectangle(0, 16, 16, 16);
            playerDownAnim[2] = new Rectangle(0, 32, 16, 16);
            playerDownAnim[3] = new Rectangle(0, 48, 16, 16);


            playerLeftAnim = new Rectangle[4];
            playerLeftAnim[0] = new Rectangle(32, 0, 16, 16);
            playerLeftAnim[1] = new Rectangle(32, 16, 16, 16);
            playerLeftAnim[2] = new Rectangle(32, 32, 16, 16);
            playerLeftAnim[3] = new Rectangle(32, 48, 16, 16);


            playerRightAnim = new Rectangle[4];
            playerRightAnim[0] = new Rectangle(48, 0, 16, 16);
            playerRightAnim[1] = new Rectangle(48, 16, 16, 16);
            playerRightAnim[2] = new Rectangle(48, 32, 16, 16);
            playerRightAnim[3] = new Rectangle(48, 48, 16, 16);

            playerIdleAnim = new Rectangle[4];
            playerIdleAnim[0] = new Rectangle(0, 0, 16, 16); // down
            playerIdleAnim[1] = new Rectangle(16, 0, 16, 16); // up
            playerIdleAnim[2] = new Rectangle(32, 0, 16, 16); // left
            playerIdleAnim[3] = new Rectangle(48, 0, 16, 16); // right
        }

        private void HandleInput(KeyboardState kbState)
        {
            delay++;
            bool upKeyPressed = kbState.IsKeyDown(Keys.W);
            bool downKeyPressed = kbState.IsKeyDown(Keys.S);
            bool leftKeyPressed = kbState.IsKeyDown(Keys.A);
            bool rightKeyPressed = kbState.IsKeyDown(Keys.D);

            if (upKeyPressed)
            {
                position.Y -= movementSpeed;
                facing_up = true;
                facing_down = false;
                facing_left = false;
                facing_right = false;
                spriteSelector = playerUpAnim[index];
            }
            else if (downKeyPressed)
            {
                position.Y += movementSpeed;
                facing_down = true;
                facing_up = false;
                facing_left = false;
                facing_right = false;
                spriteSelector = playerDownAnim[index];
            }
           else if (leftKeyPressed)
            {
                position.X -= movementSpeed;
                facing_left = true;
                facing_right = false;
                facing_down = false;
                facing_up = false;
                spriteSelector = playerLeftAnim[index];
            }
            else if (rightKeyPressed)
            {
                position.X += movementSpeed;
                facing_right = true;
                facing_left = false;
                facing_down = false;
                facing_up = false;
                spriteSelector = playerRightAnim[index];
            }

            if (delay > 10)
            {
                delay = 0;
                index++;
                if (index == 4)
                    index = 0;
            }

            if (kbState.IsKeyUp(Keys.W) && kbState.IsKeyUp(Keys.S) && 
                kbState.IsKeyUp(Keys.A) && kbState.IsKeyUp(Keys.D))
            {
                if (facing_up)
                {
                    spriteSelector = playerIdleAnim[1];
                }
                if (facing_down)
                {
                    spriteSelector = playerIdleAnim[0];
                }
                if (facing_left)
                {
                    spriteSelector = playerIdleAnim[2];
                }
                if (facing_right)
                {
                    spriteSelector = playerIdleAnim[3];
                }
            }
        }

        public void loadContent(Game1 main)
        {
            player = main.Content.Load<Texture2D>("SpriteSheet");
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState kbState = Keyboard.GetState();
            HandleInput(kbState);
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(player, position, spriteSelector, Color.White);
        }
    }
}
