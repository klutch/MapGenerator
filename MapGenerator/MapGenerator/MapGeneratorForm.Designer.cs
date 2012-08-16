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
            this.surface = new System.Windows.Forms.PictureBox();
            this.randomSeedBox = new System.Windows.Forms.TextBox();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.randomTextureDimensionsLabel = new System.Windows.Forms.Label();
            this.randomTextureWidthBox = new System.Windows.Forms.TextBox();
            this.randomTextureHeightBox = new System.Windows.Forms.TextBox();
            this.mainOptionsControl = new System.Windows.Forms.TabControl();
            this.outputTab = new System.Windows.Forms.TabPage();
            this.noiseTab = new System.Windows.Forms.TabPage();
            this.positionYBox = new System.Windows.Forms.TextBox();
            this.positionXBox = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.fbm3DivisorLabel = new System.Windows.Forms.Label();
            this.fbm3DivisorBox = new System.Windows.Forms.TextBox();
            this.fbm3Checkbox = new System.Windows.Forms.CheckBox();
            this.fbm2DivisorLabel = new System.Windows.Forms.Label();
            this.fbm2DivisorBox = new System.Windows.Forms.TextBox();
            this.fbm2Checkbox = new System.Windows.Forms.CheckBox();
            this.fbmDivisorLabel = new System.Windows.Forms.Label();
            this.fbm1DivisorBox = new System.Windows.Forms.TextBox();
            this.fbm1Checkbox = new System.Windows.Forms.CheckBox();
            this.brightnessMultiplierBox = new System.Windows.Forms.TextBox();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.noiseLacunarityBox = new System.Windows.Forms.TextBox();
            this.lacunarityLabel = new System.Windows.Forms.Label();
            this.noiseGainBox = new System.Windows.Forms.TextBox();
            this.gainLabel = new System.Windows.Forms.Label();
            this.noiseFrequencyBox = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.scaleBox = new System.Windows.Forms.TextBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.waterTab = new System.Windows.Forms.TabPage();
            this.waterLevelBox = new System.Windows.Forms.TextBox();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.floraTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.surface)).BeginInit();
            this.mainOptionsControl.SuspendLayout();
            this.outputTab.SuspendLayout();
            this.noiseTab.SuspendLayout();
            this.waterTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(246, 0);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(680, 561);
            this.surface.TabIndex = 0;
            this.surface.TabStop = false;
            this.surface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.surface_MouseMove);
            // 
            // randomSeedBox
            // 
            this.randomSeedBox.Location = new System.Drawing.Point(9, 29);
            this.randomSeedBox.Name = "randomSeedBox";
            this.randomSeedBox.Size = new System.Drawing.Size(100, 20);
            this.randomSeedBox.TabIndex = 3;
            this.randomSeedBox.Text = "123456";
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
            this.generateButton.Location = new System.Drawing.Point(12, 526);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
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
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(8, 29);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 1;
            this.widthBox.Text = "1680";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(120, 29);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 2;
            this.heightBox.Text = "1050";
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
            // randomTextureWidthBox
            // 
            this.randomTextureWidthBox.Location = new System.Drawing.Point(9, 127);
            this.randomTextureWidthBox.Name = "randomTextureWidthBox";
            this.randomTextureWidthBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureWidthBox.TabIndex = 4;
            this.randomTextureWidthBox.Text = "32";
            // 
            // randomTextureHeightBox
            // 
            this.randomTextureHeightBox.Location = new System.Drawing.Point(121, 126);
            this.randomTextureHeightBox.Name = "randomTextureHeightBox";
            this.randomTextureHeightBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureHeightBox.TabIndex = 5;
            this.randomTextureHeightBox.Text = "32";
            // 
            // mainOptionsControl
            // 
            this.mainOptionsControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainOptionsControl.Controls.Add(this.outputTab);
            this.mainOptionsControl.Controls.Add(this.noiseTab);
            this.mainOptionsControl.Controls.Add(this.waterTab);
            this.mainOptionsControl.Controls.Add(this.floraTab);
            this.mainOptionsControl.Location = new System.Drawing.Point(0, 0);
            this.mainOptionsControl.Name = "mainOptionsControl";
            this.mainOptionsControl.SelectedIndex = 0;
            this.mainOptionsControl.Size = new System.Drawing.Size(246, 517);
            this.mainOptionsControl.TabIndex = 11;
            // 
            // outputTab
            // 
            this.outputTab.Controls.Add(this.widthLabel);
            this.outputTab.Controls.Add(this.heightLabel);
            this.outputTab.Controls.Add(this.widthBox);
            this.outputTab.Controls.Add(this.heightBox);
            this.outputTab.Location = new System.Drawing.Point(4, 25);
            this.outputTab.Name = "outputTab";
            this.outputTab.Padding = new System.Windows.Forms.Padding(3);
            this.outputTab.Size = new System.Drawing.Size(232, 488);
            this.outputTab.TabIndex = 0;
            this.outputTab.Text = "Output";
            this.outputTab.UseVisualStyleBackColor = true;
            // 
            // noiseTab
            // 
            this.noiseTab.AutoScroll = true;
            this.noiseTab.Controls.Add(this.positionYBox);
            this.noiseTab.Controls.Add(this.positionXBox);
            this.noiseTab.Controls.Add(this.positionLabel);
            this.noiseTab.Controls.Add(this.fbm3DivisorLabel);
            this.noiseTab.Controls.Add(this.fbm3DivisorBox);
            this.noiseTab.Controls.Add(this.fbm3Checkbox);
            this.noiseTab.Controls.Add(this.fbm2DivisorLabel);
            this.noiseTab.Controls.Add(this.fbm2DivisorBox);
            this.noiseTab.Controls.Add(this.fbm2Checkbox);
            this.noiseTab.Controls.Add(this.fbmDivisorLabel);
            this.noiseTab.Controls.Add(this.fbm1DivisorBox);
            this.noiseTab.Controls.Add(this.fbm1Checkbox);
            this.noiseTab.Controls.Add(this.brightnessMultiplierBox);
            this.noiseTab.Controls.Add(this.brightnessLabel);
            this.noiseTab.Controls.Add(this.noiseLacunarityBox);
            this.noiseTab.Controls.Add(this.lacunarityLabel);
            this.noiseTab.Controls.Add(this.noiseGainBox);
            this.noiseTab.Controls.Add(this.gainLabel);
            this.noiseTab.Controls.Add(this.noiseFrequencyBox);
            this.noiseTab.Controls.Add(this.frequencyLabel);
            this.noiseTab.Controls.Add(this.scaleBox);
            this.noiseTab.Controls.Add(this.scaleLabel);
            this.noiseTab.Controls.Add(this.randomTextureHeightBox);
            this.noiseTab.Controls.Add(this.randomSeedLabel);
            this.noiseTab.Controls.Add(this.randomTextureDimensionsLabel);
            this.noiseTab.Controls.Add(this.randomSeedBox);
            this.noiseTab.Controls.Add(this.randomTextureWidthBox);
            this.noiseTab.Location = new System.Drawing.Point(4, 25);
            this.noiseTab.Name = "noiseTab";
            this.noiseTab.Padding = new System.Windows.Forms.Padding(3);
            this.noiseTab.Size = new System.Drawing.Size(238, 488);
            this.noiseTab.TabIndex = 1;
            this.noiseTab.Text = "Noise";
            this.noiseTab.UseVisualStyleBackColor = true;
            // 
            // positionYBox
            // 
            this.positionYBox.Location = new System.Drawing.Point(121, 78);
            this.positionYBox.Name = "positionYBox";
            this.positionYBox.Size = new System.Drawing.Size(100, 20);
            this.positionYBox.TabIndex = 30;
            this.positionYBox.Text = "0.0000";
            // 
            // positionXBox
            // 
            this.positionXBox.Location = new System.Drawing.Point(9, 78);
            this.positionXBox.Name = "positionXBox";
            this.positionXBox.Size = new System.Drawing.Size(100, 20);
            this.positionXBox.TabIndex = 29;
            this.positionXBox.Text = "0.0000";
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
            // fbm3DivisorLabel
            // 
            this.fbm3DivisorLabel.AutoSize = true;
            this.fbm3DivisorLabel.Location = new System.Drawing.Point(70, 403);
            this.fbm3DivisorLabel.Name = "fbm3DivisorLabel";
            this.fbm3DivisorLabel.Size = new System.Drawing.Size(39, 13);
            this.fbm3DivisorLabel.TabIndex = 27;
            this.fbm3DivisorLabel.Text = "Divisor";
            // 
            // fbm3DivisorBox
            // 
            this.fbm3DivisorBox.Location = new System.Drawing.Point(121, 400);
            this.fbm3DivisorBox.Name = "fbm3DivisorBox";
            this.fbm3DivisorBox.Size = new System.Drawing.Size(100, 20);
            this.fbm3DivisorBox.TabIndex = 26;
            this.fbm3DivisorBox.Text = "8.00";
            // 
            // fbm3Checkbox
            // 
            this.fbm3Checkbox.AutoSize = true;
            this.fbm3Checkbox.Location = new System.Drawing.Point(9, 377);
            this.fbm3Checkbox.Name = "fbm3Checkbox";
            this.fbm3Checkbox.Size = new System.Drawing.Size(146, 17);
            this.fbm3Checkbox.TabIndex = 25;
            this.fbm3Checkbox.Text = "Enable Fractional Layer 3";
            this.fbm3Checkbox.UseVisualStyleBackColor = true;
            this.fbm3Checkbox.CheckedChanged += new System.EventHandler(this.fbm3Checkbox_CheckedChanged);
            // 
            // fbm2DivisorLabel
            // 
            this.fbm2DivisorLabel.AutoSize = true;
            this.fbm2DivisorLabel.Location = new System.Drawing.Point(70, 345);
            this.fbm2DivisorLabel.Name = "fbm2DivisorLabel";
            this.fbm2DivisorLabel.Size = new System.Drawing.Size(39, 13);
            this.fbm2DivisorLabel.TabIndex = 24;
            this.fbm2DivisorLabel.Text = "Divisor";
            // 
            // fbm2DivisorBox
            // 
            this.fbm2DivisorBox.Location = new System.Drawing.Point(121, 342);
            this.fbm2DivisorBox.Name = "fbm2DivisorBox";
            this.fbm2DivisorBox.Size = new System.Drawing.Size(100, 20);
            this.fbm2DivisorBox.TabIndex = 23;
            this.fbm2DivisorBox.Text = "4.00";
            // 
            // fbm2Checkbox
            // 
            this.fbm2Checkbox.AutoSize = true;
            this.fbm2Checkbox.Checked = true;
            this.fbm2Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fbm2Checkbox.Location = new System.Drawing.Point(9, 319);
            this.fbm2Checkbox.Name = "fbm2Checkbox";
            this.fbm2Checkbox.Size = new System.Drawing.Size(146, 17);
            this.fbm2Checkbox.TabIndex = 22;
            this.fbm2Checkbox.Text = "Enable Fractional Layer 2";
            this.fbm2Checkbox.UseVisualStyleBackColor = true;
            this.fbm2Checkbox.CheckedChanged += new System.EventHandler(this.fbm2Checkbox_CheckedChanged);
            // 
            // fbmDivisorLabel
            // 
            this.fbmDivisorLabel.AutoSize = true;
            this.fbmDivisorLabel.Location = new System.Drawing.Point(70, 287);
            this.fbmDivisorLabel.Name = "fbmDivisorLabel";
            this.fbmDivisorLabel.Size = new System.Drawing.Size(39, 13);
            this.fbmDivisorLabel.TabIndex = 21;
            this.fbmDivisorLabel.Text = "Divisor";
            // 
            // fbm1DivisorBox
            // 
            this.fbm1DivisorBox.Location = new System.Drawing.Point(121, 284);
            this.fbm1DivisorBox.Name = "fbm1DivisorBox";
            this.fbm1DivisorBox.Size = new System.Drawing.Size(100, 20);
            this.fbm1DivisorBox.TabIndex = 20;
            this.fbm1DivisorBox.Text = "2.00";
            // 
            // fbm1Checkbox
            // 
            this.fbm1Checkbox.AutoSize = true;
            this.fbm1Checkbox.Checked = true;
            this.fbm1Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fbm1Checkbox.Location = new System.Drawing.Point(9, 261);
            this.fbm1Checkbox.Name = "fbm1Checkbox";
            this.fbm1Checkbox.Size = new System.Drawing.Size(146, 17);
            this.fbm1Checkbox.TabIndex = 19;
            this.fbm1Checkbox.Text = "Enable Fractional Layer 1";
            this.fbm1Checkbox.UseVisualStyleBackColor = true;
            this.fbm1Checkbox.CheckedChanged += new System.EventHandler(this.fbm1Checkbox_CheckedChanged);
            // 
            // brightnessMultiplierBox
            // 
            this.brightnessMultiplierBox.Location = new System.Drawing.Point(121, 225);
            this.brightnessMultiplierBox.Name = "brightnessMultiplierBox";
            this.brightnessMultiplierBox.Size = new System.Drawing.Size(100, 20);
            this.brightnessMultiplierBox.TabIndex = 18;
            this.brightnessMultiplierBox.Text = "1.00";
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
            // noiseLacunarityBox
            // 
            this.noiseLacunarityBox.Location = new System.Drawing.Point(9, 225);
            this.noiseLacunarityBox.Name = "noiseLacunarityBox";
            this.noiseLacunarityBox.Size = new System.Drawing.Size(100, 20);
            this.noiseLacunarityBox.TabIndex = 16;
            this.noiseLacunarityBox.Text = "1.6";
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
            // noiseGainBox
            // 
            this.noiseGainBox.Location = new System.Drawing.Point(121, 176);
            this.noiseGainBox.Name = "noiseGainBox";
            this.noiseGainBox.Size = new System.Drawing.Size(100, 20);
            this.noiseGainBox.TabIndex = 12;
            this.noiseGainBox.Text = "0.6";
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
            // noiseFrequencyBox
            // 
            this.noiseFrequencyBox.Location = new System.Drawing.Point(9, 176);
            this.noiseFrequencyBox.Name = "noiseFrequencyBox";
            this.noiseFrequencyBox.Size = new System.Drawing.Size(100, 20);
            this.noiseFrequencyBox.TabIndex = 10;
            this.noiseFrequencyBox.Text = "0.23";
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
            // scaleBox
            // 
            this.scaleBox.Location = new System.Drawing.Point(121, 29);
            this.scaleBox.Name = "scaleBox";
            this.scaleBox.Size = new System.Drawing.Size(100, 20);
            this.scaleBox.TabIndex = 8;
            this.scaleBox.Text = "32.00";
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
            this.waterTab.Controls.Add(this.waterLevelBox);
            this.waterTab.Controls.Add(this.waterLevelLabel);
            this.waterTab.Location = new System.Drawing.Point(4, 25);
            this.waterTab.Name = "waterTab";
            this.waterTab.Size = new System.Drawing.Size(232, 488);
            this.waterTab.TabIndex = 2;
            this.waterTab.Text = "Water";
            this.waterTab.UseVisualStyleBackColor = true;
            // 
            // waterLevelBox
            // 
            this.waterLevelBox.Location = new System.Drawing.Point(12, 30);
            this.waterLevelBox.Name = "waterLevelBox";
            this.waterLevelBox.Size = new System.Drawing.Size(100, 20);
            this.waterLevelBox.TabIndex = 1;
            this.waterLevelBox.Text = "0.10";
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(9, 13);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(65, 13);
            this.waterLevelLabel.TabIndex = 0;
            this.waterLevelLabel.Text = "Water Level";
            // 
            // floraTab
            // 
            this.floraTab.Location = new System.Drawing.Point(4, 25);
            this.floraTab.Name = "floraTab";
            this.floraTab.Size = new System.Drawing.Size(232, 488);
            this.floraTab.TabIndex = 3;
            this.floraTab.Text = "Flora";
            this.floraTab.UseVisualStyleBackColor = true;
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
            this.Name = "MapGeneratorForm";
            this.Text = "Map Generator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MapGeneratorForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MapGeneratorForm_KeyUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.MapGeneratorForm_MouseWheel);
            ((System.ComponentModel.ISupportInitialize)(this.surface)).EndInit();
            this.mainOptionsControl.ResumeLayout(false);
            this.outputTab.ResumeLayout(false);
            this.outputTab.PerformLayout();
            this.noiseTab.ResumeLayout(false);
            this.noiseTab.PerformLayout();
            this.waterTab.ResumeLayout(false);
            this.waterTab.PerformLayout();
            this.ResumeLayout(false);

        }

        void MapGeneratorForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.LControlKey)
                ctrl = false;
        }

        void MapGeneratorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.LControlKey)
                ctrl = true;
        }

        void MapGeneratorForm_MouseWheel(object sender, MouseEventArgs e)
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
                    float scale = float.Parse(scaleBox.Text);
                    scale += 0.005f * e.Delta;
                    scaleBox.Text = string.Format("{0}", scale);
                    main.generateMap(getOptions());
                }
            }
        }

        void surface_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !ctrl)
            {
                effectPosition += new Microsoft.Xna.Framework.Vector2(e.X - lastDragPosition.X, e.Y - lastDragPosition.Y);

                positionXBox.Text = string.Format("{0}", effectPosition.X);
                positionYBox.Text = string.Format("{0}", effectPosition.Y);

                main.generateMap(getOptions());
            }
            else if (e.Button == MouseButtons.Left && ctrl)
            {
                main.view.X += e.X - lastDragPosition.X;
                main.view.Y += e.Y - lastDragPosition.Y;
            }

            lastDragPosition.X = e.X;
            lastDragPosition.Y = e.Y;
        }

        #endregion

        private System.Windows.Forms.PictureBox surface;
        private System.Windows.Forms.TextBox randomSeedBox;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Label randomTextureDimensionsLabel;
        private System.Windows.Forms.TextBox randomTextureWidthBox;
        private System.Windows.Forms.TextBox randomTextureHeightBox;
        private TabControl mainOptionsControl;
        private TabPage outputTab;
        private TabPage noiseTab;
        private Label scaleLabel;
        private TextBox scaleBox;
        private TabPage waterTab;
        private Label frequencyLabel;
        private TextBox noiseFrequencyBox;
        private TextBox noiseLacunarityBox;
        private Label lacunarityLabel;
        private TextBox noiseGainBox;
        private Label gainLabel;
        private TextBox waterLevelBox;
        private Label waterLevelLabel;
        private TextBox brightnessMultiplierBox;
        private Label brightnessLabel;
        private Label fbm2DivisorLabel;
        private TextBox fbm2DivisorBox;
        private CheckBox fbm2Checkbox;
        private Label fbmDivisorLabel;
        private TextBox fbm1DivisorBox;
        private CheckBox fbm1Checkbox;
        private Label fbm3DivisorLabel;
        private TextBox fbm3DivisorBox;
        private CheckBox fbm3Checkbox;
        private TextBox positionYBox;
        private TextBox positionXBox;
        private Label positionLabel;
        private TabPage floraTab;
    }
}