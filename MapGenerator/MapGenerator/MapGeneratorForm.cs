using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public float waterLevel;
    };

    public partial class MapGeneratorForm : Form
    {
        public Main main;
        private Point lastDragPosition;
        private bool ctrl;
        private Microsoft.Xna.Framework.Vector2 effectPosition;

        public MapGeneratorForm()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(MapGeneratorForm_FormClosed);
            Resize += new EventHandler(MapGeneratorForm_Resize);
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
            MapGeneratorOptions options = new MapGeneratorOptions();

            options.width = int.Parse(widthBox.Text);
            options.height = int.Parse(heightBox.Text);
            options.seed = (int)noiseSeed.Value;
            options.scale = (float)noiseScale.Value;
            options.position.X = (float)noisePositionX.Value;
            options.position.Y = (float)noisePositionY.Value;

            options.noiseTextureWidth = (int)noiseTextureWidth.Value;
            options.noiseTextureHeight = (int)noiseTextureHeight.Value;

            options.noiseFrequency = (float)noiseFrequency.Value;
            options.noiseGain = (float)noiseGain.Value;
            options.noiseLacunarity = (float)noiseLacunarity.Value;
            options.noiseBrightness = (float)noiseBrightness.Value;

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

            options.waterLevel = float.Parse(waterLevelBox.Text);

            return options;
        }

        private void mapOptionsChanged(object sender, EventArgs e)
        {
            main.generateMap(getOptions());
        }
    }
}
