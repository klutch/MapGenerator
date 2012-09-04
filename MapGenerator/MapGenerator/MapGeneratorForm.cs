using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Serialization;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MapGenerator
{
    [XmlRoot("MapGeneratorOptionsRoot")]
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

        public float normalStrength;
        public bool light1;
        public Microsoft.Xna.Framework.Vector3 light1Color;
        public Microsoft.Xna.Framework.Vector3 light1Direction;
        public Microsoft.Xna.Framework.Vector3 light1AmbientColor;
        public float light1Intensity;
        public bool light2;
        public Microsoft.Xna.Framework.Vector3 light2Color;
        public Microsoft.Xna.Framework.Vector3 light2Direction;
        public Microsoft.Xna.Framework.Vector3 light2AmbientColor;
        public float light2Intensity;

        [XmlArray("flora1TextureFilePaths")]
        [XmlArrayItem("filePath", typeof(string))]
        public List<string> flora1TexturePaths;

        [XmlArray("flora2TextureFilePaths")]
        [XmlArrayItem("filePath", typeof(string))]
        public List<string> flora2TexturePaths;

        [XmlArray("detailsLayer1TexturePaths")]
        [XmlArrayItem("filePath", typeof(string))]
        public List<string> detailsLayer1TexturePaths;

        [XmlArray("detailsLayer2TexturePaths")]
        [XmlArrayItem("filePath", typeof(string))]
        public List<string> detailsLayer2TexturePaths;

        [XmlArray("detailsLayer3TexturePaths")]
        [XmlArrayItem("filePath", typeof(string))]
        public List<string> detailsLayer3TexturePaths;
    };

    public partial class MapGeneratorForm : Form
    {
        public Main main;
        private Point lastDragPosition;
        private bool ctrl;
        private MapGeneratorOptions options;
        private bool blockGenerateMap;
        public bool ignoreSurfaceClick;
        private bool redrawMap;
        private Color flora1GroundColor = Color.LimeGreen;
        private Color flora1PlantColor = Color.White;
        private Color flora2GroundColor = Color.Blue;
        private Color flora2PlantColor = Color.LightBlue;
        private Color waterShallowColor = Color.Blue;
        private Color waterDeepColor = Color.DarkBlue;
        private Color noiseLowColor = Color.Black;
        private Color noiseHighColor = Color.White;
        private Color light1Color = Color.White;
        private Color light1AmbientColor = Color.Black;
        private Color light2Color = Color.DarkOrange;
        private Color light2AmbientColor = Color.Black;
        public static string outputDirectory = string.Format("{0}output\\", AppDomain.CurrentDomain.BaseDirectory);
        public static string mapDirectory = string.Format("{0}maps\\", AppDomain.CurrentDomain.BaseDirectory);

        public MapGeneratorForm()
        {
            options = new MapGeneratorOptions();
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(MapGeneratorForm_FormClosed);
            Resize += new EventHandler(MapGeneratorForm_Resize);

            setColorBoxes();

            options.flora1TexturePaths = new List<string>();
            options.flora1TexturePaths.Add("textures\\flora\\tree_1.png");
            options.flora2TexturePaths = new List<string>();
            options.flora2TexturePaths.Add("textures\\flora\\brush_1.png");
            options.detailsLayer1TexturePaths = new List<string>();
            options.detailsLayer1TexturePaths.Add("textures\\details\\cracks.png");
            options.detailsLayer2TexturePaths = new List<string>();
            options.detailsLayer2TexturePaths.Add("textures\\details\\jagged.png");
            options.detailsLayer2TexturePaths.Add("textures\\details\\jagged_dark.png");
            options.detailsLayer3TexturePaths = new List<string>();
            options.detailsLayer3TexturePaths.Add("textures\\details\\sand_holes.png");
        }

        private void setColorBoxes()
        {
            flora1GroundColorPicture.BackColor = flora1GroundColor;
            flora1PlantColorPicture.BackColor = flora1PlantColor;
            flora2GroundColorPicture.BackColor = flora2GroundColor;
            flora2PlantColorPicture.BackColor = flora2PlantColor;
            waterShallowColorPicture.BackColor = waterShallowColor;
            waterDeepColorPicture.BackColor = waterDeepColor;
            noiseLowColorPicture.BackColor = noiseLowColor;
            noiseHighColorPicture.BackColor = noiseHighColor;
            light1ColorPicture.BackColor = light1Color;
            light1AmbientColorPicture.BackColor = light1AmbientColor;
            light2ColorPicture.BackColor = light2Color;
            light2AmbientColorPicture.BackColor = light2AmbientColor;
        }

        private List<string> convertFileNamesToRelative(string[] filePaths)
        {
            List<string> relativePaths = new List<string>();
            foreach (string filePath in filePaths)
                relativePaths.Add(filePath.Replace(AppDomain.CurrentDomain.BaseDirectory, ""));
            return relativePaths;
        }

        void MapGeneratorForm_Resize(object sender, EventArgs e)
        {
            // Resize surface
            surface.Width = Width - surface.Location.X;
            surface.Height = Height;

            // Resize main options control
            mainOptionsControl.Height = Height - 103;

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

        // getOptions
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
            options.normalStrength = (float)normalStrength.Value;
            options.light1 = light1Checkbox.Checked;
            options.light1Color = new Microsoft.Xna.Framework.Vector3(
                (float)light1Color.R / 255,
                (float)light1Color.G / 255,
                (float)light1Color.B / 255);
            options.light1AmbientColor = new Microsoft.Xna.Framework.Vector3(
                (float)light1AmbientColor.R / 255,
                (float)light1AmbientColor.G / 255,
                (float)light1AmbientColor.B / 255);
            options.light1Direction = new Microsoft.Xna.Framework.Vector3(
                (float)light1PositionX.Value,
                (float)light1PositionY.Value,
                (float)light1PositionZ.Value);
            options.light1Intensity = (float)light1Intensity.Value;

            options.light2 = light2Checkbox.Checked;
            options.light2Color = new Microsoft.Xna.Framework.Vector3(
                (float)light2Color.R / 255,
                (float)light2Color.G / 255,
                (float)light2Color.B / 255);
            options.light2AmbientColor = new Microsoft.Xna.Framework.Vector3(
                (float)light2AmbientColor.R / 255,
                (float)light2AmbientColor.G / 255,
                (float)light2AmbientColor.B / 255);
            options.light2Direction = new Microsoft.Xna.Framework.Vector3(
                (float)light2PositionX.Value,
                (float)light2PositionY.Value,
                (float)light2PositionZ.Value);
            options.light2Intensity = (float)light2Intensity.Value;
            /*
            Console.WriteLine("flora1TextureFilePaths: {0}", options.flora1TexturePaths);
            Console.WriteLine("flora2TextureFilePaths: {0}", options.flora2TexturePaths);
            Console.WriteLine("detailsLayer1TextureFilePaths: {0}", options.detailsLayer1TexturePaths);
            Console.WriteLine("detailsLayer2TextureFilePaths: {0}", options.detailsLayer2TexturePaths);
            Console.WriteLine("detailsLayer3TextureFilePaths: {0}", options.detailsLayer3TexturePaths);
            */

            return options;
        }

        // setOptions
        private void setOptions(MapGeneratorOptions options)
        {
            // Block map generation on value changes
            blockGenerateMap = true;

            this.options = options;

            // General
            renderWidth.Value = options.width;
            renderHeight.Value = options.height;
            noiseSeed.Value = options.seed;
            noiseScale.Value = (decimal)options.scale;
            noisePositionX.Value = (decimal)options.position.X;
            noisePositionY.Value = (decimal)options.position.Y;

            // Noise texture
            worleyCheckbox.Checked = options.worley;
            noiseTextureWidth.Value = options.noiseTextureWidth;
            noiseTextureHeight.Value = options.noiseTextureHeight;
            noiseFrequency.Value = (decimal)options.noiseFrequency;
            noiseGain.Value = (decimal)options.noiseGain;
            noiseLacunarity.Value = (decimal)options.noiseLacunarity;
            noiseBrightness.Value = (decimal)options.noiseBrightness;
            noiseLowColor = Color.FromArgb(
                (int)(options.noiseLowColor.W * 255),
                (int)(options.noiseLowColor.X * 255),
                (int)(options.noiseLowColor.Y * 255),
                (int)(options.noiseLowColor.Z * 255));
            noiseHighColor = Color.FromArgb(
                (int)(options.noiseHighColor.W * 255),
                (int)(options.noiseHighColor.X * 255),
                (int)(options.noiseHighColor.Y * 255),
                (int)(options.noiseHighColor.Z * 255));

            // Fractional brownian motion
            fbm1Checkbox.Checked = options.fbm1;
            fbm2Checkbox.Checked = options.fbm2;
            fbm3Checkbox.Checked = options.fbm3;
            fbm1NoiseOnly.Checked = options.fbm1NoiseOnly;
            fbm2NoiseOnly.Checked = options.fbm2NoiseOnly;
            fbm3NoiseOnly.Checked = options.fbm3NoiseOnly;
            fbm1OffsetX.Value = (decimal)options.fbm1Offset.X;
            fbm1OffsetY.Value = (decimal)options.fbm1Offset.Y;
            fbm2OffsetX.Value = (decimal)options.fbm2Offset.X;
            fbm2OffsetY.Value = (decimal)options.fbm2Offset.Y;
            fbm3OffsetX.Value = (decimal)options.fbm3Offset.X;
            fbm3OffsetY.Value = (decimal)options.fbm3Offset.Y;
            fbm1Opacity.Value = (decimal)options.fbm1Opacity;
            fbm2Opacity.Value = (decimal)options.fbm2Opacity;
            fbm3Opacity.Value = (decimal)options.fbm3Opacity;

            // Water
            waterCheckbox.Checked = options.water;
            waterLevel.Value = (decimal)options.waterLevel;
            waterShallowColor = Color.FromArgb(
                (int)(options.waterShallowColor.W * 255),
                (int)(options.waterShallowColor.X * 255),
                (int)(options.waterShallowColor.Y * 255),
                (int)(options.waterShallowColor.Z * 255));
            waterDeepColor = Color.FromArgb(
                (int)(options.waterDeepColor.W * 255),
                (int)(options.waterDeepColor.X * 255),
                (int)(options.waterDeepColor.Y * 255),
                (int)(options.waterDeepColor.Z * 255));

            // Flora layer 1
            flora1Checkbox.Checked = options.flora1;
            flora1RangeX.Value = (decimal)options.flora1Range.X;
            flora1RangeY.Value = (decimal)options.flora1Range.Y;
            flora1Frequency.Value = (decimal)options.flora1Frequency;
            flora1Scale.Value = (decimal)options.flora1Scale;
            flora1ShowGroundColor.Checked = options.flora1ShowGroundColor;
            flora1ShowPlantColor.Checked = options.flora1ShowPlantColor;
            flora1GroundColor = Color.FromArgb(
                (int)(options.flora1GroundColor.W * 255),
                (int)(options.flora1GroundColor.X * 255),
                (int)(options.flora1GroundColor.Y * 255),
                (int)(options.flora1GroundColor.Z * 255));
            flora1PlantColor = Color.FromArgb(
                (int)(options.flora1PlantColor.W * 255),
                (int)(options.flora1PlantColor.X * 255),
                (int)(options.flora1PlantColor.Y * 255),
                (int)(options.flora1PlantColor.Z * 255));

            // Flora layer 2
            flora2Checkbox.Checked = options.flora2;
            flora2RangeX.Value = (decimal)options.flora2Range.X;
            flora2RangeY.Value = (decimal)options.flora2Range.Y;
            flora2Frequency.Value = (decimal)options.flora2Frequency;
            flora2Scale.Value = (decimal)options.flora2Scale;
            flora2ShowGroundColor.Checked = options.flora2ShowGroundColor;
            flora2ShowPlantColor.Checked = options.flora2ShowPlantColor;
            flora2GroundColor = Color.FromArgb(
                (int)(options.flora2GroundColor.W * 255),
                (int)(options.flora2GroundColor.X * 255),
                (int)(options.flora2GroundColor.Y * 255),
                (int)(options.flora2GroundColor.Z * 255));
            flora2PlantColor = Color.FromArgb(
                (int)(options.flora2PlantColor.W * 255),
                (int)(options.flora2PlantColor.X * 255),
                (int)(options.flora2PlantColor.Y * 255),
                (int)(options.flora2PlantColor.Z * 255));

            // Details
            detailsLayer1Checkbox.Checked = options.detailsLayer1;
            detailsLayer1RangeMin.Value = (decimal)options.detailsLayer1Range.X;
            detailsLayer1RangeMax.Value = (decimal)options.detailsLayer1Range.Y;
            detailsLayer1Scale.Value = (decimal)options.detailsLayer1Scale;

            detailsLayer2Checkbox.Checked = options.detailsLayer2;
            detailsLayer2RangeMin.Value = (decimal)options.detailsLayer2Range.X;
            detailsLayer2RangeMax.Value = (decimal)options.detailsLayer2Range.Y;
            detailsLayer2Scale.Value = (decimal)options.detailsLayer2Scale;

            detailsLayer3Checkbox.Checked = options.detailsLayer3;
            detailsLayer3RangeMin.Value = (decimal)options.detailsLayer3Range.X;
            detailsLayer3RangeMax.Value = (decimal)options.detailsLayer3Range.Y;
            detailsLayer3Scale.Value = (decimal)options.detailsLayer3Scale;

            // Lighting
            normalStrength.Value = (decimal)options.normalStrength;
            light1Checkbox.Checked = options.light1;
            light1Color = Color.FromArgb(
                255,
                (int)(options.light1Color.X * 255),
                (int)(options.light1Color.Y * 255),
                (int)(options.light1Color.Z * 255));
            light1AmbientColor = Color.FromArgb(
                255,
                (int)(options.light1AmbientColor.X * 255),
                (int)(options.light1AmbientColor.Y * 255),
                (int)(options.light1AmbientColor.Z * 255));
            light1PositionX.Value = (decimal)options.light1Direction.X;
            light1PositionY.Value = (decimal)options.light1Direction.Y;
            light1PositionZ.Value = (decimal)options.light1Direction.Z;
            light1Intensity.Value = (decimal)options.light1Intensity;

            light2Checkbox.Checked = options.light2;
            light2Color = Color.FromArgb(
                255,
                (int)(options.light2Color.X * 255),
                (int)(options.light2Color.Y * 255),
                (int)(options.light2Color.Z * 255));
            light2AmbientColor = Color.FromArgb(
                255,
                (int)(options.light2AmbientColor.X * 255),
                (int)(options.light2AmbientColor.Y * 255),
                (int)(options.light2AmbientColor.Z * 255));
            light2PositionX.Value = (decimal)options.light2Direction.X;
            light2PositionY.Value = (decimal)options.light2Direction.Y;
            light2PositionZ.Value = (decimal)options.light2Direction.Z;
            light2Intensity.Value = (decimal)options.light2Intensity;

            // Load texture files
            main.setFlora1Textures(options.flora1TexturePaths);
            main.setFlora2Textures(options.flora2TexturePaths);
            main.setDetailsLayer1Textures(options.detailsLayer1TexturePaths);
            main.setDetailsLayer2Textures(options.detailsLayer2TexturePaths);
            main.setDetailsLayer3Textures(options.detailsLayer3TexturePaths);

            // Update color boxes
            setColorBoxes();

            // Unblock map generation
            blockGenerateMap = false;

            // Generate map
            main.generateMap(getOptions());
        }

        // saveMapFile
        private void saveMapFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MapGeneratorOptions));
            if (File.Exists(filePath))
                File.Delete(filePath);
            FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);
            serializer.Serialize(fileStream, getOptions());
            fileStream.Close();
            fileStream.Dispose();
        }

        // loadMapFile
        private void loadMapFile(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MapGeneratorOptions));
            FileStream fileStream = new FileStream(filePath, FileMode.Open);
            MapGeneratorOptions loadedOptions = (MapGeneratorOptions)serializer.Deserialize(fileStream);
            fileStream.Close();
            fileStream.Dispose();
            setOptions(loadedOptions);
        }

        // mapOptionsChanged
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
                    List<string> relativePaths = convertFileNamesToRelative(fileDialog.FileNames);
                    options.flora1TexturePaths = relativePaths;
                    main.setFlora1Textures(relativePaths);
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
                        List<string> relativePaths = convertFileNamesToRelative(fileDialog.FileNames);
                        options.flora2TexturePaths = relativePaths;
                        main.setFlora2Textures(relativePaths);
                        main.generateMap(getOptions());
                    }
                }));
        }

        private void surface_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Steal focus
            surface.Focus();

            // Handle mouse input
            if (ignoreSurfaceClick)
                ignoreSurfaceClick = false;
            else
            {
                if (e.Button == MouseButtons.Left && !ctrl)
                {
                    this.options.position.X += e.X - lastDragPosition.X;
                    this.options.position.Y += e.Y - lastDragPosition.Y;

                    blockGenerateMap = true;
                    noisePositionX.Value = (decimal)this.options.position.X;
                    noisePositionY.Value = (decimal)this.options.position.Y;
                    blockGenerateMap = false;

                    MapGeneratorOptions options = getOptions();
                    options.flora1 = false;
                    options.flora2 = false;
                    options.detailsLayer1 = false;
                    options.detailsLayer2 = false;
                    options.detailsLayer3 = false;
                    options.light1 = false;
                    options.light2 = false;
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
                    scale += e.Delta > 0 ? 0.1f : -0.1f;
                    noiseScale.Value = (decimal)scale;
                }
            }
        }

        private void selectDetail1Textures_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select detail layer 1 textures";
            fileDialog.Filter = "PNG|*.png";
            fileDialog.Multiselect = true;
            fileDialog.InitialDirectory = string.Format("{0}textures\\details\\", AppDomain.CurrentDomain.BaseDirectory);

            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    List<string> relativePaths = convertFileNamesToRelative(fileDialog.FileNames);
                    options.detailsLayer1TexturePaths = relativePaths;
                    main.setDetailsLayer1Textures(relativePaths);
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
                    List<string> relativePaths = convertFileNamesToRelative(fileDialog.FileNames);
                    options.detailsLayer2TexturePaths = relativePaths;
                    main.setDetailsLayer2Textures(relativePaths);
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
                    List<string> relativePaths = convertFileNamesToRelative(fileDialog.FileNames);
                    options.detailsLayer3TexturePaths = relativePaths;
                    main.setDetailsLayer3Textures(relativePaths);
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
            colorDialog.Color = light1Color;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    light1Color = colorDialog.Color;

                    // Draw color on UI
                    light1ColorPicture.BackColor = light1Color;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void lightAmbientColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = light1AmbientColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    light1AmbientColor = colorDialog.Color;

                    // Draw color on UI
                    light1AmbientColorPicture.BackColor = light1AmbientColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void light2ColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = light2Color;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    light2Color = colorDialog.Color;

                    // Draw color on UI
                    light2ColorPicture.BackColor = light2Color;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void light2AmbientColorPicture_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = light2AmbientColor;
            Invoke((Action)(() =>
            {
                if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Set color
                    light2AmbientColor = colorDialog.Color;

                    // Draw color on UI
                    light2AmbientColorPicture.BackColor = light2AmbientColor;

                    // Draw map
                    main.generateMap(getOptions());
                }
            }));
        }

        private void fileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void renderGenerateMap_Click(object sender, EventArgs e)
        {
            main.generateMap(getOptions());
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
            // Save map
            ////////////////////////////////////////////////
            SaveFileDialog fileDialog = new SaveFileDialog();
            // Create output directory if needed
            DirectoryInfo directory = new DirectoryInfo(mapDirectory);
            if (!directory.Exists)
                directory.Create();
            fileDialog.InitialDirectory = mapDirectory;
            fileDialog.Title = "Save Map";
            fileDialog.Filter = "MapGeneratorFile (*.mgf)|*.mgf";
            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    saveMapFile(fileDialog.FileName);
                    ignoreSurfaceClick = true;
                }
            }));
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
            // Save layers
            ////////////////////////////////////////////////
            SaveFileDialog fileDialog = new SaveFileDialog();
            // Create output directory if needed
            DirectoryInfo directory = new DirectoryInfo(outputDirectory);
            if (!directory.Exists)
                directory.Create();
            fileDialog.InitialDirectory = outputDirectory;
            fileDialog.Title = "Save Layers";

            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.saveLayers(fileDialog.FileName);
                    ignoreSurfaceClick = true;
                }
            }));
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
            // Save composite
            ////////////////////////////////////////////////
            SaveFileDialog fileDialog = new SaveFileDialog();
            // Create output directory if needed
            DirectoryInfo directory = new DirectoryInfo(outputDirectory);
            if (!directory.Exists)
                directory.Create();
            fileDialog.InitialDirectory = outputDirectory;
            fileDialog.Title = "Save Composite";
            fileDialog.Filter = "PNG Files (*.png)|*.png";
            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    main.saveComposite(fileDialog.FileName);
                    ignoreSurfaceClick = true;
                }
            }));
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
            // Load map
            ////////////////////////////////////////////////
            OpenFileDialog fileDialog = new OpenFileDialog();
            DirectoryInfo directory = new DirectoryInfo(mapDirectory);
            if (!directory.Exists)
                directory.Create();
            fileDialog.InitialDirectory = mapDirectory;
            fileDialog.Title = "Load Map";
            fileDialog.Filter = "MapGeneratorFile (*.mgf)|*.mgf";
            Invoke((Action)(() =>
            {
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    loadMapFile(fileDialog.FileName);
                    ignoreSurfaceClick = true;
                }
            }));
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////////////////
            // Batch save
            ////////////////////////////////////////////////
            BatchSaveForm batchSaveForm = new BatchSaveForm(this);
            batchSaveForm.ShowDialog();
        }
    }
}
