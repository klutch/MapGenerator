using System;
using System.Collections.Generic;
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
        private System.Windows.Forms.PictureBox surface;
        public RenderTarget2D renderTarget;
        public Texture2D baseNoise;
        public Texture2D baseWater;
        private Texture2D randomTexture;
        private Random random;
        public Vector2 view;
        public float scale = 1;
        private KeyboardState newKeyState;
        private KeyboardState oldKeyState;

        private Effect baseEffect;
        private Effect waterEffect;

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
            System.Windows.Forms.Control.FromHandle(this.Window.Handle).VisibleChanged +=
                new EventHandler(visibleChanged);
        }

        // Initialize
        protected override void Initialize()
        {
            graphics.PreferredBackBufferWidth = surface.Width;
            graphics.PreferredBackBufferHeight = surface.Height;
            graphics.ApplyChanges();

            view = new Vector2(surface.Width, surface.Height) / 2;

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
            if (System.Windows.Forms.Control.FromHandle(this.Window.Handle).Visible)
                System.Windows.Forms.Control.FromHandle(this.Window.Handle).Visible = false;
        }

        // LoadContent
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spriteFont = Content.Load<SpriteFont>("spriteFont");
            baseEffect = Content.Load<Effect>("baseEffect");
            waterEffect = Content.Load<Effect>("waterEffect");
        }

        // UnloadContent
        protected override void UnloadContent()
        {
        }

        // generateMap
        public void generateMap(MapGeneratorOptions options)
        {
            // Destroy existing render target
            if (renderTarget != null)
            {
                renderTarget.Dispose();
                renderTarget = null;
            }

            // Initialize random number generator
            random = new Random(options.seed);

            // Initialize random texture
            Color[] data = new Color[options.randomTextureWidth * options.randomTextureHeight];
            for (int i = 0; i < options.randomTextureWidth; i++)
            {
                for (int j = 0; j < options.randomTextureHeight; j++)
                {
                    float randomNumber = (float)random.NextDouble();
                    data[i + j * options.randomTextureWidth] = new Color(randomNumber, randomNumber, randomNumber);
                }
            }
            randomTexture = new Texture2D(GraphicsDevice, options.randomTextureWidth, options.randomTextureHeight);
            randomTexture.SetData<Color>(data);

            // Initialize vertex shader properties
            Matrix projection = Matrix.CreateOrthographicOffCenter(0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, 0, 0, 1);
            Matrix halfPixelOffset = Matrix.CreateTranslation(-0.5f, -0.5f, 0);
            baseEffect.Parameters["matrixTransform"].SetValue(halfPixelOffset * projection);

            // Initialize render target
            renderTarget = new RenderTarget2D(GraphicsDevice, options.width, options.height);

            // Draw noise effect to render target
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Black);
            baseEffect.Parameters["renderTargetSize"].SetValue(new Vector2(options.width, options.height));
            baseEffect.Parameters["randomTextureSize"].SetValue(new Vector2(options.randomTextureWidth, options.randomTextureHeight));
            baseEffect.Parameters["randomTextureScale"].SetValue(options.randomTextureScale);
            baseEffect.Parameters["noiseFrequency"].SetValue(options.noiseFrequency);
            baseEffect.Parameters["noiseGain"].SetValue(options.noiseGain);
            baseEffect.Parameters["noiseLacunarity"].SetValue(options.noiseLacunarity);
            baseEffect.Parameters["brightness"].SetValue(options.brightness);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, baseEffect);
            spriteBatch.Draw(randomTexture, renderTarget.Bounds, randomTexture.Bounds, Color.White);
            spriteBatch.End();

            // Reset render target
            GraphicsDevice.SetRenderTarget(null);

            // Store base noise texture
            data = new Color[options.width * options.height];
            renderTarget.GetData<Color>(data);
            baseNoise = new Texture2D(GraphicsDevice, options.width, options.height);
            baseNoise.SetData<Color>(data);

            // Draw water effect to render target
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Transparent);
            waterEffect.Parameters["waterLevel"].SetValue(options.waterLevel);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, waterEffect);
            spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
            spriteBatch.End();

            // Reset render target
            GraphicsDevice.SetRenderTarget(null);

            // Store base water texture
            renderTarget.GetData<Color>(data);
            baseWater = new Texture2D(GraphicsDevice, options.width, options.height);
            baseWater.SetData<Color>(data);

            // Draw textures
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
            spriteBatch.Draw(baseWater, baseWater.Bounds, Color.White);
            spriteBatch.End();

            // Reset render target
            GraphicsDevice.SetRenderTarget(null);
        }

        // resetView
        public void resetView()
        {
            scale = 1;
            view = new Vector2(surface.Width, surface.Height) / 2;
        }

        // Update
        protected override void Update(GameTime gameTime)
        {
            newKeyState = Keyboard.GetState();

            // Input
            if (newKeyState.IsKeyDown(Keys.Home) && oldKeyState.IsKeyUp(Keys.Home))
                resetView();

            if (newKeyState.IsKeyDown(Keys.Enter) && oldKeyState.IsKeyUp(Keys.Enter))
                generateMap(mapGeneratorForm.getOptions());

            oldKeyState = newKeyState;

            base.Update(gameTime);
        }

        // Draw
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();

            if (renderTarget != null)
                spriteBatch.Draw(renderTarget, view, renderTarget.Bounds, Color.White, 0, new Vector2(renderTarget.Width, renderTarget.Height) / 2, scale, SpriteEffects.None, 0);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
