using System.Windows.Forms;

namespace MapGenerator
{
    partial class MapGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public System.Windows.Forms.PictureBox getSurface()
        {
            return surface;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.surface = new System.Windows.Forms.PictureBox();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.randomTextureDimensionsLabel = new System.Windows.Forms.Label();
            this.mainOptionsControl = new System.Windows.Forms.TabControl();
            this.noiseTab = new System.Windows.Forms.TabPage();
            this.worleyCheckbox = new System.Windows.Forms.CheckBox();
            this.noiseHighColorLabel = new System.Windows.Forms.Label();
            this.noiseHighColorPicture = new System.Windows.Forms.PictureBox();
            this.noiseLowColorLabel = new System.Windows.Forms.Label();
            this.noiseLowColorPicture = new System.Windows.Forms.PictureBox();
            this.noiseBrightness = new System.Windows.Forms.NumericUpDown();
            this.noiseLacunarity = new System.Windows.Forms.NumericUpDown();
            this.noiseGain = new System.Windows.Forms.NumericUpDown();
            this.noiseFrequency = new System.Windows.Forms.NumericUpDown();
            this.noiseTextureHeight = new System.Windows.Forms.NumericUpDown();
            this.noiseTextureWidth = new System.Windows.Forms.NumericUpDown();
            this.noisePositionY = new System.Windows.Forms.NumericUpDown();
            this.noisePositionX = new System.Windows.Forms.NumericUpDown();
            this.noiseSeed = new System.Windows.Forms.NumericUpDown();
            this.noiseScale = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fbm3PositionAndNoise = new System.Windows.Forms.RadioButton();
            this.fbm3NoiseOnly = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fbm2PositionAndNoise = new System.Windows.Forms.RadioButton();
            this.fbm2NoiseOnly = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fbm1PositionAndNoise = new System.Windows.Forms.RadioButton();
            this.fbm1NoiseOnly = new System.Windows.Forms.RadioButton();
            this.fbm3OffsetLabel = new System.Windows.Forms.Label();
            this.fbm3OffsetY = new System.Windows.Forms.NumericUpDown();
            this.fbm3OffsetX = new System.Windows.Forms.NumericUpDown();
            this.fbm3Opacity = new System.Windows.Forms.NumericUpDown();
            this.fbm3Checkbox = new System.Windows.Forms.CheckBox();
            this.fbm2OffsetLabel = new System.Windows.Forms.Label();
            this.fbm2OffsetY = new System.Windows.Forms.NumericUpDown();
            this.fbm2OffsetX = new System.Windows.Forms.NumericUpDown();
            this.fbm2Opacity = new System.Windows.Forms.NumericUpDown();
            this.fbm2Checkbox = new System.Windows.Forms.CheckBox();
            this.fbm1OffsetLabel = new System.Windows.Forms.Label();
            this.fbm1OffsetY = new System.Windows.Forms.NumericUpDown();
            this.fbm1OffsetX = new System.Windows.Forms.NumericUpDown();
            this.fbm1Opacity = new System.Windows.Forms.NumericUpDown();
            this.positionLabel = new System.Windows.Forms.Label();
            this.fbm1Checkbox = new System.Windows.Forms.CheckBox();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.lacunarityLabel = new System.Windows.Forms.Label();
            this.gainLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.waterTab = new System.Windows.Forms.TabPage();
            this.waterDeepColorLabel = new System.Windows.Forms.Label();
            this.waterDeepColorPicture = new System.Windows.Forms.PictureBox();
            this.waterShallowColorLabel = new System.Windows.Forms.Label();
            this.waterShallowColorPicture = new System.Windows.Forms.PictureBox();
            this.waterCheckbox = new System.Windows.Forms.CheckBox();
            this.waterLevel = new System.Windows.Forms.NumericUpDown();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.floraTab = new System.Windows.Forms.TabPage();
            this.flora2ShowPlantColor = new System.Windows.Forms.CheckBox();
            this.flora2PlantColorLabel = new System.Windows.Forms.Label();
            this.flora2PlantColorPicture = new System.Windows.Forms.PictureBox();
            this.flora2ShowGroundColor = new System.Windows.Forms.CheckBox();
            this.flora2GroundColorLabel = new System.Windows.Forms.Label();
            this.flora2GroundColorPicture = new System.Windows.Forms.PictureBox();
            this.flora2Scale = new System.Windows.Forms.NumericUpDown();
            this.flora2ScaleLabel = new System.Windows.Forms.Label();
            this.flora2SelectTexture = new System.Windows.Forms.Button();
            this.flora2Frequency = new System.Windows.Forms.NumericUpDown();
            this.flora2RangeX = new System.Windows.Forms.NumericUpDown();
            this.flora2RangeY = new System.Windows.Forms.NumericUpDown();
            this.flora2FrequencyLabel = new System.Windows.Forms.Label();
            this.flora2RangeLabel = new System.Windows.Forms.Label();
            this.flora2Checkbox = new System.Windows.Forms.CheckBox();
            this.flora1ShowPlantColor = new System.Windows.Forms.CheckBox();
            this.flora1PlantColorLabel = new System.Windows.Forms.Label();
            this.flora1PlantColorPicture = new System.Windows.Forms.PictureBox();
            this.flora1ShowGroundColor = new System.Windows.Forms.CheckBox();
            this.flora1GroundColorLabel = new System.Windows.Forms.Label();
            this.flora1GroundColorPicture = new System.Windows.Forms.PictureBox();
            this.flora1Scale = new System.Windows.Forms.NumericUpDown();
            this.flora1ScaleLabel = new System.Windows.Forms.Label();
            this.flora1SelectTexture = new System.Windows.Forms.Button();
            this.flora1Frequency = new System.Windows.Forms.NumericUpDown();
            this.flora1RangeX = new System.Windows.Forms.NumericUpDown();
            this.flora1RangeY = new System.Windows.Forms.NumericUpDown();
            this.flora1FrequencyLabel = new System.Windows.Forms.Label();
            this.flora1RangeLabel = new System.Windows.Forms.Label();
            this.flora1Checkbox = new System.Windows.Forms.CheckBox();
            this.detailsTab = new System.Windows.Forms.TabPage();
            this.detailsLayer3Scale = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer3ScaleLabel = new System.Windows.Forms.Label();
            this.selectDetail3Textures = new System.Windows.Forms.Button();
            this.detailsLayer3RangeMin = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer3RangeMax = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer3RangeLabel = new System.Windows.Forms.Label();
            this.detailsLayer3Checkbox = new System.Windows.Forms.CheckBox();
            this.detailsLayer2Scale = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer2ScaleLabel = new System.Windows.Forms.Label();
            this.selectDetail2Textures = new System.Windows.Forms.Button();
            this.detailsLayer2RangeMin = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer2RangeMax = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer2RangeLabel = new System.Windows.Forms.Label();
            this.detailsLayer2Checkbox = new System.Windows.Forms.CheckBox();
            this.detailsLayer1Scale = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer1ScaleLabel = new System.Windows.Forms.Label();
            this.selectDetail1Textures = new System.Windows.Forms.Button();
            this.detailsLayer1RangeMin = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer1RangeMax = new System.Windows.Forms.NumericUpDown();
            this.detailsLayer1RangeLabel = new System.Windows.Forms.Label();
            this.detailsLayer1Checkbox = new System.Windows.Forms.CheckBox();
            this.lightingTab = new System.Windows.Forms.TabPage();
            this.normalStrength = new System.Windows.Forms.NumericUpDown();
            this.normalStrengthLabel = new System.Windows.Forms.Label();
            this.light2Intensity = new System.Windows.Forms.NumericUpDown();
            this.light2IntensityLabel = new System.Windows.Forms.Label();
            this.light1Intensity = new System.Windows.Forms.NumericUpDown();
            this.light1IntensityLabel = new System.Windows.Forms.Label();
            this.light2Checkbox = new System.Windows.Forms.CheckBox();
            this.light2AmbientColorLabel = new System.Windows.Forms.Label();
            this.light2AmbientColorPicture = new System.Windows.Forms.PictureBox();
            this.light2PositionZ = new System.Windows.Forms.NumericUpDown();
            this.light2PositionZLabel = new System.Windows.Forms.Label();
            this.light2PositionY = new System.Windows.Forms.NumericUpDown();
            this.light2PositionYLabel = new System.Windows.Forms.Label();
            this.light2PositionX = new System.Windows.Forms.NumericUpDown();
            this.light2PositionXLabel = new System.Windows.Forms.Label();
            this.light2PositionLabel = new System.Windows.Forms.Label();
            this.light2ColorLabel = new System.Windows.Forms.Label();
            this.light2ColorPicture = new System.Windows.Forms.PictureBox();
            this.light1AmbientColorLabel = new System.Windows.Forms.Label();
            this.light1AmbientColorPicture = new System.Windows.Forms.PictureBox();
            this.light1PositionZ = new System.Windows.Forms.NumericUpDown();
            this.light1PositionZLabel = new System.Windows.Forms.Label();
            this.light1PositionY = new System.Windows.Forms.NumericUpDown();
            this.light1PositionYLabel = new System.Windows.Forms.Label();
            this.light1PositionX = new System.Windows.Forms.NumericUpDown();
            this.light1PositionXLabel = new System.Windows.Forms.Label();
            this.light1Position = new System.Windows.Forms.Label();
            this.light1ColorLabel = new System.Windows.Forms.Label();
            this.light1ColorPicture = new System.Windows.Forms.PictureBox();
            this.light1Checkbox = new System.Windows.Forms.CheckBox();
            this.renderTab = new System.Windows.Forms.TabPage();
            this.renderHeight = new System.Windows.Forms.NumericUpDown();
            this.renderWidth = new System.Windows.Forms.NumericUpDown();
            this.fileExit = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.renderGenerateMap = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.surface)).BeginInit();
            this.mainOptionsControl.SuspendLayout();
            this.noiseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseHighColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLowColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLacunarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTextureHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTextureWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisePositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisePositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseScale)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbm3OffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm3OffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm3Opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm2OffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm2OffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm2Opacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm1OffsetY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm1OffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm1Opacity)).BeginInit();
            this.waterTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterDeepColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterShallowColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterLevel)).BeginInit();
            this.floraTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flora2PlantColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2GroundColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2RangeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2RangeY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1PlantColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1GroundColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1Frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1RangeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1RangeY)).BeginInit();
            this.detailsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer3Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer3RangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer3RangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer2Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer2RangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer2RangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer1Scale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer1RangeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer1RangeMax)).BeginInit();
            this.lightingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normalStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2Intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1Intensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2AmbientColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2PositionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2PositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2PositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2ColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1AmbientColorPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1PositionZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1PositionY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1PositionX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1ColorPicture)).BeginInit();
            this.renderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(258, 0);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(667, 561);
            this.surface.TabIndex = 0;
            this.surface.TabStop = false;
            this.surface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.surface_MouseMove);
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(6, 12);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Size = new System.Drawing.Size(32, 13);
            this.randomSeedLabel.TabIndex = 0;
            this.randomSeedLabel.Text = "Seed";
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateButton.Location = new System.Drawing.Point(13, 526);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(63, 23);
            this.generateButton.TabIndex = 10;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(8, 12);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 0;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(117, 12);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "Height";
            // 
            // randomTextureDimensionsLabel
            // 
            this.randomTextureDimensionsLabel.AutoSize = true;
            this.randomTextureDimensionsLabel.Location = new System.Drawing.Point(6, 110);
            this.randomTextureDimensionsLabel.Name = "randomTextureDimensionsLabel";
            this.randomTextureDimensionsLabel.Size = new System.Drawing.Size(137, 13);
            this.randomTextureDimensionsLabel.TabIndex = 0;
            this.randomTextureDimensionsLabel.Text = "Source Texture Dimensions";
            // 
            // mainOptionsControl
            // 
            this.mainOptionsControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainOptionsControl.Controls.Add(this.noiseTab);
            this.mainOptionsControl.Controls.Add(this.waterTab);
            this.mainOptionsControl.Controls.Add(this.floraTab);
            this.mainOptionsControl.Controls.Add(this.detailsTab);
            this.mainOptionsControl.Controls.Add(this.lightingTab);
            this.mainOptionsControl.Controls.Add(this.renderTab);
            this.mainOptionsControl.Location = new System.Drawing.Point(0, 0);
            this.mainOptionsControl.Multiline = true;
            this.mainOptionsControl.Name = "mainOptionsControl";
            this.mainOptionsControl.SelectedIndex = 0;
            this.mainOptionsControl.Size = new System.Drawing.Size(258, 517);
            this.mainOptionsControl.TabIndex = 11;
            // 
            // noiseTab
            // 
            this.noiseTab.AutoScroll = true;
            this.noiseTab.Controls.Add(this.worleyCheckbox);
            this.noiseTab.Controls.Add(this.noiseHighColorLabel);
            this.noiseTab.Controls.Add(this.noiseHighColorPicture);
            this.noiseTab.Controls.Add(this.noiseLowColorLabel);
            this.noiseTab.Controls.Add(this.noiseLowColorPicture);
            this.noiseTab.Controls.Add(this.noiseBrightness);
            this.noiseTab.Controls.Add(this.noiseLacunarity);
            this.noiseTab.Controls.Add(this.noiseGain);
            this.noiseTab.Controls.Add(this.noiseFrequency);
            this.noiseTab.Controls.Add(this.noiseTextureHeight);
            this.noiseTab.Controls.Add(this.noiseTextureWidth);
            this.noiseTab.Controls.Add(this.noisePositionY);
            this.noiseTab.Controls.Add(this.noisePositionX);
            this.noiseTab.Controls.Add(this.noiseSeed);
            this.noiseTab.Controls.Add(this.noiseScale);
            this.noiseTab.Controls.Add(this.panel3);
            this.noiseTab.Controls.Add(this.panel2);
            this.noiseTab.Controls.Add(this.panel1);
            this.noiseTab.Controls.Add(this.fbm3OffsetLabel);
            this.noiseTab.Controls.Add(this.fbm3OffsetY);
            this.noiseTab.Controls.Add(this.fbm3OffsetX);
            this.noiseTab.Controls.Add(this.fbm3Opacity);
            this.noiseTab.Controls.Add(this.fbm3Checkbox);
            this.noiseTab.Controls.Add(this.fbm2OffsetLabel);
            this.noiseTab.Controls.Add(this.fbm2OffsetY);
            this.noiseTab.Controls.Add(this.fbm2OffsetX);
            this.noiseTab.Controls.Add(this.fbm2Opacity);
            this.noiseTab.Controls.Add(this.fbm2Checkbox);
            this.noiseTab.Controls.Add(this.fbm1OffsetLabel);
            this.noiseTab.Controls.Add(this.fbm1OffsetY);
            this.noiseTab.Controls.Add(this.fbm1OffsetX);
            this.noiseTab.Controls.Add(this.fbm1Opacity);
            this.noiseTab.Controls.Add(this.positionLabel);
            this.noiseTab.Controls.Add(this.fbm1Checkbox);
            this.noiseTab.Controls.Add(this.brightnessLabel);
            this.noiseTab.Controls.Add(this.lacunarityLabel);
            this.noiseTab.Controls.Add(this.gainLabel);
            this.noiseTab.Controls.Add(this.frequencyLabel);
            this.noiseTab.Controls.Add(this.scaleLabel);
            this.noiseTab.Controls.Add(this.randomSeedLabel);
            this.noiseTab.Controls.Add(this.randomTextureDimensionsLabel);
            this.noiseTab.Location = new System.Drawing.Point(4, 49);
            this.noiseTab.Name = "noiseTab";
            this.noiseTab.Padding = new System.Windows.Forms.Padding(3);
            this.noiseTab.Size = new System.Drawing.Size(250, 464);
            this.noiseTab.TabIndex = 1;
            this.noiseTab.Text = "Noise";
            this.noiseTab.UseVisualStyleBackColor = true;
            // 
            // worleyCheckbox
            // 
            this.worleyCheckbox.AutoSize = true;
            this.worleyCheckbox.Location = new System.Drawing.Point(9, 307);
            this.worleyCheckbox.Name = "worleyCheckbox";
            this.worleyCheckbox.Size = new System.Drawing.Size(95, 17);
            this.worleyCheckbox.TabIndex = 69;
            this.worleyCheckbox.Text = "Use Cell Noise";
            this.worleyCheckbox.UseVisualStyleBackColor = true;
            this.worleyCheckbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseHighColorLabel
            // 
            this.noiseHighColorLabel.AutoSize = true;
            this.noiseHighColorLabel.Location = new System.Drawing.Point(118, 258);
            this.noiseHighColorLabel.Name = "noiseHighColorLabel";
            this.noiseHighColorLabel.Size = new System.Drawing.Size(56, 13);
            this.noiseHighColorLabel.TabIndex = 68;
            this.noiseHighColorLabel.Text = "High Color";
            // 
            // noiseHighColorPicture
            // 
            this.noiseHighColorPicture.Location = new System.Drawing.Point(123, 274);
            this.noiseHighColorPicture.Name = "noiseHighColorPicture";
            this.noiseHighColorPicture.Size = new System.Drawing.Size(98, 26);
            this.noiseHighColorPicture.TabIndex = 67;
            this.noiseHighColorPicture.TabStop = false;
            this.noiseHighColorPicture.Click += new System.EventHandler(this.noiseHighColorPicture_Click);
            // 
            // noiseLowColorLabel
            // 
            this.noiseLowColorLabel.AutoSize = true;
            this.noiseLowColorLabel.Location = new System.Drawing.Point(6, 258);
            this.noiseLowColorLabel.Name = "noiseLowColorLabel";
            this.noiseLowColorLabel.Size = new System.Drawing.Size(54, 13);
            this.noiseLowColorLabel.TabIndex = 66;
            this.noiseLowColorLabel.Text = "Low Color";
            // 
            // noiseLowColorPicture
            // 
            this.noiseLowColorPicture.Location = new System.Drawing.Point(11, 274);
            this.noiseLowColorPicture.Name = "noiseLowColorPicture";
            this.noiseLowColorPicture.Size = new System.Drawing.Size(98, 26);
            this.noiseLowColorPicture.TabIndex = 65;
            this.noiseLowColorPicture.TabStop = false;
            this.noiseLowColorPicture.Click += new System.EventHandler(this.noiseLowColorPicture_Click);
            // 
            // noiseBrightness
            // 
            this.noiseBrightness.DecimalPlaces = 4;
            this.noiseBrightness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.noiseBrightness.Location = new System.Drawing.Point(119, 225);
            this.noiseBrightness.Name = "noiseBrightness";
            this.noiseBrightness.Size = new System.Drawing.Size(102, 20);
            this.noiseBrightness.TabIndex = 64;
            this.noiseBrightness.Value = new decimal(new int[] {
            13,
            0,
            0,
            65536});
            this.noiseBrightness.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseLacunarity
            // 
            this.noiseLacunarity.DecimalPlaces = 4;
            this.noiseLacunarity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.noiseLacunarity.Location = new System.Drawing.Point(9, 225);
            this.noiseLacunarity.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.noiseLacunarity.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            -2147483648});
            this.noiseLacunarity.Name = "noiseLacunarity";
            this.noiseLacunarity.Size = new System.Drawing.Size(100, 20);
            this.noiseLacunarity.TabIndex = 63;
            this.noiseLacunarity.Value = new decimal(new int[] {
            16,
            0,
            0,
            65536});
            this.noiseLacunarity.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseGain
            // 
            this.noiseGain.DecimalPlaces = 4;
            this.noiseGain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.noiseGain.Location = new System.Drawing.Point(119, 176);
            this.noiseGain.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.noiseGain.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            -2147483648});
            this.noiseGain.Name = "noiseGain";
            this.noiseGain.Size = new System.Drawing.Size(102, 20);
            this.noiseGain.TabIndex = 62;
            this.noiseGain.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.noiseGain.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseFrequency
            // 
            this.noiseFrequency.DecimalPlaces = 4;
            this.noiseFrequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.noiseFrequency.Location = new System.Drawing.Point(9, 176);
            this.noiseFrequency.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.noiseFrequency.Minimum = new decimal(new int[] {
            512,
            0,
            0,
            -2147483648});
            this.noiseFrequency.Name = "noiseFrequency";
            this.noiseFrequency.Size = new System.Drawing.Size(100, 20);
            this.noiseFrequency.TabIndex = 61;
            this.noiseFrequency.Value = new decimal(new int[] {
            23,
            0,
            0,
            131072});
            this.noiseFrequency.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseTextureHeight
            // 
            this.noiseTextureHeight.Location = new System.Drawing.Point(121, 127);
            this.noiseTextureHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.noiseTextureHeight.Name = "noiseTextureHeight";
            this.noiseTextureHeight.Size = new System.Drawing.Size(100, 20);
            this.noiseTextureHeight.TabIndex = 60;
            this.noiseTextureHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.noiseTextureHeight.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseTextureWidth
            // 
            this.noiseTextureWidth.Location = new System.Drawing.Point(9, 127);
            this.noiseTextureWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.noiseTextureWidth.Name = "noiseTextureWidth";
            this.noiseTextureWidth.Size = new System.Drawing.Size(100, 20);
            this.noiseTextureWidth.TabIndex = 59;
            this.noiseTextureWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.noiseTextureWidth.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noisePositionY
            // 
            this.noisePositionY.DecimalPlaces = 4;
            this.noisePositionY.Location = new System.Drawing.Point(121, 78);
            this.noisePositionY.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.noisePositionY.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.noisePositionY.Name = "noisePositionY";
            this.noisePositionY.Size = new System.Drawing.Size(100, 20);
            this.noisePositionY.TabIndex = 58;
            this.noisePositionY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noisePositionX
            // 
            this.noisePositionX.DecimalPlaces = 4;
            this.noisePositionX.Location = new System.Drawing.Point(9, 78);
            this.noisePositionX.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.noisePositionX.Minimum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            -2147483648});
            this.noisePositionX.Name = "noisePositionX";
            this.noisePositionX.Size = new System.Drawing.Size(100, 20);
            this.noisePositionX.TabIndex = 57;
            this.noisePositionX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseSeed
            // 
            this.noiseSeed.Location = new System.Drawing.Point(8, 29);
            this.noiseSeed.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.noiseSeed.Name = "noiseSeed";
            this.noiseSeed.Size = new System.Drawing.Size(101, 20);
            this.noiseSeed.TabIndex = 56;
            this.noiseSeed.Value = new decimal(new int[] {
            123456,
            0,
            0,
            0});
            this.noiseSeed.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // noiseScale
            // 
            this.noiseScale.DecimalPlaces = 4;
            this.noiseScale.Increment = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.noiseScale.Location = new System.Drawing.Point(121, 29);
            this.noiseScale.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.noiseScale.Minimum = new decimal(new int[] {
            2048,
            0,
            0,
            -2147483648});
            this.noiseScale.Name = "noiseScale";
            this.noiseScale.Size = new System.Drawing.Size(100, 20);
            this.noiseScale.TabIndex = 55;
            this.noiseScale.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.fbm3PositionAndNoise);
            this.panel3.Controls.Add(this.fbm3NoiseOnly);
            this.panel3.Location = new System.Drawing.Point(9, 585);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 47);
            this.panel3.TabIndex = 54;
            // 
            // fbm3PositionAndNoise
            // 
            this.fbm3PositionAndNoise.AutoSize = true;
            this.fbm3PositionAndNoise.Location = new System.Drawing.Point(0, 0);
            this.fbm3PositionAndNoise.Name = "fbm3PositionAndNoise";
            this.fbm3PositionAndNoise.Size = new System.Drawing.Size(101, 17);
            this.fbm3PositionAndNoise.TabIndex = 34;
            this.fbm3PositionAndNoise.Text = "Position + Noise";
            this.fbm3PositionAndNoise.UseVisualStyleBackColor = true;
            this.fbm3PositionAndNoise.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm3NoiseOnly
            // 
            this.fbm3NoiseOnly.AutoSize = true;
            this.fbm3NoiseOnly.Checked = true;
            this.fbm3NoiseOnly.Location = new System.Drawing.Point(0, 23);
            this.fbm3NoiseOnly.Name = "fbm3NoiseOnly";
            this.fbm3NoiseOnly.Size = new System.Drawing.Size(76, 17);
            this.fbm3NoiseOnly.TabIndex = 33;
            this.fbm3NoiseOnly.TabStop = true;
            this.fbm3NoiseOnly.Text = "Noise Only";
            this.fbm3NoiseOnly.UseVisualStyleBackColor = true;
            this.fbm3NoiseOnly.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fbm2PositionAndNoise);
            this.panel2.Controls.Add(this.fbm2NoiseOnly);
            this.panel2.Location = new System.Drawing.Point(9, 490);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 47);
            this.panel2.TabIndex = 53;
            // 
            // fbm2PositionAndNoise
            // 
            this.fbm2PositionAndNoise.AutoSize = true;
            this.fbm2PositionAndNoise.Checked = true;
            this.fbm2PositionAndNoise.Location = new System.Drawing.Point(0, 0);
            this.fbm2PositionAndNoise.Name = "fbm2PositionAndNoise";
            this.fbm2PositionAndNoise.Size = new System.Drawing.Size(101, 17);
            this.fbm2PositionAndNoise.TabIndex = 34;
            this.fbm2PositionAndNoise.TabStop = true;
            this.fbm2PositionAndNoise.Text = "Position + Noise";
            this.fbm2PositionAndNoise.UseVisualStyleBackColor = true;
            this.fbm2PositionAndNoise.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm2NoiseOnly
            // 
            this.fbm2NoiseOnly.AutoSize = true;
            this.fbm2NoiseOnly.Location = new System.Drawing.Point(0, 23);
            this.fbm2NoiseOnly.Name = "fbm2NoiseOnly";
            this.fbm2NoiseOnly.Size = new System.Drawing.Size(76, 17);
            this.fbm2NoiseOnly.TabIndex = 33;
            this.fbm2NoiseOnly.Text = "Noise Only";
            this.fbm2NoiseOnly.UseVisualStyleBackColor = true;
            this.fbm2NoiseOnly.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fbm1PositionAndNoise);
            this.panel1.Controls.Add(this.fbm1NoiseOnly);
            this.panel1.Location = new System.Drawing.Point(9, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 47);
            this.panel1.TabIndex = 52;
            // 
            // fbm1PositionAndNoise
            // 
            this.fbm1PositionAndNoise.AutoSize = true;
            this.fbm1PositionAndNoise.Checked = true;
            this.fbm1PositionAndNoise.Location = new System.Drawing.Point(0, 0);
            this.fbm1PositionAndNoise.Name = "fbm1PositionAndNoise";
            this.fbm1PositionAndNoise.Size = new System.Drawing.Size(101, 17);
            this.fbm1PositionAndNoise.TabIndex = 34;
            this.fbm1PositionAndNoise.TabStop = true;
            this.fbm1PositionAndNoise.Text = "Position + Noise";
            this.fbm1PositionAndNoise.UseVisualStyleBackColor = true;
            this.fbm1PositionAndNoise.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm1NoiseOnly
            // 
            this.fbm1NoiseOnly.AutoSize = true;
            this.fbm1NoiseOnly.Location = new System.Drawing.Point(0, 23);
            this.fbm1NoiseOnly.Name = "fbm1NoiseOnly";
            this.fbm1NoiseOnly.Size = new System.Drawing.Size(76, 17);
            this.fbm1NoiseOnly.TabIndex = 33;
            this.fbm1NoiseOnly.Text = "Noise Only";
            this.fbm1NoiseOnly.UseVisualStyleBackColor = true;
            this.fbm1NoiseOnly.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm3OffsetLabel
            // 
            this.fbm3OffsetLabel.AutoSize = true;
            this.fbm3OffsetLabel.Location = new System.Drawing.Point(116, 592);
            this.fbm3OffsetLabel.Name = "fbm3OffsetLabel";
            this.fbm3OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.fbm3OffsetLabel.TabIndex = 51;
            this.fbm3OffsetLabel.Text = "Offset";
            // 
            // fbm3OffsetY
            // 
            this.fbm3OffsetY.DecimalPlaces = 3;
            this.fbm3OffsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.fbm3OffsetY.Location = new System.Drawing.Point(171, 608);
            this.fbm3OffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fbm3OffsetY.Name = "fbm3OffsetY";
            this.fbm3OffsetY.Size = new System.Drawing.Size(50, 20);
            this.fbm3OffsetY.TabIndex = 50;
            this.fbm3OffsetY.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.fbm3OffsetY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm3OffsetX
            // 
            this.fbm3OffsetX.DecimalPlaces = 3;
            this.fbm3OffsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.fbm3OffsetX.Location = new System.Drawing.Point(121, 608);
            this.fbm3OffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fbm3OffsetX.Name = "fbm3OffsetX";
            this.fbm3OffsetX.Size = new System.Drawing.Size(50, 20);
            this.fbm3OffsetX.TabIndex = 49;
            this.fbm3OffsetX.Value = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.fbm3OffsetX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm3Opacity
            // 
            this.fbm3Opacity.DecimalPlaces = 4;
            this.fbm3Opacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.fbm3Opacity.Location = new System.Drawing.Point(121, 561);
            this.fbm3Opacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fbm3Opacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.fbm3Opacity.Name = "fbm3Opacity";
            this.fbm3Opacity.Size = new System.Drawing.Size(100, 20);
            this.fbm3Opacity.TabIndex = 46;
            this.fbm3Opacity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.fbm3Opacity.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm3Checkbox
            // 
            this.fbm3Checkbox.AutoSize = true;
            this.fbm3Checkbox.Checked = true;
            this.fbm3Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fbm3Checkbox.Location = new System.Drawing.Point(9, 562);
            this.fbm3Checkbox.Name = "fbm3Checkbox";
            this.fbm3Checkbox.Size = new System.Drawing.Size(110, 17);
            this.fbm3Checkbox.TabIndex = 45;
            this.fbm3Checkbox.Text = "Fractional Layer 3";
            this.fbm3Checkbox.UseVisualStyleBackColor = true;
            this.fbm3Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm2OffsetLabel
            // 
            this.fbm2OffsetLabel.AutoSize = true;
            this.fbm2OffsetLabel.Location = new System.Drawing.Point(116, 497);
            this.fbm2OffsetLabel.Name = "fbm2OffsetLabel";
            this.fbm2OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.fbm2OffsetLabel.TabIndex = 44;
            this.fbm2OffsetLabel.Text = "Offset";
            // 
            // fbm2OffsetY
            // 
            this.fbm2OffsetY.DecimalPlaces = 3;
            this.fbm2OffsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.fbm2OffsetY.Location = new System.Drawing.Point(171, 513);
            this.fbm2OffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fbm2OffsetY.Name = "fbm2OffsetY";
            this.fbm2OffsetY.Size = new System.Drawing.Size(50, 20);
            this.fbm2OffsetY.TabIndex = 43;
            this.fbm2OffsetY.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.fbm2OffsetY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm2OffsetX
            // 
            this.fbm2OffsetX.DecimalPlaces = 3;
            this.fbm2OffsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.fbm2OffsetX.Location = new System.Drawing.Point(121, 513);
            this.fbm2OffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fbm2OffsetX.Name = "fbm2OffsetX";
            this.fbm2OffsetX.Size = new System.Drawing.Size(50, 20);
            this.fbm2OffsetX.TabIndex = 42;
            this.fbm2OffsetX.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.fbm2OffsetX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm2Opacity
            // 
            this.fbm2Opacity.DecimalPlaces = 4;
            this.fbm2Opacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.fbm2Opacity.Location = new System.Drawing.Point(121, 466);
            this.fbm2Opacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fbm2Opacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.fbm2Opacity.Name = "fbm2Opacity";
            this.fbm2Opacity.Size = new System.Drawing.Size(100, 20);
            this.fbm2Opacity.TabIndex = 39;
            this.fbm2Opacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fbm2Opacity.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm2Checkbox
            // 
            this.fbm2Checkbox.AutoSize = true;
            this.fbm2Checkbox.Checked = true;
            this.fbm2Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fbm2Checkbox.Location = new System.Drawing.Point(9, 467);
            this.fbm2Checkbox.Name = "fbm2Checkbox";
            this.fbm2Checkbox.Size = new System.Drawing.Size(110, 17);
            this.fbm2Checkbox.TabIndex = 38;
            this.fbm2Checkbox.Text = "Fractional Layer 2";
            this.fbm2Checkbox.UseVisualStyleBackColor = true;
            this.fbm2Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm1OffsetLabel
            // 
            this.fbm1OffsetLabel.AutoSize = true;
            this.fbm1OffsetLabel.Location = new System.Drawing.Point(116, 399);
            this.fbm1OffsetLabel.Name = "fbm1OffsetLabel";
            this.fbm1OffsetLabel.Size = new System.Drawing.Size(35, 13);
            this.fbm1OffsetLabel.TabIndex = 37;
            this.fbm1OffsetLabel.Text = "Offset";
            // 
            // fbm1OffsetY
            // 
            this.fbm1OffsetY.DecimalPlaces = 3;
            this.fbm1OffsetY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.fbm1OffsetY.Location = new System.Drawing.Point(171, 415);
            this.fbm1OffsetY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fbm1OffsetY.Name = "fbm1OffsetY";
            this.fbm1OffsetY.Size = new System.Drawing.Size(50, 20);
            this.fbm1OffsetY.TabIndex = 36;
            this.fbm1OffsetY.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            this.fbm1OffsetY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm1OffsetX
            // 
            this.fbm1OffsetX.DecimalPlaces = 3;
            this.fbm1OffsetX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.fbm1OffsetX.Location = new System.Drawing.Point(121, 415);
            this.fbm1OffsetX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fbm1OffsetX.Name = "fbm1OffsetX";
            this.fbm1OffsetX.Size = new System.Drawing.Size(50, 20);
            this.fbm1OffsetX.TabIndex = 35;
            this.fbm1OffsetX.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.fbm1OffsetX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // fbm1Opacity
            // 
            this.fbm1Opacity.DecimalPlaces = 4;
            this.fbm1Opacity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.fbm1Opacity.Location = new System.Drawing.Point(121, 368);
            this.fbm1Opacity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fbm1Opacity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.fbm1Opacity.Name = "fbm1Opacity";
            this.fbm1Opacity.Size = new System.Drawing.Size(100, 20);
            this.fbm1Opacity.TabIndex = 31;
            this.fbm1Opacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fbm1Opacity.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(6, 61);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(44, 13);
            this.positionLabel.TabIndex = 28;
            this.positionLabel.Text = "Position";
            // 
            // fbm1Checkbox
            // 
            this.fbm1Checkbox.AutoSize = true;
            this.fbm1Checkbox.Checked = true;
            this.fbm1Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fbm1Checkbox.Location = new System.Drawing.Point(9, 369);
            this.fbm1Checkbox.Name = "fbm1Checkbox";
            this.fbm1Checkbox.Size = new System.Drawing.Size(110, 17);
            this.fbm1Checkbox.TabIndex = 19;
            this.fbm1Checkbox.Text = "Fractional Layer 1";
            this.fbm1Checkbox.UseVisualStyleBackColor = true;
            this.fbm1Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(118, 208);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(56, 13);
            this.brightnessLabel.TabIndex = 17;
            this.brightnessLabel.Text = "Brightness";
            // 
            // lacunarityLabel
            // 
            this.lacunarityLabel.AutoSize = true;
            this.lacunarityLabel.Location = new System.Drawing.Point(6, 208);
            this.lacunarityLabel.Name = "lacunarityLabel";
            this.lacunarityLabel.Size = new System.Drawing.Size(56, 13);
            this.lacunarityLabel.TabIndex = 15;
            this.lacunarityLabel.Text = "Lacunarity";
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Location = new System.Drawing.Point(118, 159);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(29, 13);
            this.gainLabel.TabIndex = 11;
            this.gainLabel.Text = "Gain";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(6, 159);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.frequencyLabel.TabIndex = 9;
            this.frequencyLabel.Text = "Frequency";
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Location = new System.Drawing.Point(118, 12);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(34, 13);
            this.scaleLabel.TabIndex = 7;
            this.scaleLabel.Text = "Scale";
            // 
            // waterTab
            // 
            this.waterTab.Controls.Add(this.waterDeepColorLabel);
            this.waterTab.Controls.Add(this.waterDeepColorPicture);
            this.waterTab.Controls.Add(this.waterShallowColorLabel);
            this.waterTab.Controls.Add(this.waterShallowColorPicture);
            this.waterTab.Controls.Add(this.waterCheckbox);
            this.waterTab.Controls.Add(this.waterLevel);
            this.waterTab.Controls.Add(this.waterLevelLabel);
            this.waterTab.Location = new System.Drawing.Point(4, 49);
            this.waterTab.Name = "waterTab";
            this.waterTab.Size = new System.Drawing.Size(250, 464);
            this.waterTab.TabIndex = 2;
            this.waterTab.Text = "Water";
            this.waterTab.UseVisualStyleBackColor = true;
            // 
            // waterDeepColorLabel
            // 
            this.waterDeepColorLabel.AutoSize = true;
            this.waterDeepColorLabel.Location = new System.Drawing.Point(121, 86);
            this.waterDeepColorLabel.Name = "waterDeepColorLabel";
            this.waterDeepColorLabel.Size = new System.Drawing.Size(60, 13);
            this.waterDeepColorLabel.TabIndex = 69;
            this.waterDeepColorLabel.Text = "Deep Color";
            // 
            // waterDeepColorPicture
            // 
            this.waterDeepColorPicture.Location = new System.Drawing.Point(124, 102);
            this.waterDeepColorPicture.Name = "waterDeepColorPicture";
            this.waterDeepColorPicture.Size = new System.Drawing.Size(100, 23);
            this.waterDeepColorPicture.TabIndex = 68;
            this.waterDeepColorPicture.TabStop = false;
            this.waterDeepColorPicture.Click += new System.EventHandler(this.waterDeepColorPicture_Click);
            // 
            // waterShallowColorLabel
            // 
            this.waterShallowColorLabel.AutoSize = true;
            this.waterShallowColorLabel.Location = new System.Drawing.Point(5, 86);
            this.waterShallowColorLabel.Name = "waterShallowColorLabel";
            this.waterShallowColorLabel.Size = new System.Drawing.Size(71, 13);
            this.waterShallowColorLabel.TabIndex = 67;
            this.waterShallowColorLabel.Text = "Shallow Color";
            // 
            // waterShallowColorPicture
            // 
            this.waterShallowColorPicture.Location = new System.Drawing.Point(8, 102);
            this.waterShallowColorPicture.Name = "waterShallowColorPicture";
            this.waterShallowColorPicture.Size = new System.Drawing.Size(100, 23);
            this.waterShallowColorPicture.TabIndex = 66;
            this.waterShallowColorPicture.TabStop = false;
            this.waterShallowColorPicture.Click += new System.EventHandler(this.waterShallowColorPicture_Click);
            // 
            // waterCheckbox
            // 
            this.waterCheckbox.AutoSize = true;
            this.waterCheckbox.Checked = true;
            this.waterCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.waterCheckbox.Location = new System.Drawing.Point(8, 12);
            this.waterCheckbox.Name = "waterCheckbox";
            this.waterCheckbox.Size = new System.Drawing.Size(91, 17);
            this.waterCheckbox.TabIndex = 33;
            this.waterCheckbox.Text = "Enable Water";
            this.waterCheckbox.UseVisualStyleBackColor = true;
            this.waterCheckbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // waterLevel
            // 
            this.waterLevel.DecimalPlaces = 4;
            this.waterLevel.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.waterLevel.Location = new System.Drawing.Point(8, 48);
            this.waterLevel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.waterLevel.Name = "waterLevel";
            this.waterLevel.Size = new System.Drawing.Size(100, 20);
            this.waterLevel.TabIndex = 32;
            this.waterLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.waterLevel.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(5, 32);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(65, 13);
            this.waterLevelLabel.TabIndex = 0;
            this.waterLevelLabel.Text = "Water Level";
            // 
            // floraTab
            // 
            this.floraTab.Controls.Add(this.flora2ShowPlantColor);
            this.floraTab.Controls.Add(this.flora2PlantColorLabel);
            this.floraTab.Controls.Add(this.flora2PlantColorPicture);
            this.floraTab.Controls.Add(this.flora2ShowGroundColor);
            this.floraTab.Controls.Add(this.flora2GroundColorLabel);
            this.floraTab.Controls.Add(this.flora2GroundColorPicture);
            this.floraTab.Controls.Add(this.flora2Scale);
            this.floraTab.Controls.Add(this.flora2ScaleLabel);
            this.floraTab.Controls.Add(this.flora2SelectTexture);
            this.floraTab.Controls.Add(this.flora2Frequency);
            this.floraTab.Controls.Add(this.flora2RangeX);
            this.floraTab.Controls.Add(this.flora2RangeY);
            this.floraTab.Controls.Add(this.flora2FrequencyLabel);
            this.floraTab.Controls.Add(this.flora2RangeLabel);
            this.floraTab.Controls.Add(this.flora2Checkbox);
            this.floraTab.Controls.Add(this.flora1ShowPlantColor);
            this.floraTab.Controls.Add(this.flora1PlantColorLabel);
            this.floraTab.Controls.Add(this.flora1PlantColorPicture);
            this.floraTab.Controls.Add(this.flora1ShowGroundColor);
            this.floraTab.Controls.Add(this.flora1GroundColorLabel);
            this.floraTab.Controls.Add(this.flora1GroundColorPicture);
            this.floraTab.Controls.Add(this.flora1Scale);
            this.floraTab.Controls.Add(this.flora1ScaleLabel);
            this.floraTab.Controls.Add(this.flora1SelectTexture);
            this.floraTab.Controls.Add(this.flora1Frequency);
            this.floraTab.Controls.Add(this.flora1RangeX);
            this.floraTab.Controls.Add(this.flora1RangeY);
            this.floraTab.Controls.Add(this.flora1FrequencyLabel);
            this.floraTab.Controls.Add(this.flora1RangeLabel);
            this.floraTab.Controls.Add(this.flora1Checkbox);
            this.floraTab.Location = new System.Drawing.Point(4, 49);
            this.floraTab.Name = "floraTab";
            this.floraTab.Size = new System.Drawing.Size(250, 464);
            this.floraTab.TabIndex = 3;
            this.floraTab.Text = "Flora";
            this.floraTab.UseVisualStyleBackColor = true;
            // 
            // flora2ShowPlantColor
            // 
            this.flora2ShowPlantColor.AutoSize = true;
            this.flora2ShowPlantColor.Checked = true;
            this.flora2ShowPlantColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flora2ShowPlantColor.Location = new System.Drawing.Point(122, 337);
            this.flora2ShowPlantColor.Name = "flora2ShowPlantColor";
            this.flora2ShowPlantColor.Size = new System.Drawing.Size(15, 14);
            this.flora2ShowPlantColor.TabIndex = 84;
            this.flora2ShowPlantColor.UseVisualStyleBackColor = true;
            this.flora2ShowPlantColor.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora2PlantColorLabel
            // 
            this.flora2PlantColorLabel.AutoSize = true;
            this.flora2PlantColorLabel.Location = new System.Drawing.Point(118, 316);
            this.flora2PlantColorLabel.Name = "flora2PlantColorLabel";
            this.flora2PlantColorLabel.Size = new System.Drawing.Size(58, 13);
            this.flora2PlantColorLabel.TabIndex = 83;
            this.flora2PlantColorLabel.Text = "Plant Color";
            // 
            // flora2PlantColorPicture
            // 
            this.flora2PlantColorPicture.Location = new System.Drawing.Point(142, 332);
            this.flora2PlantColorPicture.Name = "flora2PlantColorPicture";
            this.flora2PlantColorPicture.Size = new System.Drawing.Size(62, 23);
            this.flora2PlantColorPicture.TabIndex = 82;
            this.flora2PlantColorPicture.TabStop = false;
            this.flora2PlantColorPicture.Click += new System.EventHandler(this.flora2PlantColorPicture_Click);
            // 
            // flora2ShowGroundColor
            // 
            this.flora2ShowGroundColor.AutoSize = true;
            this.flora2ShowGroundColor.Checked = true;
            this.flora2ShowGroundColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flora2ShowGroundColor.Location = new System.Drawing.Point(9, 337);
            this.flora2ShowGroundColor.Name = "flora2ShowGroundColor";
            this.flora2ShowGroundColor.Size = new System.Drawing.Size(15, 14);
            this.flora2ShowGroundColor.TabIndex = 81;
            this.flora2ShowGroundColor.UseVisualStyleBackColor = true;
            this.flora2ShowGroundColor.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora2GroundColorLabel
            // 
            this.flora2GroundColorLabel.AutoSize = true;
            this.flora2GroundColorLabel.Location = new System.Drawing.Point(5, 316);
            this.flora2GroundColorLabel.Name = "flora2GroundColorLabel";
            this.flora2GroundColorLabel.Size = new System.Drawing.Size(69, 13);
            this.flora2GroundColorLabel.TabIndex = 80;
            this.flora2GroundColorLabel.Text = "Ground Color";
            // 
            // flora2GroundColorPicture
            // 
            this.flora2GroundColorPicture.Location = new System.Drawing.Point(29, 332);
            this.flora2GroundColorPicture.Name = "flora2GroundColorPicture";
            this.flora2GroundColorPicture.Size = new System.Drawing.Size(65, 23);
            this.flora2GroundColorPicture.TabIndex = 79;
            this.flora2GroundColorPicture.TabStop = false;
            this.flora2GroundColorPicture.Click += new System.EventHandler(this.flora2GroundColorPicture_Click);
            // 
            // flora2Scale
            // 
            this.flora2Scale.DecimalPlaces = 4;
            this.flora2Scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora2Scale.Location = new System.Drawing.Point(124, 284);
            this.flora2Scale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flora2Scale.Name = "flora2Scale";
            this.flora2Scale.Size = new System.Drawing.Size(97, 20);
            this.flora2Scale.TabIndex = 78;
            this.flora2Scale.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.flora2Scale.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora2ScaleLabel
            // 
            this.flora2ScaleLabel.AutoSize = true;
            this.flora2ScaleLabel.Location = new System.Drawing.Point(121, 267);
            this.flora2ScaleLabel.Name = "flora2ScaleLabel";
            this.flora2ScaleLabel.Size = new System.Drawing.Size(73, 13);
            this.flora2ScaleLabel.TabIndex = 77;
            this.flora2ScaleLabel.Text = "Texture Scale";
            // 
            // flora2SelectTexture
            // 
            this.flora2SelectTexture.Location = new System.Drawing.Point(121, 199);
            this.flora2SelectTexture.Name = "flora2SelectTexture";
            this.flora2SelectTexture.Size = new System.Drawing.Size(100, 23);
            this.flora2SelectTexture.TabIndex = 76;
            this.flora2SelectTexture.Text = "Select Textures";
            this.flora2SelectTexture.UseVisualStyleBackColor = true;
            this.flora2SelectTexture.Click += new System.EventHandler(this.flora2SelectTexture_Click);
            // 
            // flora2Frequency
            // 
            this.flora2Frequency.DecimalPlaces = 4;
            this.flora2Frequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora2Frequency.Location = new System.Drawing.Point(8, 284);
            this.flora2Frequency.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.flora2Frequency.Name = "flora2Frequency";
            this.flora2Frequency.Size = new System.Drawing.Size(101, 20);
            this.flora2Frequency.TabIndex = 75;
            this.flora2Frequency.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.flora2Frequency.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora2RangeX
            // 
            this.flora2RangeX.DecimalPlaces = 4;
            this.flora2RangeX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora2RangeX.Location = new System.Drawing.Point(8, 235);
            this.flora2RangeX.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flora2RangeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.flora2RangeX.Name = "flora2RangeX";
            this.flora2RangeX.Size = new System.Drawing.Size(101, 20);
            this.flora2RangeX.TabIndex = 74;
            this.flora2RangeX.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.flora2RangeX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora2RangeY
            // 
            this.flora2RangeY.DecimalPlaces = 4;
            this.flora2RangeY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora2RangeY.Location = new System.Drawing.Point(121, 235);
            this.flora2RangeY.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flora2RangeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.flora2RangeY.Name = "flora2RangeY";
            this.flora2RangeY.Size = new System.Drawing.Size(100, 20);
            this.flora2RangeY.TabIndex = 73;
            this.flora2RangeY.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            this.flora2RangeY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora2FrequencyLabel
            // 
            this.flora2FrequencyLabel.AutoSize = true;
            this.flora2FrequencyLabel.Location = new System.Drawing.Point(5, 267);
            this.flora2FrequencyLabel.Name = "flora2FrequencyLabel";
            this.flora2FrequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.flora2FrequencyLabel.TabIndex = 72;
            this.flora2FrequencyLabel.Text = "Frequency";
            // 
            // flora2RangeLabel
            // 
            this.flora2RangeLabel.AutoSize = true;
            this.flora2RangeLabel.Location = new System.Drawing.Point(5, 219);
            this.flora2RangeLabel.Name = "flora2RangeLabel";
            this.flora2RangeLabel.Size = new System.Drawing.Size(39, 13);
            this.flora2RangeLabel.TabIndex = 71;
            this.flora2RangeLabel.Text = "Range";
            // 
            // flora2Checkbox
            // 
            this.flora2Checkbox.AutoSize = true;
            this.flora2Checkbox.Location = new System.Drawing.Point(8, 199);
            this.flora2Checkbox.Name = "flora2Checkbox";
            this.flora2Checkbox.Size = new System.Drawing.Size(97, 17);
            this.flora2Checkbox.TabIndex = 70;
            this.flora2Checkbox.Text = "Enable Layer 2";
            this.flora2Checkbox.UseVisualStyleBackColor = true;
            this.flora2Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora1ShowPlantColor
            // 
            this.flora1ShowPlantColor.AutoSize = true;
            this.flora1ShowPlantColor.Checked = true;
            this.flora1ShowPlantColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flora1ShowPlantColor.Location = new System.Drawing.Point(122, 150);
            this.flora1ShowPlantColor.Name = "flora1ShowPlantColor";
            this.flora1ShowPlantColor.Size = new System.Drawing.Size(15, 14);
            this.flora1ShowPlantColor.TabIndex = 69;
            this.flora1ShowPlantColor.UseVisualStyleBackColor = true;
            this.flora1ShowPlantColor.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora1PlantColorLabel
            // 
            this.flora1PlantColorLabel.AutoSize = true;
            this.flora1PlantColorLabel.Location = new System.Drawing.Point(118, 129);
            this.flora1PlantColorLabel.Name = "flora1PlantColorLabel";
            this.flora1PlantColorLabel.Size = new System.Drawing.Size(58, 13);
            this.flora1PlantColorLabel.TabIndex = 68;
            this.flora1PlantColorLabel.Text = "Plant Color";
            // 
            // flora1PlantColorPicture
            // 
            this.flora1PlantColorPicture.Location = new System.Drawing.Point(142, 145);
            this.flora1PlantColorPicture.Name = "flora1PlantColorPicture";
            this.flora1PlantColorPicture.Size = new System.Drawing.Size(62, 23);
            this.flora1PlantColorPicture.TabIndex = 67;
            this.flora1PlantColorPicture.TabStop = false;
            this.flora1PlantColorPicture.Click += new System.EventHandler(this.flora1PlantColorPicture_Click);
            // 
            // flora1ShowGroundColor
            // 
            this.flora1ShowGroundColor.AutoSize = true;
            this.flora1ShowGroundColor.Checked = true;
            this.flora1ShowGroundColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flora1ShowGroundColor.Location = new System.Drawing.Point(9, 150);
            this.flora1ShowGroundColor.Name = "flora1ShowGroundColor";
            this.flora1ShowGroundColor.Size = new System.Drawing.Size(15, 14);
            this.flora1ShowGroundColor.TabIndex = 66;
            this.flora1ShowGroundColor.UseVisualStyleBackColor = true;
            this.flora1ShowGroundColor.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora1GroundColorLabel
            // 
            this.flora1GroundColorLabel.AutoSize = true;
            this.flora1GroundColorLabel.Location = new System.Drawing.Point(5, 129);
            this.flora1GroundColorLabel.Name = "flora1GroundColorLabel";
            this.flora1GroundColorLabel.Size = new System.Drawing.Size(69, 13);
            this.flora1GroundColorLabel.TabIndex = 65;
            this.flora1GroundColorLabel.Text = "Ground Color";
            // 
            // flora1GroundColorPicture
            // 
            this.flora1GroundColorPicture.Location = new System.Drawing.Point(29, 145);
            this.flora1GroundColorPicture.Name = "flora1GroundColorPicture";
            this.flora1GroundColorPicture.Size = new System.Drawing.Size(65, 23);
            this.flora1GroundColorPicture.TabIndex = 64;
            this.flora1GroundColorPicture.TabStop = false;
            this.flora1GroundColorPicture.Click += new System.EventHandler(this.flora1GroundColorPicture_Click);
            // 
            // flora1Scale
            // 
            this.flora1Scale.DecimalPlaces = 4;
            this.flora1Scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora1Scale.Location = new System.Drawing.Point(124, 97);
            this.flora1Scale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.flora1Scale.Name = "flora1Scale";
            this.flora1Scale.Size = new System.Drawing.Size(97, 20);
            this.flora1Scale.TabIndex = 62;
            this.flora1Scale.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // flora1ScaleLabel
            // 
            this.flora1ScaleLabel.AutoSize = true;
            this.flora1ScaleLabel.Location = new System.Drawing.Point(121, 80);
            this.flora1ScaleLabel.Name = "flora1ScaleLabel";
            this.flora1ScaleLabel.Size = new System.Drawing.Size(73, 13);
            this.flora1ScaleLabel.TabIndex = 61;
            this.flora1ScaleLabel.Text = "Texture Scale";
            // 
            // flora1SelectTexture
            // 
            this.flora1SelectTexture.Location = new System.Drawing.Point(121, 12);
            this.flora1SelectTexture.Name = "flora1SelectTexture";
            this.flora1SelectTexture.Size = new System.Drawing.Size(100, 23);
            this.flora1SelectTexture.TabIndex = 60;
            this.flora1SelectTexture.Text = "Select Textures";
            this.flora1SelectTexture.UseVisualStyleBackColor = true;
            this.flora1SelectTexture.Click += new System.EventHandler(this.flora1SelectTexture_Click);
            // 
            // flora1Frequency
            // 
            this.flora1Frequency.DecimalPlaces = 4;
            this.flora1Frequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora1Frequency.Location = new System.Drawing.Point(8, 97);
            this.flora1Frequency.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.flora1Frequency.Name = "flora1Frequency";
            this.flora1Frequency.Size = new System.Drawing.Size(101, 20);
            this.flora1Frequency.TabIndex = 59;
            this.flora1Frequency.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.flora1Frequency.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora1RangeX
            // 
            this.flora1RangeX.DecimalPlaces = 4;
            this.flora1RangeX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora1RangeX.Location = new System.Drawing.Point(8, 48);
            this.flora1RangeX.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flora1RangeX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.flora1RangeX.Name = "flora1RangeX";
            this.flora1RangeX.Size = new System.Drawing.Size(101, 20);
            this.flora1RangeX.TabIndex = 58;
            this.flora1RangeX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora1RangeY
            // 
            this.flora1RangeY.DecimalPlaces = 4;
            this.flora1RangeY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.flora1RangeY.Location = new System.Drawing.Point(121, 48);
            this.flora1RangeY.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.flora1RangeY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.flora1RangeY.Name = "flora1RangeY";
            this.flora1RangeY.Size = new System.Drawing.Size(100, 20);
            this.flora1RangeY.TabIndex = 57;
            this.flora1RangeY.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.flora1RangeY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // flora1FrequencyLabel
            // 
            this.flora1FrequencyLabel.AutoSize = true;
            this.flora1FrequencyLabel.Location = new System.Drawing.Point(5, 80);
            this.flora1FrequencyLabel.Name = "flora1FrequencyLabel";
            this.flora1FrequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.flora1FrequencyLabel.TabIndex = 4;
            this.flora1FrequencyLabel.Text = "Frequency";
            // 
            // flora1RangeLabel
            // 
            this.flora1RangeLabel.AutoSize = true;
            this.flora1RangeLabel.Location = new System.Drawing.Point(5, 32);
            this.flora1RangeLabel.Name = "flora1RangeLabel";
            this.flora1RangeLabel.Size = new System.Drawing.Size(39, 13);
            this.flora1RangeLabel.TabIndex = 2;
            this.flora1RangeLabel.Text = "Range";
            // 
            // flora1Checkbox
            // 
            this.flora1Checkbox.AutoSize = true;
            this.flora1Checkbox.Checked = true;
            this.flora1Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flora1Checkbox.Location = new System.Drawing.Point(8, 12);
            this.flora1Checkbox.Name = "flora1Checkbox";
            this.flora1Checkbox.Size = new System.Drawing.Size(97, 17);
            this.flora1Checkbox.TabIndex = 0;
            this.flora1Checkbox.Text = "Enable Layer 1";
            this.flora1Checkbox.UseVisualStyleBackColor = true;
            this.flora1Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsTab
            // 
            this.detailsTab.Controls.Add(this.detailsLayer3Scale);
            this.detailsTab.Controls.Add(this.detailsLayer3ScaleLabel);
            this.detailsTab.Controls.Add(this.selectDetail3Textures);
            this.detailsTab.Controls.Add(this.detailsLayer3RangeMin);
            this.detailsTab.Controls.Add(this.detailsLayer3RangeMax);
            this.detailsTab.Controls.Add(this.detailsLayer3RangeLabel);
            this.detailsTab.Controls.Add(this.detailsLayer3Checkbox);
            this.detailsTab.Controls.Add(this.detailsLayer2Scale);
            this.detailsTab.Controls.Add(this.detailsLayer2ScaleLabel);
            this.detailsTab.Controls.Add(this.selectDetail2Textures);
            this.detailsTab.Controls.Add(this.detailsLayer2RangeMin);
            this.detailsTab.Controls.Add(this.detailsLayer2RangeMax);
            this.detailsTab.Controls.Add(this.detailsLayer2RangeLabel);
            this.detailsTab.Controls.Add(this.detailsLayer2Checkbox);
            this.detailsTab.Controls.Add(this.detailsLayer1Scale);
            this.detailsTab.Controls.Add(this.detailsLayer1ScaleLabel);
            this.detailsTab.Controls.Add(this.selectDetail1Textures);
            this.detailsTab.Controls.Add(this.detailsLayer1RangeMin);
            this.detailsTab.Controls.Add(this.detailsLayer1RangeMax);
            this.detailsTab.Controls.Add(this.detailsLayer1RangeLabel);
            this.detailsTab.Controls.Add(this.detailsLayer1Checkbox);
            this.detailsTab.Location = new System.Drawing.Point(4, 49);
            this.detailsTab.Name = "detailsTab";
            this.detailsTab.Size = new System.Drawing.Size(250, 464);
            this.detailsTab.TabIndex = 4;
            this.detailsTab.Text = "Details";
            this.detailsTab.UseVisualStyleBackColor = true;
            // 
            // detailsLayer3Scale
            // 
            this.detailsLayer3Scale.DecimalPlaces = 4;
            this.detailsLayer3Scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer3Scale.Location = new System.Drawing.Point(8, 364);
            this.detailsLayer3Scale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.detailsLayer3Scale.Name = "detailsLayer3Scale";
            this.detailsLayer3Scale.Size = new System.Drawing.Size(101, 20);
            this.detailsLayer3Scale.TabIndex = 80;
            this.detailsLayer3Scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.detailsLayer3Scale.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer3ScaleLabel
            // 
            this.detailsLayer3ScaleLabel.AutoSize = true;
            this.detailsLayer3ScaleLabel.Location = new System.Drawing.Point(5, 347);
            this.detailsLayer3ScaleLabel.Name = "detailsLayer3ScaleLabel";
            this.detailsLayer3ScaleLabel.Size = new System.Drawing.Size(73, 13);
            this.detailsLayer3ScaleLabel.TabIndex = 79;
            this.detailsLayer3ScaleLabel.Text = "Texture Scale";
            // 
            // selectDetail3Textures
            // 
            this.selectDetail3Textures.Location = new System.Drawing.Point(121, 279);
            this.selectDetail3Textures.Name = "selectDetail3Textures";
            this.selectDetail3Textures.Size = new System.Drawing.Size(100, 23);
            this.selectDetail3Textures.TabIndex = 78;
            this.selectDetail3Textures.Text = "Select Textures";
            this.selectDetail3Textures.UseVisualStyleBackColor = true;
            this.selectDetail3Textures.Click += new System.EventHandler(this.selectDetail3Textures_Click);
            // 
            // detailsLayer3RangeMin
            // 
            this.detailsLayer3RangeMin.DecimalPlaces = 4;
            this.detailsLayer3RangeMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer3RangeMin.Location = new System.Drawing.Point(8, 315);
            this.detailsLayer3RangeMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer3RangeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.detailsLayer3RangeMin.Name = "detailsLayer3RangeMin";
            this.detailsLayer3RangeMin.Size = new System.Drawing.Size(101, 20);
            this.detailsLayer3RangeMin.TabIndex = 77;
            this.detailsLayer3RangeMin.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer3RangeMax
            // 
            this.detailsLayer3RangeMax.DecimalPlaces = 4;
            this.detailsLayer3RangeMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer3RangeMax.Location = new System.Drawing.Point(121, 315);
            this.detailsLayer3RangeMax.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer3RangeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.detailsLayer3RangeMax.Name = "detailsLayer3RangeMax";
            this.detailsLayer3RangeMax.Size = new System.Drawing.Size(100, 20);
            this.detailsLayer3RangeMax.TabIndex = 76;
            this.detailsLayer3RangeMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer3RangeMax.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer3RangeLabel
            // 
            this.detailsLayer3RangeLabel.AutoSize = true;
            this.detailsLayer3RangeLabel.Location = new System.Drawing.Point(5, 299);
            this.detailsLayer3RangeLabel.Name = "detailsLayer3RangeLabel";
            this.detailsLayer3RangeLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLayer3RangeLabel.TabIndex = 75;
            this.detailsLayer3RangeLabel.Text = "Range";
            // 
            // detailsLayer3Checkbox
            // 
            this.detailsLayer3Checkbox.AutoSize = true;
            this.detailsLayer3Checkbox.Location = new System.Drawing.Point(8, 279);
            this.detailsLayer3Checkbox.Name = "detailsLayer3Checkbox";
            this.detailsLayer3Checkbox.Size = new System.Drawing.Size(96, 17);
            this.detailsLayer3Checkbox.TabIndex = 74;
            this.detailsLayer3Checkbox.Text = "Details Layer 3";
            this.detailsLayer3Checkbox.UseVisualStyleBackColor = true;
            this.detailsLayer3Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer2Scale
            // 
            this.detailsLayer2Scale.DecimalPlaces = 4;
            this.detailsLayer2Scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer2Scale.Location = new System.Drawing.Point(8, 230);
            this.detailsLayer2Scale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.detailsLayer2Scale.Name = "detailsLayer2Scale";
            this.detailsLayer2Scale.Size = new System.Drawing.Size(101, 20);
            this.detailsLayer2Scale.TabIndex = 73;
            this.detailsLayer2Scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.detailsLayer2Scale.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer2ScaleLabel
            // 
            this.detailsLayer2ScaleLabel.AutoSize = true;
            this.detailsLayer2ScaleLabel.Location = new System.Drawing.Point(5, 213);
            this.detailsLayer2ScaleLabel.Name = "detailsLayer2ScaleLabel";
            this.detailsLayer2ScaleLabel.Size = new System.Drawing.Size(73, 13);
            this.detailsLayer2ScaleLabel.TabIndex = 72;
            this.detailsLayer2ScaleLabel.Text = "Texture Scale";
            // 
            // selectDetail2Textures
            // 
            this.selectDetail2Textures.Location = new System.Drawing.Point(121, 145);
            this.selectDetail2Textures.Name = "selectDetail2Textures";
            this.selectDetail2Textures.Size = new System.Drawing.Size(100, 23);
            this.selectDetail2Textures.TabIndex = 71;
            this.selectDetail2Textures.Text = "Select Textures";
            this.selectDetail2Textures.UseVisualStyleBackColor = true;
            this.selectDetail2Textures.Click += new System.EventHandler(this.selectDetail2Textures_Click);
            // 
            // detailsLayer2RangeMin
            // 
            this.detailsLayer2RangeMin.DecimalPlaces = 4;
            this.detailsLayer2RangeMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer2RangeMin.Location = new System.Drawing.Point(8, 181);
            this.detailsLayer2RangeMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer2RangeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.detailsLayer2RangeMin.Name = "detailsLayer2RangeMin";
            this.detailsLayer2RangeMin.Size = new System.Drawing.Size(101, 20);
            this.detailsLayer2RangeMin.TabIndex = 70;
            this.detailsLayer2RangeMin.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer2RangeMax
            // 
            this.detailsLayer2RangeMax.DecimalPlaces = 4;
            this.detailsLayer2RangeMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer2RangeMax.Location = new System.Drawing.Point(121, 181);
            this.detailsLayer2RangeMax.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer2RangeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.detailsLayer2RangeMax.Name = "detailsLayer2RangeMax";
            this.detailsLayer2RangeMax.Size = new System.Drawing.Size(100, 20);
            this.detailsLayer2RangeMax.TabIndex = 69;
            this.detailsLayer2RangeMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer2RangeMax.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer2RangeLabel
            // 
            this.detailsLayer2RangeLabel.AutoSize = true;
            this.detailsLayer2RangeLabel.Location = new System.Drawing.Point(5, 165);
            this.detailsLayer2RangeLabel.Name = "detailsLayer2RangeLabel";
            this.detailsLayer2RangeLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLayer2RangeLabel.TabIndex = 68;
            this.detailsLayer2RangeLabel.Text = "Range";
            // 
            // detailsLayer2Checkbox
            // 
            this.detailsLayer2Checkbox.AutoSize = true;
            this.detailsLayer2Checkbox.Location = new System.Drawing.Point(8, 145);
            this.detailsLayer2Checkbox.Name = "detailsLayer2Checkbox";
            this.detailsLayer2Checkbox.Size = new System.Drawing.Size(96, 17);
            this.detailsLayer2Checkbox.TabIndex = 67;
            this.detailsLayer2Checkbox.Text = "Details Layer 2";
            this.detailsLayer2Checkbox.UseVisualStyleBackColor = true;
            this.detailsLayer2Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer1Scale
            // 
            this.detailsLayer1Scale.DecimalPlaces = 4;
            this.detailsLayer1Scale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer1Scale.Location = new System.Drawing.Point(8, 97);
            this.detailsLayer1Scale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.detailsLayer1Scale.Name = "detailsLayer1Scale";
            this.detailsLayer1Scale.Size = new System.Drawing.Size(101, 20);
            this.detailsLayer1Scale.TabIndex = 66;
            this.detailsLayer1Scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.detailsLayer1Scale.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer1ScaleLabel
            // 
            this.detailsLayer1ScaleLabel.AutoSize = true;
            this.detailsLayer1ScaleLabel.Location = new System.Drawing.Point(5, 80);
            this.detailsLayer1ScaleLabel.Name = "detailsLayer1ScaleLabel";
            this.detailsLayer1ScaleLabel.Size = new System.Drawing.Size(73, 13);
            this.detailsLayer1ScaleLabel.TabIndex = 65;
            this.detailsLayer1ScaleLabel.Text = "Texture Scale";
            // 
            // selectDetail1Textures
            // 
            this.selectDetail1Textures.Location = new System.Drawing.Point(121, 12);
            this.selectDetail1Textures.Name = "selectDetail1Textures";
            this.selectDetail1Textures.Size = new System.Drawing.Size(100, 23);
            this.selectDetail1Textures.TabIndex = 61;
            this.selectDetail1Textures.Text = "Select Textures";
            this.selectDetail1Textures.UseVisualStyleBackColor = true;
            this.selectDetail1Textures.Click += new System.EventHandler(this.selectDetail1Textures_Click);
            // 
            // detailsLayer1RangeMin
            // 
            this.detailsLayer1RangeMin.DecimalPlaces = 4;
            this.detailsLayer1RangeMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer1RangeMin.Location = new System.Drawing.Point(8, 48);
            this.detailsLayer1RangeMin.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer1RangeMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.detailsLayer1RangeMin.Name = "detailsLayer1RangeMin";
            this.detailsLayer1RangeMin.Size = new System.Drawing.Size(101, 20);
            this.detailsLayer1RangeMin.TabIndex = 60;
            this.detailsLayer1RangeMin.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer1RangeMax
            // 
            this.detailsLayer1RangeMax.DecimalPlaces = 4;
            this.detailsLayer1RangeMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.detailsLayer1RangeMax.Location = new System.Drawing.Point(121, 48);
            this.detailsLayer1RangeMax.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.detailsLayer1RangeMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.detailsLayer1RangeMax.Name = "detailsLayer1RangeMax";
            this.detailsLayer1RangeMax.Size = new System.Drawing.Size(100, 20);
            this.detailsLayer1RangeMax.TabIndex = 59;
            this.detailsLayer1RangeMax.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.detailsLayer1RangeMax.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // detailsLayer1RangeLabel
            // 
            this.detailsLayer1RangeLabel.AutoSize = true;
            this.detailsLayer1RangeLabel.Location = new System.Drawing.Point(5, 32);
            this.detailsLayer1RangeLabel.Name = "detailsLayer1RangeLabel";
            this.detailsLayer1RangeLabel.Size = new System.Drawing.Size(39, 13);
            this.detailsLayer1RangeLabel.TabIndex = 1;
            this.detailsLayer1RangeLabel.Text = "Range";
            // 
            // detailsLayer1Checkbox
            // 
            this.detailsLayer1Checkbox.AutoSize = true;
            this.detailsLayer1Checkbox.Checked = true;
            this.detailsLayer1Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.detailsLayer1Checkbox.Location = new System.Drawing.Point(8, 12);
            this.detailsLayer1Checkbox.Name = "detailsLayer1Checkbox";
            this.detailsLayer1Checkbox.Size = new System.Drawing.Size(96, 17);
            this.detailsLayer1Checkbox.TabIndex = 0;
            this.detailsLayer1Checkbox.Text = "Details Layer 1";
            this.detailsLayer1Checkbox.UseVisualStyleBackColor = true;
            this.detailsLayer1Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // lightingTab
            // 
            this.lightingTab.Controls.Add(this.normalStrength);
            this.lightingTab.Controls.Add(this.normalStrengthLabel);
            this.lightingTab.Controls.Add(this.light2Intensity);
            this.lightingTab.Controls.Add(this.light2IntensityLabel);
            this.lightingTab.Controls.Add(this.light1Intensity);
            this.lightingTab.Controls.Add(this.light1IntensityLabel);
            this.lightingTab.Controls.Add(this.light2Checkbox);
            this.lightingTab.Controls.Add(this.light2AmbientColorLabel);
            this.lightingTab.Controls.Add(this.light2AmbientColorPicture);
            this.lightingTab.Controls.Add(this.light2PositionZ);
            this.lightingTab.Controls.Add(this.light2PositionZLabel);
            this.lightingTab.Controls.Add(this.light2PositionY);
            this.lightingTab.Controls.Add(this.light2PositionYLabel);
            this.lightingTab.Controls.Add(this.light2PositionX);
            this.lightingTab.Controls.Add(this.light2PositionXLabel);
            this.lightingTab.Controls.Add(this.light2PositionLabel);
            this.lightingTab.Controls.Add(this.light2ColorLabel);
            this.lightingTab.Controls.Add(this.light2ColorPicture);
            this.lightingTab.Controls.Add(this.light1AmbientColorLabel);
            this.lightingTab.Controls.Add(this.light1AmbientColorPicture);
            this.lightingTab.Controls.Add(this.light1PositionZ);
            this.lightingTab.Controls.Add(this.light1PositionZLabel);
            this.lightingTab.Controls.Add(this.light1PositionY);
            this.lightingTab.Controls.Add(this.light1PositionYLabel);
            this.lightingTab.Controls.Add(this.light1PositionX);
            this.lightingTab.Controls.Add(this.light1PositionXLabel);
            this.lightingTab.Controls.Add(this.light1Position);
            this.lightingTab.Controls.Add(this.light1ColorLabel);
            this.lightingTab.Controls.Add(this.light1ColorPicture);
            this.lightingTab.Controls.Add(this.light1Checkbox);
            this.lightingTab.Location = new System.Drawing.Point(4, 49);
            this.lightingTab.Name = "lightingTab";
            this.lightingTab.Size = new System.Drawing.Size(250, 464);
            this.lightingTab.TabIndex = 5;
            this.lightingTab.Text = "Lighting";
            this.lightingTab.UseVisualStyleBackColor = true;
            // 
            // normalStrength
            // 
            this.normalStrength.Location = new System.Drawing.Point(8, 26);
            this.normalStrength.Name = "normalStrength";
            this.normalStrength.Size = new System.Drawing.Size(101, 20);
            this.normalStrength.TabIndex = 83;
            this.normalStrength.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // normalStrengthLabel
            // 
            this.normalStrengthLabel.AutoSize = true;
            this.normalStrengthLabel.Location = new System.Drawing.Point(5, 9);
            this.normalStrengthLabel.Name = "normalStrengthLabel";
            this.normalStrengthLabel.Size = new System.Drawing.Size(83, 13);
            this.normalStrengthLabel.TabIndex = 82;
            this.normalStrengthLabel.Text = "Normal Strength";
            // 
            // light2Intensity
            // 
            this.light2Intensity.DecimalPlaces = 4;
            this.light2Intensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.light2Intensity.Location = new System.Drawing.Point(10, 426);
            this.light2Intensity.Name = "light2Intensity";
            this.light2Intensity.Size = new System.Drawing.Size(100, 20);
            this.light2Intensity.TabIndex = 81;
            this.light2Intensity.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.light2Intensity.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light2IntensityLabel
            // 
            this.light2IntensityLabel.AutoSize = true;
            this.light2IntensityLabel.Location = new System.Drawing.Point(6, 410);
            this.light2IntensityLabel.Name = "light2IntensityLabel";
            this.light2IntensityLabel.Size = new System.Drawing.Size(46, 13);
            this.light2IntensityLabel.TabIndex = 80;
            this.light2IntensityLabel.Text = "Intensity";
            // 
            // light1Intensity
            // 
            this.light1Intensity.DecimalPlaces = 4;
            this.light1Intensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.light1Intensity.Location = new System.Drawing.Point(9, 225);
            this.light1Intensity.Name = "light1Intensity";
            this.light1Intensity.Size = new System.Drawing.Size(100, 20);
            this.light1Intensity.TabIndex = 79;
            this.light1Intensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.light1Intensity.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light1IntensityLabel
            // 
            this.light1IntensityLabel.AutoSize = true;
            this.light1IntensityLabel.Location = new System.Drawing.Point(5, 209);
            this.light1IntensityLabel.Name = "light1IntensityLabel";
            this.light1IntensityLabel.Size = new System.Drawing.Size(46, 13);
            this.light1IntensityLabel.TabIndex = 78;
            this.light1IntensityLabel.Text = "Intensity";
            // 
            // light2Checkbox
            // 
            this.light2Checkbox.AutoSize = true;
            this.light2Checkbox.Checked = true;
            this.light2Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.light2Checkbox.Location = new System.Drawing.Point(8, 278);
            this.light2Checkbox.Name = "light2Checkbox";
            this.light2Checkbox.Size = new System.Drawing.Size(94, 17);
            this.light2Checkbox.TabIndex = 77;
            this.light2Checkbox.Text = "Enable Light 2";
            this.light2Checkbox.UseVisualStyleBackColor = true;
            this.light2Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light2AmbientColorLabel
            // 
            this.light2AmbientColorLabel.AutoSize = true;
            this.light2AmbientColorLabel.Location = new System.Drawing.Point(5, 359);
            this.light2AmbientColorLabel.Name = "light2AmbientColorLabel";
            this.light2AmbientColorLabel.Size = new System.Drawing.Size(72, 13);
            this.light2AmbientColorLabel.TabIndex = 76;
            this.light2AmbientColorLabel.Text = "Ambient Color";
            // 
            // light2AmbientColorPicture
            // 
            this.light2AmbientColorPicture.Location = new System.Drawing.Point(9, 378);
            this.light2AmbientColorPicture.Name = "light2AmbientColorPicture";
            this.light2AmbientColorPicture.Size = new System.Drawing.Size(64, 20);
            this.light2AmbientColorPicture.TabIndex = 75;
            this.light2AmbientColorPicture.TabStop = false;
            this.light2AmbientColorPicture.Click += new System.EventHandler(this.light2AmbientColorPicture_Click);
            // 
            // light2PositionZ
            // 
            this.light2PositionZ.DecimalPlaces = 4;
            this.light2PositionZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.light2PositionZ.Location = new System.Drawing.Point(121, 378);
            this.light2PositionZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.light2PositionZ.Name = "light2PositionZ";
            this.light2PositionZ.Size = new System.Drawing.Size(100, 20);
            this.light2PositionZ.TabIndex = 74;
            this.light2PositionZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.light2PositionZ.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light2PositionZLabel
            // 
            this.light2PositionZLabel.AutoSize = true;
            this.light2PositionZLabel.Location = new System.Drawing.Point(101, 380);
            this.light2PositionZLabel.Name = "light2PositionZLabel";
            this.light2PositionZLabel.Size = new System.Drawing.Size(14, 13);
            this.light2PositionZLabel.TabIndex = 73;
            this.light2PositionZLabel.Text = "Z";
            // 
            // light2PositionY
            // 
            this.light2PositionY.DecimalPlaces = 4;
            this.light2PositionY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.light2PositionY.Location = new System.Drawing.Point(121, 352);
            this.light2PositionY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.light2PositionY.Name = "light2PositionY";
            this.light2PositionY.Size = new System.Drawing.Size(100, 20);
            this.light2PositionY.TabIndex = 72;
            this.light2PositionY.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            this.light2PositionY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light2PositionYLabel
            // 
            this.light2PositionYLabel.AutoSize = true;
            this.light2PositionYLabel.Location = new System.Drawing.Point(101, 354);
            this.light2PositionYLabel.Name = "light2PositionYLabel";
            this.light2PositionYLabel.Size = new System.Drawing.Size(14, 13);
            this.light2PositionYLabel.TabIndex = 71;
            this.light2PositionYLabel.Text = "Y";
            // 
            // light2PositionX
            // 
            this.light2PositionX.DecimalPlaces = 4;
            this.light2PositionX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.light2PositionX.Location = new System.Drawing.Point(121, 326);
            this.light2PositionX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.light2PositionX.Name = "light2PositionX";
            this.light2PositionX.Size = new System.Drawing.Size(100, 20);
            this.light2PositionX.TabIndex = 70;
            this.light2PositionX.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147418112});
            this.light2PositionX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light2PositionXLabel
            // 
            this.light2PositionXLabel.AutoSize = true;
            this.light2PositionXLabel.Location = new System.Drawing.Point(101, 328);
            this.light2PositionXLabel.Name = "light2PositionXLabel";
            this.light2PositionXLabel.Size = new System.Drawing.Size(14, 13);
            this.light2PositionXLabel.TabIndex = 69;
            this.light2PositionXLabel.Text = "X";
            // 
            // light2PositionLabel
            // 
            this.light2PositionLabel.AutoSize = true;
            this.light2PositionLabel.Location = new System.Drawing.Point(90, 307);
            this.light2PositionLabel.Name = "light2PositionLabel";
            this.light2PositionLabel.Size = new System.Drawing.Size(70, 13);
            this.light2PositionLabel.TabIndex = 68;
            this.light2PositionLabel.Text = "Light Position";
            // 
            // light2ColorLabel
            // 
            this.light2ColorLabel.AutoSize = true;
            this.light2ColorLabel.Location = new System.Drawing.Point(5, 307);
            this.light2ColorLabel.Name = "light2ColorLabel";
            this.light2ColorLabel.Size = new System.Drawing.Size(57, 13);
            this.light2ColorLabel.TabIndex = 67;
            this.light2ColorLabel.Text = "Light Color";
            // 
            // light2ColorPicture
            // 
            this.light2ColorPicture.Location = new System.Drawing.Point(9, 326);
            this.light2ColorPicture.Name = "light2ColorPicture";
            this.light2ColorPicture.Size = new System.Drawing.Size(64, 20);
            this.light2ColorPicture.TabIndex = 66;
            this.light2ColorPicture.TabStop = false;
            this.light2ColorPicture.Click += new System.EventHandler(this.light2ColorPicture_Click);
            // 
            // light1AmbientColorLabel
            // 
            this.light1AmbientColorLabel.AutoSize = true;
            this.light1AmbientColorLabel.Location = new System.Drawing.Point(5, 157);
            this.light1AmbientColorLabel.Name = "light1AmbientColorLabel";
            this.light1AmbientColorLabel.Size = new System.Drawing.Size(72, 13);
            this.light1AmbientColorLabel.TabIndex = 65;
            this.light1AmbientColorLabel.Text = "Ambient Color";
            // 
            // light1AmbientColorPicture
            // 
            this.light1AmbientColorPicture.Location = new System.Drawing.Point(9, 176);
            this.light1AmbientColorPicture.Name = "light1AmbientColorPicture";
            this.light1AmbientColorPicture.Size = new System.Drawing.Size(64, 20);
            this.light1AmbientColorPicture.TabIndex = 64;
            this.light1AmbientColorPicture.TabStop = false;
            this.light1AmbientColorPicture.Click += new System.EventHandler(this.lightAmbientColorPicture_Click);
            // 
            // light1PositionZ
            // 
            this.light1PositionZ.DecimalPlaces = 4;
            this.light1PositionZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.light1PositionZ.Location = new System.Drawing.Point(121, 176);
            this.light1PositionZ.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.light1PositionZ.Name = "light1PositionZ";
            this.light1PositionZ.Size = new System.Drawing.Size(100, 20);
            this.light1PositionZ.TabIndex = 63;
            this.light1PositionZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.light1PositionZ.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light1PositionZLabel
            // 
            this.light1PositionZLabel.AutoSize = true;
            this.light1PositionZLabel.Location = new System.Drawing.Point(101, 178);
            this.light1PositionZLabel.Name = "light1PositionZLabel";
            this.light1PositionZLabel.Size = new System.Drawing.Size(14, 13);
            this.light1PositionZLabel.TabIndex = 62;
            this.light1PositionZLabel.Text = "Z";
            // 
            // light1PositionY
            // 
            this.light1PositionY.DecimalPlaces = 4;
            this.light1PositionY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.light1PositionY.Location = new System.Drawing.Point(121, 150);
            this.light1PositionY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.light1PositionY.Name = "light1PositionY";
            this.light1PositionY.Size = new System.Drawing.Size(100, 20);
            this.light1PositionY.TabIndex = 61;
            this.light1PositionY.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.light1PositionY.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light1PositionYLabel
            // 
            this.light1PositionYLabel.AutoSize = true;
            this.light1PositionYLabel.Location = new System.Drawing.Point(101, 152);
            this.light1PositionYLabel.Name = "light1PositionYLabel";
            this.light1PositionYLabel.Size = new System.Drawing.Size(14, 13);
            this.light1PositionYLabel.TabIndex = 60;
            this.light1PositionYLabel.Text = "Y";
            // 
            // light1PositionX
            // 
            this.light1PositionX.DecimalPlaces = 4;
            this.light1PositionX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.light1PositionX.Location = new System.Drawing.Point(121, 124);
            this.light1PositionX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.light1PositionX.Name = "light1PositionX";
            this.light1PositionX.Size = new System.Drawing.Size(100, 20);
            this.light1PositionX.TabIndex = 59;
            this.light1PositionX.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.light1PositionX.ValueChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // light1PositionXLabel
            // 
            this.light1PositionXLabel.AutoSize = true;
            this.light1PositionXLabel.Location = new System.Drawing.Point(101, 126);
            this.light1PositionXLabel.Name = "light1PositionXLabel";
            this.light1PositionXLabel.Size = new System.Drawing.Size(14, 13);
            this.light1PositionXLabel.TabIndex = 4;
            this.light1PositionXLabel.Text = "X";
            // 
            // light1Position
            // 
            this.light1Position.AutoSize = true;
            this.light1Position.Location = new System.Drawing.Point(90, 105);
            this.light1Position.Name = "light1Position";
            this.light1Position.Size = new System.Drawing.Size(70, 13);
            this.light1Position.TabIndex = 3;
            this.light1Position.Text = "Light Position";
            // 
            // light1ColorLabel
            // 
            this.light1ColorLabel.AutoSize = true;
            this.light1ColorLabel.Location = new System.Drawing.Point(5, 105);
            this.light1ColorLabel.Name = "light1ColorLabel";
            this.light1ColorLabel.Size = new System.Drawing.Size(57, 13);
            this.light1ColorLabel.TabIndex = 2;
            this.light1ColorLabel.Text = "Light Color";
            // 
            // light1ColorPicture
            // 
            this.light1ColorPicture.Location = new System.Drawing.Point(9, 124);
            this.light1ColorPicture.Name = "light1ColorPicture";
            this.light1ColorPicture.Size = new System.Drawing.Size(64, 20);
            this.light1ColorPicture.TabIndex = 1;
            this.light1ColorPicture.TabStop = false;
            this.light1ColorPicture.Click += new System.EventHandler(this.lightColorPicture_Click);
            // 
            // light1Checkbox
            // 
            this.light1Checkbox.AutoSize = true;
            this.light1Checkbox.Checked = true;
            this.light1Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.light1Checkbox.Location = new System.Drawing.Point(8, 76);
            this.light1Checkbox.Name = "light1Checkbox";
            this.light1Checkbox.Size = new System.Drawing.Size(94, 17);
            this.light1Checkbox.TabIndex = 0;
            this.light1Checkbox.Text = "Enable Light 1";
            this.light1Checkbox.UseVisualStyleBackColor = true;
            this.light1Checkbox.CheckedChanged += new System.EventHandler(this.mapOptionsChanged);
            // 
            // renderTab
            // 
            this.renderTab.Controls.Add(this.renderHeight);
            this.renderTab.Controls.Add(this.renderWidth);
            this.renderTab.Controls.Add(this.widthLabel);
            this.renderTab.Controls.Add(this.heightLabel);
            this.renderTab.Location = new System.Drawing.Point(4, 49);
            this.renderTab.Name = "renderTab";
            this.renderTab.Padding = new System.Windows.Forms.Padding(3);
            this.renderTab.Size = new System.Drawing.Size(250, 464);
            this.renderTab.TabIndex = 0;
            this.renderTab.Text = "Render";
            this.renderTab.UseVisualStyleBackColor = true;
            // 
            // renderHeight
            // 
            this.renderHeight.Location = new System.Drawing.Point(120, 28);
            this.renderHeight.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.renderHeight.Name = "renderHeight";
            this.renderHeight.Size = new System.Drawing.Size(101, 20);
            this.renderHeight.TabIndex = 58;
            this.renderHeight.Value = new decimal(new int[] {
            1050,
            0,
            0,
            0});
            // 
            // renderWidth
            // 
            this.renderWidth.Location = new System.Drawing.Point(11, 28);
            this.renderWidth.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.renderWidth.Name = "renderWidth";
            this.renderWidth.Size = new System.Drawing.Size(101, 20);
            this.renderWidth.TabIndex = 57;
            this.renderWidth.Value = new decimal(new int[] {
            1680,
            0,
            0,
            0});
            // 
            // fileExit
            // 
            this.fileExit.Index = 3;
            this.fileExit.Text = "Exit";
            this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3,
            this.menuItem11,
            this.fileExit});
            this.menuItem1.Text = "File";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4,
            this.menuItem9,
            this.menuItem5,
            this.menuItem7,
            this.menuItem8});
            this.menuItem2.Text = "Save";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Text = "Map";
            this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 1;
            this.menuItem9.Text = "-";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Layers";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "Composite";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 4;
            this.menuItem8.Text = "Batch";
            this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem10});
            this.menuItem3.Text = "Load";
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 0;
            this.menuItem10.Text = "Map";
            this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.Text = "-";
            // 
            // renderGenerateMap
            // 
            this.renderGenerateMap.Index = 0;
            this.renderGenerateMap.Text = "Generate Map";
            this.renderGenerateMap.Click += new System.EventHandler(this.renderGenerateMap_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 1;
            this.menuItem6.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.renderGenerateMap});
            this.menuItem6.Text = "Render";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem6});
            // 
            // MapGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.mainOptionsControl);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.surface);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "MapGeneratorForm";
            this.Text = "Map Generator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapGeneratorForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MapGeneratorForm_KeyUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MapGeneratorForm_MouseWheel);
            ((System.ComponentModel.ISupportInitialize)(this.surface)).EndInit();
            this.mainOptionsControl.ResumeLayout(false);
            this.noiseTab.ResumeLayout(false);
            this.noiseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseHighColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLowColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLacunarity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTextureHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseTextureWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisePositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noisePositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseScale)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fbm3OffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm3OffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm3Opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm2OffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm2OffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm2Opacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm1OffsetY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm1OffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fbm1Opacity)).EndInit();
            this.waterTab.ResumeLayout(false);
            this.waterTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterDeepColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterShallowColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterLevel)).EndInit();
            this.floraTab.ResumeLayout(false);
            this.floraTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flora2PlantColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2GroundColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2RangeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora2RangeY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1PlantColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1GroundColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1Frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1RangeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flora1RangeY)).EndInit();
            this.detailsTab.ResumeLayout(false);
            this.detailsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer3Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer3RangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer3RangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer2Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer2RangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer2RangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer1Scale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer1RangeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsLayer1RangeMax)).EndInit();
            this.lightingTab.ResumeLayout(false);
            this.lightingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.normalStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2Intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1Intensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2AmbientColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2PositionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2PositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2PositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light2ColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1AmbientColorPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1PositionZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1PositionY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1PositionX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light1ColorPicture)).EndInit();
            this.renderTab.ResumeLayout(false);
            this.renderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renderHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.renderWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox surface;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label randomTextureDimensionsLabel;
        private TabControl mainOptionsControl;
        private TabPage renderTab;
        private TabPage noiseTab;
        private Label scaleLabel;
        private TabPage waterTab;
        private Label frequencyLabel;
        private Label lacunarityLabel;
        private Label gainLabel;
        private Label waterLevelLabel;
        private Label brightnessLabel;
        private CheckBox fbm1Checkbox;
        private Label positionLabel;
        private TabPage floraTab;
        private Label fbm1OffsetLabel;
        private NumericUpDown fbm1OffsetY;
        private NumericUpDown fbm1OffsetX;
        private RadioButton fbm1PositionAndNoise;
        private RadioButton fbm1NoiseOnly;
        private NumericUpDown fbm1Opacity;
        private Label fbm2OffsetLabel;
        private NumericUpDown fbm2OffsetY;
        private NumericUpDown fbm2OffsetX;
        private NumericUpDown fbm2Opacity;
        private CheckBox fbm2Checkbox;
        private Label fbm3OffsetLabel;
        private NumericUpDown fbm3OffsetY;
        private NumericUpDown fbm3OffsetX;
        private NumericUpDown fbm3Opacity;
        private CheckBox fbm3Checkbox;
        private Panel panel1;
        private Panel panel3;
        private RadioButton fbm3PositionAndNoise;
        private RadioButton fbm3NoiseOnly;
        private Panel panel2;
        private RadioButton fbm2PositionAndNoise;
        private RadioButton fbm2NoiseOnly;
        private NumericUpDown noiseBrightness;
        private NumericUpDown noiseLacunarity;
        private NumericUpDown noiseGain;
        private NumericUpDown noiseFrequency;
        private NumericUpDown noiseTextureHeight;
        private NumericUpDown noiseTextureWidth;
        private NumericUpDown noisePositionY;
        private NumericUpDown noisePositionX;
        private NumericUpDown noiseSeed;
        private NumericUpDown noiseScale;
        private NumericUpDown renderHeight;
        private NumericUpDown renderWidth;
        private NumericUpDown waterLevel;
        private NumericUpDown flora1Frequency;
        private NumericUpDown flora1RangeX;
        private NumericUpDown flora1RangeY;
        private Label flora1FrequencyLabel;
        private Label flora1RangeLabel;
        private CheckBox flora1Checkbox;
        private Button flora1SelectTexture;
        private NumericUpDown flora1Scale;
        private Label flora1ScaleLabel;
        private TabPage detailsTab;
        private NumericUpDown detailsLayer1RangeMin;
        private NumericUpDown detailsLayer1RangeMax;
        private Label detailsLayer1RangeLabel;
        private CheckBox detailsLayer1Checkbox;
        private Button selectDetail1Textures;
        private NumericUpDown detailsLayer1Scale;
        private Label detailsLayer1ScaleLabel;
        private NumericUpDown detailsLayer2Scale;
        private Label detailsLayer2ScaleLabel;
        private Button selectDetail2Textures;
        private NumericUpDown detailsLayer2RangeMin;
        private NumericUpDown detailsLayer2RangeMax;
        private Label detailsLayer2RangeLabel;
        private CheckBox detailsLayer2Checkbox;
        private NumericUpDown detailsLayer3Scale;
        private Label detailsLayer3ScaleLabel;
        private Button selectDetail3Textures;
        private NumericUpDown detailsLayer3RangeMin;
        private NumericUpDown detailsLayer3RangeMax;
        private Label detailsLayer3RangeLabel;
        private CheckBox detailsLayer3Checkbox;
        private CheckBox waterCheckbox;
        private PictureBox flora1GroundColorPicture;
        private PictureBox waterShallowColorPicture;
        private Label waterShallowColorLabel;
        private Label flora1GroundColorLabel;
        private CheckBox flora1ShowGroundColor;
        private Label noiseHighColorLabel;
        private PictureBox noiseHighColorPicture;
        private Label noiseLowColorLabel;
        private PictureBox noiseLowColorPicture;
        private CheckBox flora1ShowPlantColor;
        private Label flora1PlantColorLabel;
        private PictureBox flora1PlantColorPicture;
        private Label waterDeepColorLabel;
        private PictureBox waterDeepColorPicture;
        private CheckBox flora2ShowPlantColor;
        private Label flora2PlantColorLabel;
        private PictureBox flora2PlantColorPicture;
        private CheckBox flora2ShowGroundColor;
        private Label flora2GroundColorLabel;
        private PictureBox flora2GroundColorPicture;
        private NumericUpDown flora2Scale;
        private Label flora2ScaleLabel;
        private Button flora2SelectTexture;
        private NumericUpDown flora2Frequency;
        private NumericUpDown flora2RangeX;
        private NumericUpDown flora2RangeY;
        private Label flora2FrequencyLabel;
        private Label flora2RangeLabel;
        private CheckBox flora2Checkbox;
        private TabPage lightingTab;
        private Label light1ColorLabel;
        private PictureBox light1ColorPicture;
        private CheckBox light1Checkbox;
        private NumericUpDown light1PositionZ;
        private Label light1PositionZLabel;
        private NumericUpDown light1PositionY;
        private Label light1PositionYLabel;
        private NumericUpDown light1PositionX;
        private Label light1PositionXLabel;
        private Label light1Position;
        private CheckBox worleyCheckbox;
        private Label light1AmbientColorLabel;
        private PictureBox light1AmbientColorPicture;
        private Label light2AmbientColorLabel;
        private PictureBox light2AmbientColorPicture;
        private NumericUpDown light2PositionZ;
        private Label light2PositionZLabel;
        private NumericUpDown light2PositionY;
        private Label light2PositionYLabel;
        private NumericUpDown light2PositionX;
        private Label light2PositionXLabel;
        private Label light2PositionLabel;
        private Label light2ColorLabel;
        private PictureBox light2ColorPicture;
        private CheckBox light2Checkbox;
        private NumericUpDown light2Intensity;
        private Label light2IntensityLabel;
        private NumericUpDown light1Intensity;
        private Label light1IntensityLabel;
        private MenuItem fileExit;
        private MenuItem menuItem1;
        private MenuItem renderGenerateMap;
        private MenuItem menuItem6;
        private MainMenu mainMenu1;
        private NumericUpDown normalStrength;
        private Label normalStrengthLabel;
        private MenuItem menuItem2;
        private MenuItem menuItem3;
        private MenuItem menuItem4;
        private MenuItem menuItem5;
        private MenuItem menuItem7;
        private MenuItem menuItem9;
        private MenuItem menuItem8;
        private MenuItem menuItem10;
        private MenuItem menuItem11;
    }
}