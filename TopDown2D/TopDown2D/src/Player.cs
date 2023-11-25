using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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
        private Vector2 velocity;
        private Rectangle playerRec;
        private float movementSpeed;
        private Rectangle spriteSelector;
        bool facing_right, facing_up, facing_down, facing_left;
        int index = 0;
        int delay = 0;

        public Player()
        {
            position = new Vector2(640, 352);
            spriteSelector = new Rectangle(0, 0, 16, 16);
            movementSpeed = 2.0f;

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
                velocity.Y -= movementSpeed;
                facing_up = true;
                facing_down = false;
                facing_left = false;
                facing_right = false;
                spriteSelector = playerUpAnim[index];
            }
            else if (downKeyPressed)
            {
                velocity.Y += movementSpeed;
                facing_down = true;
                facing_up = false;
                facing_left = false;
                facing_right = false;
                spriteSelector = playerDownAnim[index];
            }
            else if (leftKeyPressed)
            {
                velocity.X -= movementSpeed;
                facing_left = true;
                facing_right = false;
                facing_down = false;
                facing_up = false;
                spriteSelector = playerLeftAnim[index];
            }
            else if (rightKeyPressed)
            {
                velocity.X += movementSpeed;
                facing_right = true;
                facing_left = false;
                facing_down = false;
                facing_up = false;
                spriteSelector = playerRightAnim[index];
            }
            if (kbState.IsKeyDown(Keys.LeftShift))
                movementSpeed = 5;
            if (kbState.IsKeyUp(Keys.LeftShift))
                movementSpeed = 2;

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

        public void Update(GameTime gameTime, List<Rectangle> tiles)
        {
            KeyboardState kbState = Keyboard.GetState();
            HandleInput(kbState);
            foreach (var tile in tiles) 
            {
                if(velocity.X > 0 && isTouchingLeft(tile))
                {
                    position.X = tile.Left - 64;
                    velocity.X = 0;
                }
                if (velocity.X < 0 && isTouchingRight(tile))
                {
                    position.X = tile.Right;
                    velocity.X = 0;
                }

                if (velocity.Y > 0 && isTouchingTop(tile))
                {
                    position.Y = tile.Top - 64;
                    velocity.Y = 0;
                }
                if(velocity.Y < 0 && isTouchingBottom(tile)) 
                {
                    position.Y = tile.Bottom;
                    velocity.Y = 0;
                }
            }
            playerRec = new Rectangle((int)position.X, (int)position.Y, 64, 64);
            position += velocity;
            velocity = Vector2.Zero;
        }

        private bool isTouchingLeft(Rectangle rect)
        {
            return playerRec.Right + velocity.X > rect.Left &&
                        playerRec.Left < rect.Left &&
                        playerRec.Bottom > rect.Top &&
                        playerRec.Top < rect.Bottom;
        }

        private bool isTouchingRight(Rectangle rect)
        {
            return playerRec.Left + velocity.X < rect.Right &&
                        playerRec.Right > rect.Right &&
                        playerRec.Bottom > rect.Top &&
                        playerRec.Top < rect.Bottom;
        }

        private bool isTouchingTop(Rectangle rect)
        {
            return playerRec.Bottom + velocity.Y > rect.Top &&
                        playerRec.Top < rect.Top &&
                        playerRec.Right > rect.Left &&
                        playerRec.Left < rect.Right;
        }

        private bool isTouchingBottom(Rectangle rect)
        {
            return playerRec.Top + velocity.Y < rect.Bottom &&
                        playerRec.Bottom > rect.Bottom &&
                        playerRec.Right > rect.Left &&
                        playerRec.Left < rect.Right;
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(player, new Rectangle((int)position.X, (int)position.Y, 48, 48), spriteSelector, Color.White);
        }
    }
}
