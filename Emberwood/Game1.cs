using Emberwood.Display;
using Logic;
using Logic.Events;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Emberwood
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private GameData data;

        private KeyboardState _currentKeyboardState;
        private KeyboardState _previousKeyboardState;

        public EventHandler<CameraMoveEventArgs> MoveCameraEvent;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            GameController.Instance.Game = this;
            data = new GameData();

            MoveCameraEvent += data.MoveCamera;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            _currentKeyboardState = Keyboard.GetState();

            //Example Camera move
            Coordinate coordinate = new Coordinate(0, 0);

            if (_currentKeyboardState.IsKeyDown(Keys.Up))
            {
                coordinate.Y -= 2;
            }
            if (_currentKeyboardState.IsKeyDown(Keys.Down))
            {
                coordinate.Y += 2;
            }
            if (_currentKeyboardState.IsKeyDown(Keys.Left))
            {
                coordinate.X -= 2;
            }
            if (_currentKeyboardState.IsKeyDown(Keys.Right))
            {
                coordinate.X += 2;
            }

            if (coordinate.X != 0 && coordinate.Y != 0)
            {
                MoveCameraEvent?.Invoke(this, new CameraMoveEventArgs(coordinate));
            }

            _previousKeyboardState = _currentKeyboardState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();



            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
