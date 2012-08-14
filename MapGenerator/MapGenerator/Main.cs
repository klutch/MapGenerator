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
        private MapGeneratorForm mapGeneratorForm;

        // Constructor
        public Main(MapGeneratorForm mapGeneratorForm)
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.mapGeneratorForm = mapGeneratorForm;

            // Events
            graphics.PreparingDeviceSettings +=
                new EventHandler<PreparingDeviceSettingsEventArgs>(preparingDeviceSettings);
            Control.FromHandle(this.Window.Handle).VisibleChanged +=
                new EventHandler(visibleChanged);
        }

        // Initialize
        protected override void Initialize()
        {
            base.Initialize();
        }

        // preparingGraphicsDeviceSettings event handler
        private void preparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle = mapGeneratorForm.getSurface().Handle;
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
        }

        // UnloadContent
        protected override void UnloadContent()
        {
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

            base.Draw(gameTime);
        }
    }
}
