using System;
using System.Collections.Generic;
using System.IO;
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
        private Effect detailEffect;
        private Effect maskEffect;
        private RenderTarget2D baseNoise;
        private RenderTarget2D baseWater;
        private RenderTarget2D baseFlora;
        private RenderTarget2D floraAlpha;
        private RenderTarget2D baseDetail;
        private RenderTarget2D detailAlpha;
        private Texture2D randomTexture;
        private Texture2D worleyTexture;
        private Color[] randomTextureData;
        private int lastCreatedSeed;
        private List<Texture2D> flora1Textures;
        private List<Texture2D> detailsLayer1Textures;
        private List<Texture2D> detailsLayer2Textures;

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

            // Load default textures
            flora1Textures = new List<Texture2D>();
            setFlora1Textures(new string[] { string.Format("{0}textures\\flora\\tree_1.png", AppDomain.CurrentDomain.BaseDirectory) });
            detailsLayer1Textures = new List<Texture2D>();
            setDetailsLayer1Textures(new string[] { string.Format("{0}textures\\details\\cracked_terrain.png", AppDomain.CurrentDomain.BaseDirectory) });
            detailsLayer2Textures = new List<Texture2D>();
            setDetailsLayer2Textures(new string[] { string.Format("{0}textures\\details\\gravel.png", AppDomain.CurrentDomain.BaseDirectory) });

            // Initialize view position
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
            detailEffect = Content.Load<Effect>("detailEffect");
            maskEffect = Content.Load<Effect>("maskEffect");
        }

        // UnloadContent
        protected override void UnloadContent()
        {
        }

        // setFlora1Textures
        public void setFlora1Textures(string[] filePaths)
        {
            flora1Textures.Clear();
            foreach (string filePath in filePaths)
            {
                try
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Open);
                    flora1Textures.Add(Texture2D.FromStream(GraphicsDevice, fileStream));
                    Console.WriteLine("Loaded: {0} ({1} bytes)", filePath, fileStream.Length);
                    fileStream.Close();
                }
                catch (FileNotFoundException e)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format(
                        "Error loading texture file at: {0}\nEither replace this file and reload the program, or select a new texture in the 'Flora' section.", e.FileName));
                }
            }
        }

        // setDetailLayer1Textures
        public void setDetailsLayer1Textures(string[] filePaths)
        {
            detailsLayer1Textures.Clear();
            foreach (string filePath in filePaths)
            {
                try
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Open);
                    detailsLayer1Textures.Add(Texture2D.FromStream(GraphicsDevice, fileStream));
                    Console.WriteLine("Loaded: {0} ({1} bytes)", filePath, fileStream.Length);
                    fileStream.Close();
                }
                catch (FileNotFoundException e)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format(
                        "Error loading texture file at: {0}\nEither replace this file and reload the program, or select a new texture in the 'Details' section.", e.FileName));
                }
            }
        }

        // setDetailLayer2Textures
        public void setDetailsLayer2Textures(string[] filePaths)
        {
            detailsLayer2Textures.Clear();
            foreach (string filePath in filePaths)
            {
                try
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Open);
                    detailsLayer2Textures.Add(Texture2D.FromStream(GraphicsDevice, fileStream));
                    Console.WriteLine("Loaded: {0} ({1} bytes)", filePath, fileStream.Length);
                    fileStream.Close();
                }
                catch (FileNotFoundException e)
                {
                    System.Windows.Forms.MessageBox.Show(string.Format(
                        "Error loading texture file at: {0}\nEither replace this file and reload the program, or select a new texture in the 'Details' section.", e.FileName));
                }
            }
        }

        // generateMap
        public void generateMap(MapGeneratorOptions options)
        {
            // Recreate random generator
            random = new Random(options.seed);

            // Only create a new random texture if it's needed
            if (lastCreatedSeed != options.seed || randomTexture == null)
            {
                // Initialize random texture
                randomTextureData = new Color[options.noiseTextureWidth * options.noiseTextureHeight];
                for (int i = 0; i < options.noiseTextureWidth; i++)
                {
                    for (int j = 0; j < options.noiseTextureHeight; j++)
                    {
                        float randomNumber = (float)random.NextDouble();
                        randomTextureData[i + j * options.noiseTextureWidth] = new Color(randomNumber, randomNumber, randomNumber);
                    }
                }
                randomTexture = new Texture2D(GraphicsDevice, options.noiseTextureWidth, options.noiseTextureHeight);
                randomTexture.SetData<Color>(randomTextureData);

                // Initialize worley texture
                worleyTexture = new Texture2D(GraphicsDevice, 16, 1);
                Color[] worleyData = new Color[16];
                for (int i = 0; i < 16; i++)
                {
                    float x = ((i % 4 + 0.5f) / 4f);
                    x += (float)(random.NextDouble() * 2 - 1) / 3;
                    float y = (float)(Math.Floor(i / 4f) + 0.5f) / 4f;
                    y += (float)(random.NextDouble() * 2 - 1) / 3;
                    worleyData[i] = new Color(x, y, 1, 1);
                }
                worleyTexture.SetData<Color>(worleyData);

                // Store this seed
                lastCreatedSeed = options.seed;
            }

            // Initialize vertex shader properties
            Matrix projection = Matrix.CreateOrthographicOffCenter(0, options.width, options.height, 0, 0, 1);
            Matrix halfPixelOffset = Matrix.CreateTranslation(-0.5f, -0.5f, 0);
            Matrix matrixTransform = halfPixelOffset * projection;
            baseEffect.Parameters["matrixTransform"].SetValue(matrixTransform);

            // Only create new render targets if it's needed
            if (renderTarget == null || renderTarget.Width != options.width || renderTarget.Height != options.height)
            {
                // Initialize render target
                renderTarget = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                baseNoise = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                baseFlora = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                baseWater = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                baseDetail = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                detailAlpha = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                floraAlpha = new RenderTarget2D(GraphicsDevice, options.width, options.height);
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
            GraphicsDevice.SetRenderTarget(baseNoise);
            spriteBatch.Begin();
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();

            //////////////////////////////////////////
            // Draw detail layer 1 effect
            //////////////////////////////////////////
            if (options.detailsLayer1)
            {
                GraphicsDevice.SetRenderTarget(detailAlpha);
                GraphicsDevice.Clear(Color.Transparent);
                detailEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
                detailEffect.Parameters["layerRange"].SetValue(options.detailsLayer1Range);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, detailEffect);
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                spriteBatch.End();

                // Get pixel information from render target and use it to draw sprites
                Color[] data = new Color[options.width * options.height];
                GraphicsDevice.SetRenderTarget(null);
                detailAlpha.GetData<Color>(data);
                GraphicsDevice.SetRenderTarget(renderTarget);
                GraphicsDevice.Clear(Color.Transparent);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);
                Color textureColor;
                float xIncrement = (options.width / (32 / options.detailsLayer1Scale));
                float yIncrement = (options.height / (32 / options.detailsLayer1Scale));
                for (float i = 0; i < options.width; i += xIncrement)
                {
                    for (float j = 0; j < options.height; j += yIncrement)
                    {
                        textureColor = data[(int)i + (int)j * options.width];
                        float alpha = (float)textureColor.A / 255f;
                        float chance = (float)random.NextDouble();

                        Texture2D texture = detailsLayer1Textures[random.Next(detailsLayer1Textures.Count)];
                        Vector2 jitter = new Vector2(
                            ((float)random.NextDouble() * 2 - 1) * xIncrement * options.detailsLayer1Scale,
                            ((float)random.NextDouble() * 2 - 1) * yIncrement * options.detailsLayer1Scale);
                        float angle = chance * 6.28f;
                        spriteBatch.Draw(texture, new Vector2(i, j) + jitter, texture.Bounds, Color.White, angle, new Vector2(texture.Width, texture.Height) / 2, options.detailsLayer1Scale, SpriteEffects.None, 0);
                    }
                }
                spriteBatch.End();

                // Draw baseDetail using mask effect
                GraphicsDevice.SetRenderTarget(baseDetail);
                spriteBatch.Begin();
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                spriteBatch.End();
                GraphicsDevice.Textures[1] = detailAlpha;
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, null, null, null, maskEffect);
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();

                // Store as baseNoise
                GraphicsDevice.SetRenderTarget(baseNoise);
                spriteBatch.Begin();
                spriteBatch.Draw(baseDetail, baseDetail.Bounds, Color.White);
                spriteBatch.End();
            }

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
            GraphicsDevice.SetRenderTarget(baseWater);
            GraphicsDevice.Clear(Color.Transparent);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();

            ////////////////////////////////
            // Draw flora effect
            ////////////////////////////////
            if (options.flora1)
            {
                GraphicsDevice.SetRenderTarget(floraAlpha);
                GraphicsDevice.Clear(Color.Transparent);
                floraEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
                floraEffect.Parameters["flora1"].SetValue(options.flora1);
                floraEffect.Parameters["flora1Range"].SetValue(options.flora1Range);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, floraEffect);
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                //spriteBatch.Draw(baseDetail, baseDetail.Bounds, Color.White);
                spriteBatch.End();

                // Get pixel information from render target and use it to draw flora sprites
                Color[] data = new Color[options.width * options.height];
                GraphicsDevice.SetRenderTarget(null);
                floraAlpha.GetData<Color>(data);
                GraphicsDevice.SetRenderTarget(baseFlora);
                GraphicsDevice.Clear(Color.Transparent);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
                spriteBatch.Draw(floraAlpha, renderTarget.Bounds, Color.White);
                Color textureColor;
                for (int i = 0; i < options.width; i++)
                {
                    for (int j = 0; j < options.height; j++)
                    {
                        // Get pixel data created by the flora effect
                        Color pixel = data[i + j * options.width];
                        float alpha = (float)pixel.A / 255f;

                        // Get a pseudo-random number
                        float chance = (float)random.NextDouble();
                        //Console.WriteLine(chance);

                        // Compare random number to the flora frequency and its distance away from the middle of its range (alpha)
                        if (chance <= options.flora1Frequency * alpha)
                        {
                            // Get a texture
                            int textureIndex = random.Next(flora1Textures.Count);
                            Texture2D texture = flora1Textures[textureIndex];

                            // Drawing properties
                            float angle = (float)random.NextDouble() * 6.28f;
                            float colorValue = (float)pixel.G / 75;
                            colorValue *= 1 - chance;
                            textureColor = new Color(colorValue, colorValue, colorValue, 1);

                            // Draw
                            spriteBatch.Draw(texture, new Vector2(i, j), texture.Bounds, textureColor, angle, new Vector2(texture.Width, texture.Height) / 2, alpha * options.flora1Scale, SpriteEffects.None, 0);
                        }
                    }
                }
                spriteBatch.End();
            }

            //////////////////////////////////////////
            // Draw detail layer 2 effect
            //////////////////////////////////////////
            if (options.detailsLayer2)
            {
                GraphicsDevice.SetRenderTarget(detailAlpha);
                GraphicsDevice.Clear(Color.Transparent);
                detailEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
                detailEffect.Parameters["layerRange"].SetValue(options.detailsLayer2Range);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, detailEffect);
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                spriteBatch.End();

                // Get pixel information from render target and use it to draw sprites
                Color[] data = new Color[options.width * options.height];
                GraphicsDevice.SetRenderTarget(null);
                detailAlpha.GetData<Color>(data);
                GraphicsDevice.SetRenderTarget(renderTarget);
                GraphicsDevice.Clear(Color.Transparent);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);
                Color textureColor;
                float xIncrement = (options.width / (32 / options.detailsLayer2Scale));
                float yIncrement = (options.height / (32 / options.detailsLayer2Scale));
                for (float i = 0; i < options.width; i += xIncrement)
                {
                    for (float j = 0; j < options.height; j += yIncrement)
                    {
                        textureColor = data[(int)i + (int)j * options.width];
                        float alpha = (float)textureColor.A / 255f;
                        float chance = (float)random.NextDouble();

                        Texture2D texture = detailsLayer2Textures[random.Next(detailsLayer2Textures.Count)];
                        Vector2 jitter = new Vector2(
                            ((float)random.NextDouble() * 2 - 1) * xIncrement * options.detailsLayer2Scale,
                            ((float)random.NextDouble() * 2 - 1) * yIncrement * options.detailsLayer2Scale);
                        float angle = chance * 6.28f;
                        spriteBatch.Draw(texture, new Vector2(i, j) + jitter, texture.Bounds, Color.White, angle, new Vector2(texture.Width, texture.Height) / 2, options.detailsLayer2Scale, SpriteEffects.None, 0);
                    }
                }
                spriteBatch.End();

                // Draw baseDetail using mask effect
                GraphicsDevice.SetRenderTarget(baseDetail);
                spriteBatch.Begin();
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                spriteBatch.End();
                GraphicsDevice.Textures[1] = detailAlpha;
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, null, null, null, maskEffect);
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();

                // Store as baseNoise
                GraphicsDevice.SetRenderTarget(baseNoise);
                spriteBatch.Begin();
                spriteBatch.Draw(baseDetail, baseDetail.Bounds, Color.White);
                spriteBatch.End();
            }

            /*
            // Store base flora texture
            GraphicsDevice.SetRenderTarget(baseFlora);
            GraphicsDevice.Clear(Color.Transparent);
            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();
            */

            // Draw all textures
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);
            spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
            //if (options.detailsLayer1)
            //    spriteBatch.Draw(baseDetail, baseDetail.Bounds, Color.White);
            if (options.flora1)
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

        // saveLayers
        public void saveLayers(string fileBase)
        {
            string path = fileBase;
            FileStream fileStream = new FileStream(string.Format("{0}-baseNoise.png", path), FileMode.OpenOrCreate);
            baseNoise.SaveAsPng(fileStream, baseNoise.Width, baseNoise.Height);
            fileStream.Close();

            fileStream = new FileStream(string.Format("{0}-baseFlora.png", path), FileMode.OpenOrCreate);
            baseFlora.SaveAsPng(fileStream, baseFlora.Width, baseFlora.Height);
            fileStream.Close();

            fileStream = new FileStream(string.Format("{0}-baseWater.png", path), FileMode.OpenOrCreate);
            baseWater.SaveAsPng(fileStream, baseWater.Width, baseWater.Height);
            fileStream.Close();
        }

        // saveComposite
        public void saveComposite(string fileBase)
        {
            string path = fileBase;
            FileStream fileStream = new FileStream(fileBase, FileMode.OpenOrCreate);
            renderTarget.SaveAsJpeg(fileStream, renderTarget.Width, renderTarget.Height);
            fileStream.Close();
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
