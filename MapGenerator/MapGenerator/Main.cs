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
        private Effect createNormalEffect;
        private Effect normalMapEffect;
        private RenderTarget2D baseNoise;
        private RenderTarget2D baseWater;
        private RenderTarget2D floraLayer1;
        private RenderTarget2D floraLayer2;
        private RenderTarget2D floraAlpha;
        private RenderTarget2D detailsLayer1;
        private RenderTarget2D detailsLayer2;
        private RenderTarget2D detailsLayer3;
        private RenderTarget2D detailAlpha;
        private RenderTarget2D normalMap;
        private RenderTarget2D alphaFix;
        private Texture2D randomTexture;
        private Texture2D worleyTexture;
        private Color[] randomTextureData;
        private int lastCreatedSeed;
        private List<Texture2D> flora1Textures;
        private List<Texture2D> flora2Textures;
        private List<Texture2D> detailsLayer1Textures;
        private List<Texture2D> detailsLayer2Textures;
        private List<Texture2D> detailsLayer3Textures;
        private Texture2D baseColor;

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
            MapGeneratorOptions options = mapGeneratorForm.getOptions();
            flora1Textures = new List<Texture2D>();
            flora2Textures = new List<Texture2D>();
            detailsLayer1Textures = new List<Texture2D>();
            detailsLayer2Textures = new List<Texture2D>();
            detailsLayer3Textures = new List<Texture2D>();
            setFlora1Textures(options.flora1TexturePaths);
            setFlora2Textures(options.flora2TexturePaths);
            setDetailsLayer1Textures(options.detailsLayer1TexturePaths);
            setDetailsLayer2Textures(options.detailsLayer2TexturePaths);
            setDetailsLayer3Textures(options.detailsLayer3TexturePaths);

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
            createNormalEffect = Content.Load<Effect>("createNormalEffect");
            normalMapEffect = Content.Load<Effect>("normalMapEffect");
            baseColor = new Texture2D(GraphicsDevice, 1, 1);
            baseColor.SetData<Color>(new Color[] { Color.Gray });
        }

        // UnloadContent
        protected override void UnloadContent()
        {
        }

        // setFlora1Textures
        public void setFlora1Textures(List<string> filePaths)
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

        // setFlora1Textures
        public void setFlora2Textures(List<string> filePaths)
        {
            flora2Textures.Clear();
            foreach (string filePath in filePaths)
            {
                try
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Open);
                    flora2Textures.Add(Texture2D.FromStream(GraphicsDevice, fileStream));
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
        public void setDetailsLayer1Textures(List<string> filePaths)
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
        public void setDetailsLayer2Textures(List<string> filePaths)
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

        // setDetailLayer3Textures
        public void setDetailsLayer3Textures(List<string> filePaths)
        {
            detailsLayer3Textures.Clear();
            foreach (string filePath in filePaths)
            {
                try
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Open);
                    detailsLayer3Textures.Add(Texture2D.FromStream(GraphicsDevice, fileStream));
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
                        randomTextureData[i + j * options.noiseTextureWidth] = new Color((float)random.Next(3) / 2, (float)random.Next(3) / 2, (float)random.Next(3) / 2);
                }
                randomTexture = new Texture2D(GraphicsDevice, options.noiseTextureWidth, options.noiseTextureHeight);
                randomTexture.SetData<Color>(randomTextureData);

                // Initialize worley texture
                Color[] data = new Color[options.noiseTextureWidth * options.noiseTextureHeight];
                for (int i = 0; i < options.noiseTextureWidth; i++)
                {
                    for (int j = 0; j < options.noiseTextureHeight; j++)
                        data[i + j * options.noiseTextureWidth] = new Color((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
                }
                worleyTexture = new Texture2D(GraphicsDevice, options.noiseTextureWidth, options.noiseTextureHeight);
                worleyTexture.SetData<Color>(data);

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
                floraLayer1 = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                floraLayer2 = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                baseWater = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                detailAlpha = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                floraAlpha = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                detailsLayer1 = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                detailsLayer2 = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                detailsLayer3 = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                normalMap = new RenderTarget2D(GraphicsDevice, options.width, options.height);
                alphaFix = new RenderTarget2D(GraphicsDevice, options.width, options.height);
            }

            //////////////////////////////////////
            // Draw noise effect to render target
            ///////////////////////////////////////
            // Base layer
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Textures[1] = randomTexture;
            GraphicsDevice.Textures[2] = worleyTexture;
            GraphicsDevice.Clear(Color.Black);
            baseEffect.Parameters["aspectRatio"].SetValue(options.getAspectRatio());
            baseEffect.Parameters["offset"].SetValue(options.position);
            baseEffect.Parameters["noiseScale"].SetValue(options.scale);
            baseEffect.Parameters["renderSize"].SetValue(new Vector2(options.width, options.height));
            baseEffect.Parameters["noiseSize"].SetValue(new Vector2(options.noiseTextureWidth, options.noiseTextureHeight));
            baseEffect.Parameters["noiseFrequency"].SetValue(options.noiseFrequency);
            baseEffect.Parameters["noiseGain"].SetValue(options.noiseGain);
            baseEffect.Parameters["noiseLacunarity"].SetValue(options.noiseLacunarity);
            baseEffect.Parameters["multiplier"].SetValue(options.noiseMultiplier);
            baseEffect.Parameters["fbmOffset"].SetValue(Vector2.Zero);
            baseEffect.Parameters["fbmPerlinBasis"].SetValue(options.fbm0Perlin);
            baseEffect.Parameters["fbmCellBasis"].SetValue(options.fbm0Cell);
            baseEffect.Parameters["fbmInvCellBasis"].SetValue(options.fbm0InvCell);
            baseEffect.Parameters["fbmScale"].SetValue(options.fbm0Scale);
            baseEffect.Parameters["noiseLowColor"].SetValue(options.noiseLowColor);
            baseEffect.Parameters["noiseHighColor"].SetValue(options.noiseHighColor);
            baseEffect.Parameters["fbmIterations"].SetValue(options.fbm0Iterations);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, baseEffect);
            spriteBatch.Draw(baseColor, renderTarget.Bounds, Color.White);
            spriteBatch.End();

            // Store
            GraphicsDevice.SetRenderTarget(baseNoise);
            spriteBatch.Begin();
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();

            // First fbm layer
            if (options.fbm1)
            {
                GraphicsDevice.SetRenderTarget(renderTarget);
                GraphicsDevice.Textures[1] = randomTexture;
                GraphicsDevice.Textures[2] = worleyTexture;
                GraphicsDevice.Clear(Color.Black);
                baseEffect.Parameters["fbmOffset"].SetValue(options.fbm1Offset);
                baseEffect.Parameters["fbmPerlinBasis"].SetValue(options.fbm1Perlin);
                baseEffect.Parameters["fbmCellBasis"].SetValue(options.fbm1Cell);
                baseEffect.Parameters["fbmInvCellBasis"].SetValue(options.fbm1InvCell);
                baseEffect.Parameters["fbmScale"].SetValue(options.fbm1Scale);
                baseEffect.Parameters["fbmIterations"].SetValue(options.fbm1Iterations);
                baseEffect.Parameters["multiplier"].SetValue(options.fbm1Multiplier);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, baseEffect);
                spriteBatch.Draw(baseNoise, renderTarget.Bounds, Color.White);
                spriteBatch.End();

                // Store
                GraphicsDevice.SetRenderTarget(baseNoise);
                spriteBatch.Begin();
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();
            }

            // Second fbm layer
            if (options.fbm2)
            {
                GraphicsDevice.SetRenderTarget(renderTarget);
                GraphicsDevice.Textures[1] = randomTexture;
                GraphicsDevice.Textures[2] = worleyTexture;
                GraphicsDevice.Clear(Color.Black);
                baseEffect.Parameters["fbmOffset"].SetValue(options.fbm2Offset);
                baseEffect.Parameters["fbmPerlinBasis"].SetValue(options.fbm2Perlin);
                baseEffect.Parameters["fbmCellBasis"].SetValue(options.fbm2Cell);
                baseEffect.Parameters["fbmInvCellBasis"].SetValue(options.fbm2InvCell);
                baseEffect.Parameters["fbmScale"].SetValue(options.fbm2Scale);
                baseEffect.Parameters["fbmIterations"].SetValue(options.fbm2Iterations);
                baseEffect.Parameters["multiplier"].SetValue(options.fbm2Multiplier);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, baseEffect);
                spriteBatch.Draw(baseNoise, renderTarget.Bounds, Color.White);
                spriteBatch.End();

                // Store
                GraphicsDevice.SetRenderTarget(baseNoise);
                spriteBatch.Begin();
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();
            }

            // Third fbm layer
            if (options.fbm3)
            {
                GraphicsDevice.SetRenderTarget(renderTarget);
                GraphicsDevice.Textures[1] = randomTexture;
                GraphicsDevice.Textures[2] = worleyTexture;
                GraphicsDevice.Clear(Color.Black);
                baseEffect.Parameters["fbmOffset"].SetValue(options.fbm3Offset);
                baseEffect.Parameters["fbmPerlinBasis"].SetValue(options.fbm3Perlin);
                baseEffect.Parameters["fbmCellBasis"].SetValue(options.fbm3Cell);
                baseEffect.Parameters["fbmInvCellBasis"].SetValue(options.fbm3InvCell);
                baseEffect.Parameters["fbmScale"].SetValue(options.fbm3Scale);
                baseEffect.Parameters["fbmIterations"].SetValue(options.fbm3Iterations);
                baseEffect.Parameters["multiplier"].SetValue(options.fbm3Multiplier);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, baseEffect);
                spriteBatch.Draw(baseNoise, renderTarget.Bounds, Color.White);
                spriteBatch.End();

                // Store
                GraphicsDevice.SetRenderTarget(baseNoise);
                spriteBatch.Begin();
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();
            }

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
                GraphicsDevice.SetRenderTarget(detailsLayer1);
                spriteBatch.Begin();
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                spriteBatch.End();
                GraphicsDevice.Textures[1] = detailAlpha;
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, null, null, null, maskEffect);
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();

                // Store first detail layer onto baseNoise
                GraphicsDevice.SetRenderTarget(baseNoise);
                spriteBatch.Begin();
                spriteBatch.Draw(detailsLayer1, detailsLayer1.Bounds, Color.White);
                spriteBatch.End();
            }

            //////////////////////////////////////////
            // Draw normal map
            //////////////////////////////////////////
            GraphicsDevice.SetRenderTarget(normalMap);
            GraphicsDevice.Clear(Color.Black);
            createNormalEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
            createNormalEffect.Parameters["renderTargetSize"].SetValue(new Vector2(options.width, options.height));
            createNormalEffect.Parameters["normalStrength"].SetValue(options.normalStrength);
            spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, createNormalEffect);
            spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
            spriteBatch.End();

            //////////////////////////////////////////
            // Draw water effect to render target
            //////////////////////////////////////////
            if (options.water)
            {
                GraphicsDevice.SetRenderTarget(renderTarget);
                GraphicsDevice.Clear(Color.Transparent);
                waterEffect.Parameters["waterLevel"].SetValue(options.waterLevel);
                waterEffect.Parameters["shallowColor"].SetValue(options.waterShallowColor);
                waterEffect.Parameters["deepColor"].SetValue(options.waterDeepColor);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, null, null, null, waterEffect);
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                spriteBatch.End();

                // Store base water texture
                GraphicsDevice.SetRenderTarget(baseWater);
                GraphicsDevice.Clear(Color.Transparent);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();
            }

            ////////////////////////////////
            // Draw flora layer 1 effect
            ////////////////////////////////
            if (options.flora1)
            {
                GraphicsDevice.SetRenderTarget(floraAlpha);
                GraphicsDevice.Clear(Color.Transparent);
                floraEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
                floraEffect.Parameters["floraRange"].SetValue(options.flora1Range);
                floraEffect.Parameters["color"].SetValue(options.flora1GroundColor);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, floraEffect);
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                //spriteBatch.Draw(baseDetail, baseDetail.Bounds, Color.White);
                spriteBatch.End();

                // Get pixel information from render target and use it to draw flora sprites
                Color[] data = new Color[options.width * options.height];
                GraphicsDevice.SetRenderTarget(null);
                floraAlpha.GetData<Color>(data);
                GraphicsDevice.SetRenderTarget(floraLayer1);
                GraphicsDevice.Clear(Color.Transparent);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);
                if (options.flora1ShowGroundColor)    // only show color if checked
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

                            // Value at pixel
                            float value = (float)pixel.A / 255f;
                            textureColor = new Color(options.flora1PlantColor.X, options.flora1PlantColor.Y, options.flora1PlantColor.Z, 1);

                            // Draw
                            spriteBatch.Draw(texture, new Vector2(i, j), texture.Bounds, textureColor, angle, new Vector2(texture.Width, texture.Height) / 2, alpha * options.flora1Scale, SpriteEffects.None, 0);
                        }
                    }
                }
                spriteBatch.End();
            }

            ////////////////////////////////
            // Draw flora layer 2 effect
            ////////////////////////////////
            if (options.flora2)
            {
                GraphicsDevice.SetRenderTarget(floraAlpha);
                GraphicsDevice.Clear(Color.Transparent);
                floraEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
                floraEffect.Parameters["floraRange"].SetValue(options.flora2Range);
                floraEffect.Parameters["color"].SetValue(options.flora2GroundColor);
                spriteBatch.Begin(SpriteSortMode.Immediate, null, null, null, null, floraEffect);
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                //spriteBatch.Draw(baseDetail, baseDetail.Bounds, Color.White);
                spriteBatch.End();

                // Get pixel information from render target and use it to draw flora sprites
                Color[] data = new Color[options.width * options.height];
                GraphicsDevice.SetRenderTarget(null);
                floraAlpha.GetData<Color>(data);
                GraphicsDevice.SetRenderTarget(floraLayer2);
                GraphicsDevice.Clear(Color.Transparent);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);
                if (options.flora2ShowGroundColor)    // only show color if checked
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
                        if (chance <= options.flora2Frequency * alpha)
                        {
                            // Get a texture
                            int textureIndex = random.Next(flora2Textures.Count);
                            Texture2D texture = flora2Textures[textureIndex];

                            // Drawing properties
                            float angle = (float)random.NextDouble() * 6.28f;

                            // Value at pixel
                            float value = (float)pixel.A / 255f;
                            textureColor = new Color(options.flora2PlantColor.X, options.flora2PlantColor.Y, options.flora2PlantColor.Z, 1);

                            // Draw
                            spriteBatch.Draw(texture, new Vector2(i, j), texture.Bounds, textureColor, angle, new Vector2(texture.Width, texture.Height) / 2, alpha * options.flora2Scale, SpriteEffects.None, 0);
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

                // Draw detail using mask effect
                GraphicsDevice.SetRenderTarget(detailsLayer2);
                GraphicsDevice.Clear(Color.Transparent);
                GraphicsDevice.Textures[1] = detailAlpha;
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, null, null, null, maskEffect);
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();
            }

            //////////////////////////////////////////
            // Draw detail layer 3 effect
            //////////////////////////////////////////
            if (options.detailsLayer3)
            {
                GraphicsDevice.SetRenderTarget(detailAlpha);
                GraphicsDevice.Clear(Color.Transparent);
                detailEffect.Parameters["matrixTransform"].SetValue(matrixTransform);
                detailEffect.Parameters["layerRange"].SetValue(options.detailsLayer3Range);
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
                float xIncrement = (options.width / (32 / options.detailsLayer3Scale));
                float yIncrement = (options.height / (32 / options.detailsLayer3Scale));
                for (float i = 0; i < options.width; i += xIncrement)
                {
                    for (float j = 0; j < options.height; j += yIncrement)
                    {
                        textureColor = data[(int)i + (int)j * options.width];
                        float alpha = (float)textureColor.A / 255f;
                        float chance = (float)random.NextDouble();

                        Texture2D texture = detailsLayer3Textures[random.Next(detailsLayer3Textures.Count)];
                        Vector2 jitter = new Vector2(
                            ((float)random.NextDouble() * 2 - 1) * xIncrement * options.detailsLayer3Scale,
                            ((float)random.NextDouble() * 2 - 1) * yIncrement * options.detailsLayer3Scale);
                        float angle = chance * 6.28f;
                        spriteBatch.Draw(texture, new Vector2(i, j) + jitter, texture.Bounds, Color.White, angle, new Vector2(texture.Width, texture.Height) / 2, options.detailsLayer3Scale, SpriteEffects.None, 0);
                    }
                }
                spriteBatch.End();

                // Draw baseDetail using mask effect
                GraphicsDevice.SetRenderTarget(detailsLayer3);
                GraphicsDevice.Clear(Color.Transparent);
                GraphicsDevice.Textures[1] = detailAlpha;
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, null, null, null, maskEffect);
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();
            }
            
            ////////////////////////////////
            // Draw all textures
            ////////////////////////////////
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Black);
            
            if (options.light1 || options.light2)
            {
                GraphicsDevice.Textures[1] = normalMap;
                normalMapEffect.Parameters["light1"].SetValue(options.light1);
                normalMapEffect.Parameters["light1Color"].SetValue(options.light1Color);
                normalMapEffect.Parameters["light1Direction"].SetValue(options.light1Direction);
                normalMapEffect.Parameters["light1AmbientColor"].SetValue(options.light1AmbientColor);
                normalMapEffect.Parameters["light1Intensity"].SetValue(options.light1Intensity);
                normalMapEffect.Parameters["light2"].SetValue(options.light2);
                normalMapEffect.Parameters["light2Color"].SetValue(options.light2Color);
                normalMapEffect.Parameters["light2Direction"].SetValue(options.light2Direction);
                normalMapEffect.Parameters["light2AmbientColor"].SetValue(options.light2AmbientColor);
                normalMapEffect.Parameters["light2Intensity"].SetValue(options.light2Intensity);
                normalMapEffect.Parameters["standalone"].SetValue(false);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, null, null, null, normalMapEffect);
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                if (options.flora1)
                    spriteBatch.Draw(floraLayer1, floraLayer1.Bounds, Color.White);
                if (options.flora2)
                    spriteBatch.Draw(floraLayer2, floraLayer2.Bounds, Color.White);
                if (options.detailsLayer2)
                    spriteBatch.Draw(detailsLayer2, detailsLayer2.Bounds, Color.White);
                if (options.detailsLayer3)
                    spriteBatch.Draw(detailsLayer3, detailsLayer3.Bounds, Color.White);
                spriteBatch.End();
            }

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied);

            if (!options.light1 && !options.light2)
            {
                spriteBatch.Draw(baseNoise, baseNoise.Bounds, Color.White);
                if (options.flora1)
                    spriteBatch.Draw(floraLayer1, floraLayer1.Bounds, Color.White);
                if (options.flora2)
                    spriteBatch.Draw(floraLayer2, floraLayer2.Bounds, Color.White);
                if (options.detailsLayer2)
                    spriteBatch.Draw(detailsLayer2, detailsLayer2.Bounds, Color.White);
                if (options.detailsLayer3)
                    spriteBatch.Draw(detailsLayer3, detailsLayer3.Bounds, Color.White);
            }

            if (options.water)
            {
                spriteBatch.Draw(baseWater, baseWater.Bounds, Color.White);
            }

            spriteBatch.End();

            
            //GraphicsDevice.SetRenderTarget(renderTarget);
            //GraphicsDevice.Clear(Color.Black);
            //spriteBatch.Begin();
            //spriteBatch.Draw(normalMap, normalMap.Bounds, Color.White);
            //spriteBatch.End();

            // Hacky fix for render target transparency problem
            GraphicsDevice.SetRenderTarget(alphaFix);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
            spriteBatch.End();
            GraphicsDevice.SetRenderTarget(renderTarget);
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();
            spriteBatch.Draw(alphaFix, alphaFix.Bounds, Color.White);
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
        public void saveLayers(string fileBase, MapGeneratorOptions options, BatchSaveLayerOptions saveLayerOptions)
        {
            string path = fileBase;
            FileStream fileStream;

            // Base noise
            if (saveLayerOptions.baseLayer)
            {
                fileStream = new FileStream(string.Format("{0}-base.png", path), FileMode.Create);
                baseNoise.SaveAsPng(fileStream, baseNoise.Width, baseNoise.Height);
                fileStream.Close();
            }

            // Flora layer 1
            if (saveLayerOptions.floraLayer1)
            {
                fileStream = new FileStream(string.Format("{0}-flora-1.png", path), FileMode.Create);
                floraLayer1.SaveAsPng(fileStream, floraLayer1.Width, floraLayer1.Height);
                fileStream.Close();
            }

            // Flora layer 2
            if (saveLayerOptions.floraLayer2)
            {
                fileStream = new FileStream(string.Format("{0}-flora-2.png", path), FileMode.Create);
                floraLayer2.SaveAsPng(fileStream, floraLayer2.Width, floraLayer2.Height);
                fileStream.Close();
            }

            // Normal map
            if (saveLayerOptions.normalsLayer)
            {
                fileStream = new FileStream(string.Format("{0}-normals.png", path), FileMode.Create);
                normalMap.SaveAsPng(fileStream, normalMap.Width, normalMap.Height);
                fileStream.Close();
            }

            // Shadows
            if (saveLayerOptions.shadowLayer)
            {
                // Draw normal map onto disposable canvas
                RenderTarget2D canvas = new RenderTarget2D(GraphicsDevice, baseNoise.Width, baseNoise.Height);
                GraphicsDevice.SetRenderTarget(canvas);
                GraphicsDevice.Textures[1] = normalMap;
                normalMapEffect.Parameters["light1"].SetValue(options.light1);
                normalMapEffect.Parameters["light1Color"].SetValue(options.light1Color);
                normalMapEffect.Parameters["light1Direction"].SetValue(options.light1Direction);
                normalMapEffect.Parameters["light1AmbientColor"].SetValue(options.light1AmbientColor);
                normalMapEffect.Parameters["light1Intensity"].SetValue(options.light1Intensity);
                normalMapEffect.Parameters["light2"].SetValue(options.light2);
                normalMapEffect.Parameters["light2Color"].SetValue(options.light2Color);
                normalMapEffect.Parameters["light2Direction"].SetValue(options.light2Direction);
                normalMapEffect.Parameters["light2AmbientColor"].SetValue(options.light2AmbientColor);
                normalMapEffect.Parameters["light2Intensity"].SetValue(options.light2Intensity);
                normalMapEffect.Parameters["standalone"].SetValue(true);
                spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.NonPremultiplied, null, null, null, normalMapEffect);
                spriteBatch.Draw(renderTarget, renderTarget.Bounds, Color.White);
                spriteBatch.End();
                GraphicsDevice.SetRenderTarget(null);

                // Save
                fileStream = new FileStream(string.Format("{0}-shadow.png", path), FileMode.Create);
                canvas.SaveAsPng(fileStream, canvas.Width, canvas.Height);
                fileStream.Close();

                // Dispose of canvas
                canvas.Dispose();
            }

            // Detail layer 1
            if (saveLayerOptions.detailsLayer1)
            {
                fileStream = new FileStream(string.Format("{0}-details-1.png", path), FileMode.Create);
                detailsLayer1.SaveAsPng(fileStream, detailsLayer1.Width, detailsLayer1.Height);
                fileStream.Close();
            }

            // Detail layer 2
            if (saveLayerOptions.detailsLayer2)
            {
                fileStream = new FileStream(string.Format("{0}-details-2.png", path), FileMode.Create);
                detailsLayer2.SaveAsPng(fileStream, detailsLayer2.Width, detailsLayer2.Height);
                fileStream.Close();
            }

            // Detail layer 3
            if (saveLayerOptions.detailsLayer3)
            {
                fileStream = new FileStream(string.Format("{0}-details-3.png", path), FileMode.Create);
                detailsLayer3.SaveAsPng(fileStream, detailsLayer3.Width, detailsLayer3.Height);
                fileStream.Close();
            }

            // Water
            if (saveLayerOptions.waterLayer)
            {
                fileStream = new FileStream(string.Format("{0}-water.png", path), FileMode.Create);
                baseWater.SaveAsPng(fileStream, baseWater.Width, baseWater.Height);
                fileStream.Close();
            }
        }

        // saveComposite
        public void saveComposite(string fileBase)
        {
            string path = fileBase;
            FileStream fileStream = new FileStream(fileBase, FileMode.Create);
            renderTarget.SaveAsPng(fileStream, renderTarget.Width, renderTarget.Height);
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
