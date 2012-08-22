﻿using System;
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

        public float waterLevel;
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

        public MapGeneratorForm()
        {
            options = new MapGeneratorOptions();
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
            // General
            options.width = (int)renderWidth.Value;
            options.height = (int)renderHeight.Value;
            options.seed = (int)noiseSeed.Value;
            options.scale = (float)noiseScale.Value;
            options.position.X = (float)noisePositionX.Value;
            options.position.Y = (float)noisePositionY.Value;

            // Noise texture
            options.noiseTextureWidth = (int)noiseTextureWidth.Value;
            options.noiseTextureHeight = (int)noiseTextureHeight.Value;
            options.noiseFrequency = (float)noiseFrequency.Value;
            options.noiseGain = (float)noiseGain.Value;
            options.noiseLacunarity = (float)noiseLacunarity.Value;
            options.noiseBrightness = (float)noiseBrightness.Value;

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
            options.waterLevel = (float)waterLevel.Value;

            // Flora
            options.flora1 = flora1Checkbox.Checked;
            options.flora1Range.X = (float)flora1RangeX.Value;
            options.flora1Range.Y = (float)flora1RangeY.Value;
            options.flora1Frequency = (float)flora1Frequency.Value;
            options.flora1Scale = (float)flora1Scale.Value;

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
            fileDialog.Title = "Select a plant texture";
            fileDialog.Filter = "PNG|*.png";
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = string.Format("{0}textures\\", AppDomain.CurrentDomain.BaseDirectory);

            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.setFlora1Textures(fileDialog.FileNames);
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
    }
}
