using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace Breakout134
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        int score = 0;
        int counter = 0;
        int highscore;
        int lives = 3;
        Texture2D bollen;
        Texture2D padle;
        Texture2D texture;
        Texture2D block;
        Vector2 bollPos;
        Vector2 bollDir;
        Vector2 scorePos;
        Rectangle bollRec;
        Rectangle blockRec;
        Rectangle padleRec;
        Rectangle gameOverRec;

        Rectangle[] BlockArray;

        MouseState mouseState;
        Vector2 mousePos;
        Boll boll;
        Boll boll1;
        bool resetBall;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            bollen = Content.Load<Texture2D>("ball_breakout");
            bollPos = new Vector2(50, 50);
            block = Content.Load<Texture2D>("block_breakout");
            blockRec = new Rectangle(0, 0, 50, 25);
            padle = Content.Load<Texture2D>("padle");
            padleRec = new Rectangle();
            bollDir = new Vector2(5, -5);
            scorePos = new Vector2(50, 50);
            //bollRec = new Rectangle((Window.ClientBounds.Width)
            
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            //bollPos.X = bollPos.X + bollDir.X;
            //bollPos.Y = bollPos.Y + bollDir.Y;
            
            //boll1.Update();
            //boll1.CheckCrash();
            //boll.CheckCrash(padle);
            // TODO: Add your update logic here
            mouseState =Mouse.GetState();
            mousePos.X = mouseState.X - 73;
            mousePos.Y = 350;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            
            _spriteBatch.Draw(bollen, bollPos, Color.Yellow);
            _spriteBatch.Draw(padle, mousePos, Color.Red);
            
            _spriteBatch.End();


            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
        
    }
}