using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MapGenerator
{
    public struct MapGeneratorOptions
    {
        public int width;
        public int height;
        public int seed;
        public float scale;
        public Microsoft.Xna.Framework.Vector2 position;

        public int noiseTextureWidth;
        public int noiseTextureHeight;

        public float noiseFrequency;
        public float noiseGain;
        public float noiseLacunarity;
        public float noiseBrightness;
        public Microsoft.Xna.Framework.Vector4 noiseLowColor;
        public Microsoft.Xna.Framework.Vector4 noiseHighColor;

        public bool worley;
        public bool fbm1;
        public bool fbm2;
        public bool fbm3;
        public bool fbm1NoiseOnly;
        public bool fbm2NoiseOnly;
        public bool fbm3NoiseOnly;
        public Microsoft.Xna.Framework.Vector2 fbm1Offset;
        public Microsoft.Xna.Framework.Vector2 fbm2Offset;
        public Microsoft.Xna.Framework.Vector2 fbm3Offset;
        public float fbm1Opacity;
        public float fbm2Opacity;
        public float fbm3Opacity;

        public bool flora1;
        public Microsoft.Xna.Framework.Vector2 flora1Range;
        public float flora1Frequency;
        public float flora1Scale;
        public Microsoft.Xna.Framework.Vector4 flora1GroundColor;
        public Microsoft.Xna.Framework.Vector4 flora1PlantColor;
        public bool flora1ShowGroundColor;
        public bool flora1ShowPlantColor;

        public bool flora2;
        public Microsoft.Xna.Framework.Vector2 flora2Range;
        public float flora2Frequency;
        public float flora2Scale;
        public Microsoft.Xna.Framework.Vector4 flora2GroundColor;
        public Microsoft.Xna.Framework.Vector4 flora2PlantColor;
        public bool flora2ShowGroundColor;
        public bool flora2ShowPlantColor;

        public bool detailsLayer1;
        public Microsoft.Xna.Framework.Vector2 detailsLayer1Range;
        public float detailsLayer1Scale;
        public bool detailsLayer2;
        public Microsoft.Xna.Framework.Vector2 detailsLayer2Range;
        public float detailsLayer2Scale;
        public bool detailsLayer3;
        public Microsoft.Xna.Framework.Vector2 detailsLayer3Range;
        public float detailsLayer3Scale;

        public bool water;
        public float waterLevel;
        public Microsoft.Xna.Framework.Vector4 waterShallowColor;
        public Microsoft.Xna.Framework.Vector4 waterDeepColor;

        public bool normals;
        public Microsoft.Xna.Framework.Vector3 lightColor;
        public Microsoft.Xna.Framework.Vector3 lightDirection;
        public Microsoft.Xna.Framework.Vector3 lightAmbientColor;
    };

    public partial class MapGeneratorForm : Form
    {
        public Main main;
        private Point lastDragPosition;
        private bool ctrl;
        private Microsoft.Xna.Framework.Vector2 effectPosition;
        private MapGeneratorOptions options;
        private bool blockGenerateMap;
        private bool redrawMap;
        private Color flora1GroundColor = Color.LimeGreen;
        private Color flora1PlantColor = Color.White;
        private Color flora2GroundColor = Color.Blue;
        private Color flora2PlantColor = Color.LightBlue;
        private Color waterShallowColor = Color.Blue;
        private Color waterDeepColor = Color.DarkBlue;
        private Color noiseLowColor = Color.Black;
        private Color noiseHighColor = Color.White;
        private Color lightColor = Color.White;
        private Color lightAmbientColor = Color.Black;

        public MapGeneratorForm()
        {
            options = new MapGeneratorOptions();
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(MapGeneratorForm_FormClosed);
            Resize += new EventHandler(MapGeneratorForm_Resize);
            flora1GroundColorPicture.BackColor = flora1GroundColor;
            flora1PlantColorPicture.BackColor = flora1PlantColor;
            flora2GroundColorPicture.BackColor = flora2GroundColor;
            flora2PlantColorPicture.BackColor = flora2PlantColor;
            waterShallowColorPicture.BackColor = waterShallowColor;
            waterDeepColorPicture.BackColor = waterDeepColor;
            noiseLowColorPicture.BackColor = noiseLowColor;
            noiseHighColorPicture.BackColor = noiseHighColor;
            lightColorPicture.BackColor = lightColor;
            lightAmbientColorPicture.BackColor = lightAmbientColor;
        }

        void MapGeneratorForm_Resize(object sender, EventArgs e)
        {
            // Resize surface
            surface.Width = Width - surface.Location.X;
            surface.Height = Height;

            // Resize main options control
            mainOptionsControl.Height = Height - 83;

            // Resize graphics device
            Main.graphics.PreferredBackBufferWidth = surface.Width;
            Main.graphics.PreferredBackBufferHeight = surface.Height;
            Main.graphics.ApplyChanges();

            // Redraw map
            if (main.renderTarget != null)
                main.generateMap(getOptions());
        }

        void MapGeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //main.resetView();
            main.generateMap(getOptions());
        }

        public MapGeneratorOptions getOptions()
        {
            // General
            options.width = (int)renderWidth.Value;
            options.height = (int)renderHeight.Value;
            options.seed = (int)noiseSeed.Value;
            options.scale = (float)noiseScale.Value;
            options.position.X = (float)noisePositionX.Value;
            options.position.Y = (float)noisePositionY.Value;

            // Noise texture
            options.worley = worleyCheckbox.Checked;
            options.noiseTextureWidth = (int)noiseTextureWidth.Value;
            options.noiseTextureHeight = (int)noiseTextureHeight.Value;
            options.noiseFrequency = (float)noiseFrequency.Value;
            options.noiseGain = (float)noiseGain.Value;
            options.noiseLacunarity = (float)noiseLacunarity.Value;
            options.noiseBrightness = (float)noiseBrightness.Value;
            options.noiseLowColor = new Microsoft.Xna.Framework.Vector4(
                (float)noiseLowColor.R / 255f,
                (float)noiseLowColor.G / 255f,
                (float)noiseLowColor.B / 255f,
                (float)noiseLowColor.A / 255f);
            options.noiseHighColor = new Microsoft.Xna.Framework.Vector4(
                (float)noiseHighColor.R / 255f,
                (float)noiseHighColor.G / 255f,
                (float)noiseHighColor.B / 255f,
                (float)noiseHighColor.A / 255f);

            // Fractional brownian motion
            options.fbm1 = fbm1Checkbox.Checked;
            options.fbm2 = fbm2Checkbox.Checked;
            options.fbm3 = fbm3Checkbox.Checked;
            options.fbm1NoiseOnly = fbm1NoiseOnly.Checked;
            options.fbm2NoiseOnly = fbm2NoiseOnly.Checked;
            options.fbm3NoiseOnly = fbm3NoiseOnly.Checked;
            options.fbm1Offset = new Microsoft.Xna.Framework.Vector2(
                (float)fbm1OffsetX.Value, (float)fbm1OffsetY.Value);
            options.fbm2Offset = new Microsoft.Xna.Framework.Vector2(
                (float)fbm2OffsetX.Value, (float)fbm2OffsetY.Value);
            options.fbm3Offset = new Microsoft.Xna.Framework.Vector2(
                (float)fbm3OffsetX.Value, (float)fbm3OffsetY.Value);
            options.fbm1Opacity = (float)fbm1Opacity.Value;
            options.fbm2Opacity = (float)fbm2Opacity.Value;
            options.fbm3Opacity = (float)fbm3Opacity.Value;

            // Water
            options.water = waterCheckbox.Checked;
            options.waterLevel = (float)waterLevel.Value;
            options.waterShallowColor = new Microsoft.Xna.Framework.Vector4(
                (float)waterShallowColor.R / 255,
                (float)waterShallowColor.G / 255,
                (float)waterShallowColor.B / 255,
                (float)waterShallowColor.A / 255);
            options.waterDeepColor = new Microsoft.Xna.Framework.Vector4(
                (float)waterDeepColor.R / 255,
                (float)waterDeepColor.G / 255,
                (float)waterDeepColor.B / 255,
                (float)waterDeepColor.A / 255);

            // Flora layer 1
            options.flora1 = flora1Checkbox.Checked;
            options.flora1Range.X = (float)flora1RangeX.Value;
            options.flora1Range.Y = (float)flora1RangeY.Value;
            options.flora1Frequency = (float)flora1Frequency.Value;
            options.flora1Scale = (float)flora1Scale.Value;
            options.flora1ShowGroundColor = flora1ShowGroundColor.Checked;
            options.flora1ShowPlantColor = flora1ShowPlantColor.Checked;
            options.flora1GroundColor = new Microsoft.Xna.Framework.Vector4(
                (float)flora1GroundColor.R / 255,
                (float)flora1GroundColor.G / 255,
                (float)flora1GroundColor.B / 255,
                (float)flora1GroundColor.A / 255);
            options.flora1PlantColor = new Microsoft.Xna.Framework.Vector4(
                (float)flora1PlantColor.R / 255,
                (float)flora1PlantColor.G / 255,
                (float)flora1PlantColor.B / 255,
                (float)flora1PlantColor.A / 255);

            // Flora layer 2
            options.flora2 = flora2Checkbox.Checked;
            options.flora2Range.X = (float)flora2RangeX.Value;
            options.flora2Range.Y = (float)flora2RangeY.Value;
            options.flora2Frequency = (float)flora2Frequency.Value;
            options.flora2Scale = (float)flora2Scale.Value;
            options.flora2ShowGroundColor = flora2ShowGroundColor.Checked;
            options.flora2ShowPlantColor = flora2ShowPlantColor.Checked;
            options.flora2GroundColor = new Microsoft.Xna.Framework.Vector4(
                (float)flora2GroundColor.R / 255,
                (float)flora2GroundColor.G / 255,
                (float)flora2GroundColor.B / 255,
                (float)flora2GroundColor.A / 255);
            options.flora2PlantColor = new Microsoft.Xna.Framework.Vector4(
                (float)flora2PlantColor.R / 255,
                (float)flora2PlantColor.G / 255,
                (float)flora2PlantColor.B / 255,
                (float)flora2PlantColor.A / 255);

            // Details
            options.detailsLayer1 = detailsLayer1Checkbox.Checked;
            options.detailsLayer1Range = new Microsoft.Xna.Framework.Vector2((float)detailsLayer1RangeMin.Value, (float)detailsLayer1RangeMax.Value);
            options.detailsLayer1Scale = (float)detailsLayer1Scale.Value;
            options.detailsLayer2 = detailsLayer2Checkbox.Checked;
            options.detailsLayer2Range = new Microsoft.Xna.Framework.Vector2((float)detailsLayer2RangeMin.Value, (float)detailsLayer2RangeMax.Value);
            options.detailsLayer2Scale = (float)detailsLayer2Scale.Value;
            options.detailsLayer3 = detailsLayer3Checkbox.Checked;
            options.detailsLayer3Range = new Microsoft.Xna.Framework.Vector2((float)detailsLayer3RangeMin.Value, (float)detailsLayer3RangeMax.Value);
            options.detailsLayer3Scale = (float)detailsLayer3Scale.Value;

            // Lighting
            options.normals = normalCheckbox.Checked;
            options.lightColor = new Microsoft.Xna.Framework.Vector3(
                (float)lightColor.R / 255,
                (float)lightColor.G / 255,
                (float)lightColor.B / 255);
            options.lightAmbientColor = new Microsoft.Xna.Framework.Vector3(
                (float)lightAmbientColor.R / 255,
                (float)lightAmbientColor.G / 255,
                (float)lightAmbientColor.B / 255);
            options.lightDirection = new Microsoft.Xna.Framework.Vector3(
                (float)lightPositionX.Value,
                (float)lightPositionY.Value,
                (float)lightPositionZ.Value);

            return options;
        }

        private void mapOptionsChanged(object sender, EventArgs e)
        {
            if (!blockGenerateMap)
                main.generateMap(getOptions());
        }

        private void flora1SelectTexture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select flora textures";
            fileDialog.Filter = "PNG|*.png";
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = string.Format("{0}textures\\flora\\", AppDomain.CurrentDomain.BaseDirectory);

            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.setFlora1Textures(fileDialog.FileNames);
                    main.generateMap(getOptions());
                }
            }));
        }

        private void flora2SelectTexture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select flora textures";
            fileDialog.Filter = "PNG|*.png";
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = string.Format("{0}textures\\flora\\", AppDomain.CurrentDomain.BaseDirectory);

            Invoke((Action)(() =>
                {
                    if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        main.setFlora2Textures(fileDialog.FileNames);
                        main.generateMap(getOptions());
                    }
                }));
        }

        private void saveLayersButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            string baseDirectory = string.Format("{0}output\\", AppDomain.CurrentDomain.BaseDirectory);
            // Create output directory if needed
            DirectoryInfo directory = new DirectoryInfo(baseDirectory);
            if (!directory.Exists)
                directory.Create();
            fileDialog.InitialDirectory = baseDirectory;
            fileDialog.Title = "Save Layers";

            Invoke((Action)(() =>
                {
                    if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        main.saveLayers(fileDialog.FileName);
                    }
                }));
        }

        private void saveComposite_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            string baseDirectory = string.Format("{0}output\\", AppDomain.CurrentDomain.BaseDirectory);
            // Create output directory if needed
            DirectoryInfo directory = new DirectoryInfo(baseDirectory);
            if (!directory.Exists)
                directory.Create();
            fileDialog.InitialDirectory = baseDirectory;
            fileDialog.Title = "Save Composite";
            fileDialog.Filter = "JPEG Files (*.jpeg;*.jpg)|*.jpeg;*.jpg";
            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.saveComposite(fileDialog.FileName);
                }
            }));
        }

        private void surface_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Steal focus
            surface.Focus();

            // Handle mouse input
            if (e.Button == MouseButtons.Left && !ctrl)
            {
                effectPosition += new Microsoft.Xna.Framework.Vector2(e.X - lastDragPosition.X, e.Y - lastDragPosition.Y);

                blockGenerateMap = true;
                noisePositionX.Value = (decimal)effectPosition.X;
                noisePositionY.Value = (decimal)effectPosition.Y;
                blockGenerateMap = false;

                MapGeneratorOptions options = getOptions();
                options.flora1 = false;
                options.flora2 = false;
                options.detailsLayer1 = false;
                options.detailsLayer2 = false;
                options.detailsLayer3 = false;
                options.normals = false;
                main.generateMap(options);
                redrawMap = true;
            }
            else if (e.Button == MouseButtons.Left && ctrl)
            {
                main.view.X += e.X - lastDragPosition.X;
                main.view.Y += e.Y - lastDragPosition.Y;
            }
            else if (redrawMap)
            {
                redrawMap = false;
                main.generateMap(getOptions());
            }

            lastDragPosition.X = e.X;
            lastDragPosition.Y = e.Y;
        }

        private void MapGeneratorForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.LControlKey)
                ctrl = false;
        }

        private void MapGeneratorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.LControlKey)
                ctrl = true;
        }

        private void MapGeneratorForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.X >= surface.Left && e.X <= surface.Left + surface.Width &&
                e.Y >= 0 && e.Y <= surface.Height)
            {
                if (ctrl)
                {
                    // Adjust scale of render target
                    main.scale += 0.0005f * e.Delta;
                }
                else
                {
                    // Adjust scale of effect
                    float scale = (float)noiseScale.Value;
                    scale += 0.005f * e.Delta;
                    noiseScale.Value = (decimal)scale;
                    main.generateMap(getOptions());
                }
            }
        }

        private void selectDetail1Textures_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select detail layer 2 textures";
            fileDialog.Filter = "PNG|*.png";
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = string.Format("{0}textures\\details\\", AppDomain.CurrentDomain.BaseDirectory);

            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.setDetailsLayer1Textures(fileDialog.FileNames);
                    main.generateMap(getOptions());
                }
            }));
        }

        private void selectDetail2Textures_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select detail layer 2 textures";
            fileDialog.Filter = "PNG|*.png";
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = string.Format("{0}textures\\details\\", AppDomain.CurrentDomain.BaseDirectory);

            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.setDetailsLayer2Textures(fileDialog.FileNames);
                    main.generateMap(getOptions());
                }
            }));
        }

        private void selectDetail3Textures_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select detail layer 3 textures";
            fileDialog.Filter = "PNG|*.png";
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = string.Format("{0}textures\\details\\", AppDomain.CurrentDomain.BaseDirectory);

            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.setDetailsLayer3Textures(fileDialog.FileNames);
                    main.generateMap(getOptions());
                }
            }));
        }

        private void waterShallowColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = waterShallowColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    waterShallowColor = colorDialog.Color;

                    // Draw color on UI
                    waterShallowColorPicture.BackColor = waterShallowColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void flora1GroundColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = flora1GroundColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    flora1GroundColor = colorDialog.Color;

                    // Draw color on UI
                    flora1GroundColorPicture.BackColor = flora1GroundColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void noiseLowColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = noiseLowColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    noiseLowColor = colorDialog.Color;

                    // Draw color on UI
                    noiseLowColorPicture.BackColor = noiseLowColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void noiseHighColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = noiseHighColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    noiseHighColor = colorDialog.Color;

                    // Draw color on UI
                    noiseHighColorPicture.BackColor = noiseHighColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void flora1PlantColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = flora1PlantColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    flora1PlantColor = colorDialog.Color;

                    // Draw color on UI
                    flora1PlantColorPicture.BackColor = flora1PlantColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void waterDeepColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = waterDeepColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    waterDeepColor = colorDialog.Color;

                    // Draw color on UI
                    waterDeepColorPicture.BackColor = waterDeepColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void flora2GroundColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = flora2GroundColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    flora2GroundColor = colorDialog.Color;

                    // Draw color on UI
                    flora2GroundColorPicture.BackColor = flora2GroundColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void flora2PlantColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = flora2PlantColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    flora2PlantColor = colorDialog.Color;

                    // Draw color on UI
                    flora2PlantColorPicture.BackColor = flora2PlantColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void lightColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = lightColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    lightColor = colorDialog.Color;

                    // Draw color on UI
                    lightColorPicture.BackColor = lightColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void lightAmbientColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = lightAmbientColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    lightAmbientColor = colorDialog.Color;

                    // Draw color on UI
                    lightAmbientColorPicture.BackColor = lightAmbientColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }
    }
}
