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
        private Random random;
        public Vector2 view;
        public float scale = 1;
        private KeyboardState newKeyState;
        private KeyboardState oldKeyState;
        private MouseState newMouseState;
        private MouseState oldMouseState;

        private Effect baseEffect;
        private Effect waterEffect;
        private Effect floraEffect;
        public RenderTarget2D baseNoise;
        public RenderTarget2D baseWater;
        public RenderTarget2D baseFlora;
        private Texture2D randomTexture;
        private int lastCreatedSeed;

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
            floraEffect = Content.Load<Effect>("floraEffect");
        }

        // UnloadContent
        protected override void UnloadContent()
        {
        }

        // generateMap
        public void generateMap(MapGeneratorOptions options)
        {
            // Only create a new random texture if it's needed
            Color[] data;
            if (lastCreatedSeed != options.seed || randomTexture == null)
            {
                // Initialize random number generator
                random = new Random(options.seed);

                // Initialize random texture
                data = new Color[options.noiseTextureWidth * options.noiseTextureHeight];
                for (int i = 0; i < options.noiseTextureWidth; i++)
                {
                    for (int j = 0; j < options.noiseTextureHeight; j++)
                    {
                        float randomNumber = (float)random.NextDouble();
                        data[i + j * options.noiseTextureWidth] = new Color(randomNumber, randomNumber, randomNumber);
                    }
                }
                randomTexture = new Texture2D(GraphicsDevice, options.noiseTextureWidth, options.noiseTextureHeight);
                randomTexture.SetData<Color>(data);

                // Store this seed
                lastCreatedSeed = options.seed;
            }

            // Initialize vertex shader properties
            Matrix projection = Matrix.CreateOrthographicOffCenter(0, options.width, options.height, 0, 0, 1);
            Matrix halfPixelOffset = Matrix.CreateTranslation(-0.5f, -0.5f, 0);
            Matrix matrixTransform = halfPixelOffset * projection;
            baseEffect.Parameters["matrixTransform"].SetValue(matrixTransform);

            // Only create a new renderTarget instance if it's needed
            if (renderTarget == null || renderTarget.Width != options.width || renderTarget.Height != options.height)
            {
                // Initialize render target
                renderTarget = new RenderTarget2D(GraphicsDevice, options.width, options.height);
            }
            
            //////////////////////////////////////
            // Draw noise effect to render target
            ///////////////////////////////////////
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Black);
            baseEffect.Parameters["position"].SetValue(options.position);
            baseEffect.Parameters["scale"].SetValue(options.scale);
            baseEffect.Parameters["renderTargetSize"].SetValue(new Vector2(options.width, options.height));
            baseEffect.Parameters["randomTextureSize"].SetValue(new Vector2(options.noiseTextureWidth, options.noiseTextureHeight));
            baseEffect.Parameters["noiseFrequency"].SetValue(options.noiseFrequency);
            baseEffect.Parameters["noiseGain"].SetValue(options.noiseGain);
            baseEffect.Parameters["noiseLacunarity"].SetValue(options.noiseLacunarity);
            baseEffect.Parameters["brightness"].SetValue(options.noiseBrightness);
            baseEffect.Parameters["fbm1"].SetValue(options.fbm1);
            baseEffect.Parameters["fbm2"].SetValue(options.fbm2);
            baseEffect.Parameters["fbm3"].SetValue(options.fbm3);
            baseEffect.Parameters["fbm1NoiseOnly"].SetValue(options.fbm1NoiseOnly);
            baseEffect.Parameters["fbm2NoiseOnly"].SetValue(options.fbm2NoiseOnly);
            baseEffect.Parameters["fbm3NoiseOnly"].SetValue(options.fbm3NoiseOnly);
            baseEffect.Parameters["fbm1Offset"].SetValue(options.fbm1Offset);
            baseEffect.Parameters["fbm2Offset"].SetValue(options.fbm2Offset);
            baseEffect.Parameters["fbm3Offset"].SetValue(options.fbm3Offset);
            baseEffect.Parameters["fbm1Opacity"].SetValue(options.fbm1Opacity);
            baseEffect.Parameters["fbm2Opacity"].SetValue(options.fbm2Opacity);
            baseEffect.Parameters["fbm3Opacity"].SetValue(options.fbm3Opacity);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, baseEffect);
            spriteBatch.Draw(randomTexture, renderTarget.Bounds, randomTexture.Bounds, Color.White);
            spriteBatch.End();

            // Store base noise texture
            data = new Color[options.width * options.height];
            baseNoise = new RenderTarget2D(GraphicsDevice, options.width, options.height);
            GraphicsDevice.SetRenderTarget(baseNoise);
            spriteBatch.Begin();
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();

            //////////////////////////////////////////
            // Draw water effect to render target
            //////////////////////////////////////////
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Transparent);
            waterEffect.Parameters["waterLevel"].SetValue(options.waterLevel);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, waterEffect);
            spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
            spriteBatch.End();

            // Store base water texture
            baseWater = new RenderTarget2D(GraphicsDevice, options.width, options.height);
            GraphicsDevice.SetRenderTarget(baseWater);
            GraphicsDevice.Clear(Color.Transparent);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();

            ////////////////////////////////
            // Draw flora effect
            ////////////////////////////////
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Transparent);
            floraEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, floraEffect);
            spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
            spriteBatch.End();

            // Store base flora texture
            baseFlora = new RenderTarget2D(GraphicsDevice, options.width, options.height);
            GraphicsDevice.SetRenderTarget(baseFlora);
            GraphicsDevice.Clear(Color.Transparent);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();

            // Draw all textures
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);
            spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
            spriteBatch.Draw(baseFlora, baseFlora.Bounds, Color.White);
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
            newMouseState = Mouse.GetState();

            // Input
            if (newKeyState.IsKeyDown(Keys.Home) && oldKeyState.IsKeyUp(Keys.Home))
                resetView();

            if (newKeyState.IsKeyDown(Keys.Enter) && oldKeyState.IsKeyUp(Keys.Enter))
                generateMap(mapGeneratorForm.getOptions());

            oldKeyState = newKeyState;
            oldMouseState = newMouseState;

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
