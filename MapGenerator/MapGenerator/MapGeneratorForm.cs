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

        public int randomTextureWidth;
        public int randomTextureHeight;
        public float randomTextureScale;

        public float noiseFrequency;
        public float noiseGain;
        public float noiseLacunarity;
        public float brightness;

        public bool fbm1;
        public bool fbm2;
        public bool fbm3;
        public float fbm1Divisor;
        public float fbm2Divisor;
        public float fbm3Divisor;

        public float waterLevel;
    };

    public partial class MapGeneratorForm : Form
    {
        public Main main;
        private Point lastDragPosition;

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
            options.seed = int.Parse(randomSeedBox.Text);
            
            options.randomTextureWidth = int.Parse(randomTextureWidthBox.Text);
            options.randomTextureHeight = int.Parse(randomTextureHeightBox.Text);
            options.randomTextureScale = float.Parse(randomTextureScaleBox.Text);
            
            options.noiseFrequency = float.Parse(noiseFrequencyBox.Text);
            options.noiseGain = float.Parse(noiseGainBox.Text);
            options.noiseLacunarity = float.Parse(noiseLacunarityBox.Text);
            options.brightness = float.Parse(brightnessMultiplierBox.Text);

            options.fbm1 = fbm1Checkbox.Checked;
            options.fbm2 = fbm2Checkbox.Checked;
            options.fbm3 = fbm3Checkbox.Checked;
            options.fbm1Divisor = float.Parse(fbm1DivisorBox.Text);
            options.fbm2Divisor = float.Parse(fbm2DivisorBox.Text);
            options.fbm3Divisor = float.Parse(fbm3DivisorBox.Text);

            options.waterLevel = float.Parse(waterLevelBox.Text);

            return options;
        }

        private void fbm3Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            main.generateMap(getOptions());
        }

        private void fbm2Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            main.generateMap(getOptions());
        }

        private void fbm1Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            main.generateMap(getOptions());
        }
    }
}
