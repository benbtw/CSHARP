using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace ArcadeFlyer
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private SpriteFont textFont;

        private Player player;
        private List<Enemy> enemies;
        private Timer enemyCreationTimer;

        private List<Projectile> projectiles;
        private Texture2D playerProjectileSprite;
        private Texture2D enemyProjectileSprite;

        private int life = 3;
        private int score = 0;

        private bool gameOver = false;

        private int screenWidth = 1600;
        public int ScreenWidth
        {
            get { return screenWidth; }
            set { screenWidth = value; }
        }

        private int screenHeight = 900;
        public int ScreenHeight
        {
            get { return screenHeight; }
            private set { screenHeight = value; }
        }

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);

            _graphics.PreferredBackBufferWidth = screenWidth;
            _graphics.PreferredBackBufferHeight = screenHeight;
            _graphics.ApplyChanges();

            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            player = new Player(this, new Vector2(0.0f, 0.0f));
            enemies = new List<Enemy>();
            enemies.Add(new Enemy(this, new Vector2(screenWidth, 0)));
            projectiles = new List<Projectile>();
            enemyCreationTimer = new Timer(0.5f);
            enemyCreationTimer.StartTimer();
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            playerProjectileSprite = Content.Load<Texture2D>("PlayerFire");
            enemyProjectileSprite = Content.Load<Texture2D>("EnemyFire");
            textFont = Content.Load<SpriteFont>("Text");
        }

        public void FireProjectile(Vector2 position, Vector2 velocity, ProjectileType projectileType)
        {
            Texture2D projectileImage;

            if (projectileType == ProjectileType.Player)
            {
                projectileImage = playerProjectileSprite;
            }
            else
            {
                projectileImage = enemyProjectileSprite;
            }

            Projectile firedProjectile = new Projectile(position, velocity, projectileImage, projectileType);
            projectiles.Add(firedProjectile);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player.Update(gameTime);
            foreach (Enemy enemy in enemies)
            {
                enemy.Update(gameTime);
            }

            for (int i = projectiles.Count - 1; i >= 0; i--)
            {
                Projectile p = projectiles[i];
                p.Update();

                bool playerProjectile = p.ProjectileType == ProjectileType.Player;

                if (!playerProjectile && player.Overlaps(p))
                {
                    projectiles.Remove(p);
                    life--;
                    if (life < 1)
                    {
                        gameOver = true;
                    }
                }
                else if (playerProjectile)
                {
                    for (int enemyIdx = enemies.Count - 1; enemyIdx >= 0; enemyIdx--)
                    {
                        Enemy enemy = enemies[enemyIdx];

                        if (enemy.Overlaps(p))
                        {
                            projectiles.Remove(p);
                            enemies.Remove(enemy);
                            score++;
                        }
                    }
                }
            }

            if (!enemyCreationTimer.Active) 
            {
                enemies.Add(new Enemy(this, new Vector2(screenWidth, 0.0f)));
                enemyCreationTimer.StartTimer();
            }

            enemyCreationTimer.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            if (gameOver)
            {
                GraphicsDevice.Clear(Color.Black);
                _spriteBatch.Begin();

                Vector2 textPosition = new Vector2(screenWidth / 2, screenHeight / 2);
                _spriteBatch.DrawString(textFont, $"Game Over :(\nFinal Score: {score}", textPosition, Color.White);

                _spriteBatch.End();
                return;
            }

            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            player.Draw(gameTime, _spriteBatch);

            foreach (Enemy enemy in enemies)
            {
                enemy.Draw(gameTime, _spriteBatch);
            }

            foreach (Projectile p in projectiles)
            {
                p.Draw(gameTime, _spriteBatch);
            }

            _spriteBatch.DrawString(textFont, $"Life: {life}\nScore: {score}", Vector2.Zero, Color.Black);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}