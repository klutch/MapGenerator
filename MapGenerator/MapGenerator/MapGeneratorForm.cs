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
            surface.Width = Width - surface.Location.X;
            surface.Height = Height;

            Main.graphics.PreferredBackBufferWidth = surface.Width;
            Main.graphics.PreferredBackBufferHeight = surface.Height;
            Main.graphics.ApplyChanges();
            if (main.renderTarget != null)
                main.generateMap(getOptions());
        }

        void MapGeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            main.generateMap(getOptions());
        }

        private MapGeneratorOptions getOptions()
        {
            MapGeneratorOptions options = new MapGeneratorOptions();
            options.width = int.Parse(widthBox.Text);
            options.height = int.Parse(heightBox.Text);
            options.seed = int.Parse(randomSeedBox.Text);
            options.randomTextureWidth = int.Parse(randomTextureWidthBox.Text);
            options.randomTextureHeight = int.Parse(randomTextureHeightBox.Text);

            return options;
        }
    }
}
