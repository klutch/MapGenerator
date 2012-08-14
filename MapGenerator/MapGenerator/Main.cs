using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MapGenerator
{
    public class Main : Game
    {
        public static GraphicsDeviceManager graphics;
        public static SpriteBatch spriteBatch;
        private SpriteFont spriteFont;
        private MapGeneratorForm mapGeneratorForm;
        private PictureBox surface;
        private RenderTarget2D renderTarget;

        // Constructor
        public Main(MapGeneratorForm mapGeneratorForm)
        {
            this.mapGeneratorForm = mapGeneratorForm;

            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            surface = mapGeneratorForm.getSurface();

            // Events
            graphics.PreparingDeviceSettings +=
                new EventHandler<PreparingDeviceSettingsEventArgs>(preparingDeviceSettings);
            Control.FromHandle(this.Window.Handle).VisibleChanged +=
                new EventHandler(visibleChanged);
        }

        // Initialize
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = surface.Width;
            graphics.PreferredBackBufferHeight = surface.Height;
            graphics.ApplyChanges();
            base.Initialize();
        }

        // preparingGraphicsDeviceSettings event handler
        private void preparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = surface.Handle;
        }

        // visibleChanged event handler
        private void visibleChanged(object sender, EventArgs e)
        {
            if (Control.FromHandle(this.Window.Handle).Visible)
                Control.FromHandle(this.Window.Handle).Visible = false;
        }

        // LoadContent
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteFont = Content.Load<SpriteFont>("spriteFont");
        }

        // UnloadContent
        protected override void UnloadContent()
        {
        }

        // generateMap
        public static void generateMap(MapGeneratorOptions options)
        {
            Console.WriteLine("Generate map");
        }

        // Update
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        // Draw
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            if (renderTarget != null)
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
