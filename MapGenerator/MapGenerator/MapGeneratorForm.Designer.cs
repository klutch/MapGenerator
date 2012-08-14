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
            this.noiseLacunarityBox = new System.Windows.Forms.TextBox();
            this.lacunarityLabel = new System.Windows.Forms.Label();
            this.noiseGainBox = new System.Windows.Forms.TextBox();
            this.gainLabel = new System.Windows.Forms.Label();
            this.noiseFrequencyBox = new System.Windows.Forms.TextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.randomTextureScaleBox = new System.Windows.Forms.TextBox();
            this.randomTextureScaleLabel = new System.Windows.Forms.Label();
            this.waterTab = new System.Windows.Forms.TabPage();
            this.waterLevelBox = new System.Windows.Forms.TextBox();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.surface)).BeginInit();
            this.mainOptionsControl.SuspendLayout();
            this.outputTab.SuspendLayout();
            this.noiseTab.SuspendLayout();
            this.waterTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(240, 0);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(686, 561);
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
            this.randomTextureDimensionsLabel.Location = new System.Drawing.Point(6, 61);
            this.randomTextureDimensionsLabel.Name = "randomTextureDimensionsLabel";
            this.randomTextureDimensionsLabel.Size = new System.Drawing.Size(130, 13);
            this.randomTextureDimensionsLabel.TabIndex = 0;
            this.randomTextureDimensionsLabel.Text = "Noise Texture Dimensions";
            // 
            // randomTextureWidthBox
            // 
            this.randomTextureWidthBox.Location = new System.Drawing.Point(9, 78);
            this.randomTextureWidthBox.Name = "randomTextureWidthBox";
            this.randomTextureWidthBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureWidthBox.TabIndex = 4;
            this.randomTextureWidthBox.Text = "64";
            // 
            // randomTextureHeightBox
            // 
            this.randomTextureHeightBox.Location = new System.Drawing.Point(121, 77);
            this.randomTextureHeightBox.Name = "randomTextureHeightBox";
            this.randomTextureHeightBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureHeightBox.TabIndex = 5;
            this.randomTextureHeightBox.Text = "64";
            // 
            // mainOptionsControl
            // 
            this.mainOptionsControl.Controls.Add(this.outputTab);
            this.mainOptionsControl.Controls.Add(this.noiseTab);
            this.mainOptionsControl.Controls.Add(this.waterTab);
            this.mainOptionsControl.Location = new System.Drawing.Point(0, 0);
            this.mainOptionsControl.Name = "mainOptionsControl";
            this.mainOptionsControl.SelectedIndex = 0;
            this.mainOptionsControl.Size = new System.Drawing.Size(240, 517);
            this.mainOptionsControl.TabIndex = 11;
            // 
            // outputTab
            // 
            this.outputTab.Controls.Add(this.widthLabel);
            this.outputTab.Controls.Add(this.heightLabel);
            this.outputTab.Controls.Add(this.widthBox);
            this.outputTab.Controls.Add(this.heightBox);
            this.outputTab.Location = new System.Drawing.Point(4, 22);
            this.outputTab.Name = "outputTab";
            this.outputTab.Padding = new System.Windows.Forms.Padding(3);
            this.outputTab.Size = new System.Drawing.Size(232, 491);
            this.outputTab.TabIndex = 0;
            this.outputTab.Text = "Output";
            this.outputTab.UseVisualStyleBackColor = true;
            // 
            // noiseTab
            // 
            this.noiseTab.Controls.Add(this.noiseLacunarityBox);
            this.noiseTab.Controls.Add(this.lacunarityLabel);
            this.noiseTab.Controls.Add(this.noiseGainBox);
            this.noiseTab.Controls.Add(this.gainLabel);
            this.noiseTab.Controls.Add(this.noiseFrequencyBox);
            this.noiseTab.Controls.Add(this.frequencyLabel);
            this.noiseTab.Controls.Add(this.randomTextureScaleBox);
            this.noiseTab.Controls.Add(this.randomTextureScaleLabel);
            this.noiseTab.Controls.Add(this.randomTextureHeightBox);
            this.noiseTab.Controls.Add(this.randomSeedLabel);
            this.noiseTab.Controls.Add(this.randomTextureDimensionsLabel);
            this.noiseTab.Controls.Add(this.randomSeedBox);
            this.noiseTab.Controls.Add(this.randomTextureWidthBox);
            this.noiseTab.Location = new System.Drawing.Point(4, 22);
            this.noiseTab.Name = "noiseTab";
            this.noiseTab.Padding = new System.Windows.Forms.Padding(3);
            this.noiseTab.Size = new System.Drawing.Size(232, 491);
            this.noiseTab.TabIndex = 1;
            this.noiseTab.Text = "Noise";
            this.noiseTab.UseVisualStyleBackColor = true;
            // 
            // noiseLacunarityBox
            // 
            this.noiseLacunarityBox.Location = new System.Drawing.Point(9, 176);
            this.noiseLacunarityBox.Name = "noiseLacunarityBox";
            this.noiseLacunarityBox.Size = new System.Drawing.Size(100, 20);
            this.noiseLacunarityBox.TabIndex = 16;
            this.noiseLacunarityBox.Text = "2";
            // 
            // lacunarityLabel
            // 
            this.lacunarityLabel.AutoSize = true;
            this.lacunarityLabel.Location = new System.Drawing.Point(6, 159);
            this.lacunarityLabel.Name = "lacunarityLabel";
            this.lacunarityLabel.Size = new System.Drawing.Size(56, 13);
            this.lacunarityLabel.TabIndex = 15;
            this.lacunarityLabel.Text = "Lacunarity";
            // 
            // noiseGainBox
            // 
            this.noiseGainBox.Location = new System.Drawing.Point(121, 127);
            this.noiseGainBox.Name = "noiseGainBox";
            this.noiseGainBox.Size = new System.Drawing.Size(100, 20);
            this.noiseGainBox.TabIndex = 12;
            this.noiseGainBox.Text = "0.6";
            // 
            // gainLabel
            // 
            this.gainLabel.AutoSize = true;
            this.gainLabel.Location = new System.Drawing.Point(118, 110);
            this.gainLabel.Name = "gainLabel";
            this.gainLabel.Size = new System.Drawing.Size(29, 13);
            this.gainLabel.TabIndex = 11;
            this.gainLabel.Text = "Gain";
            // 
            // noiseFrequencyBox
            // 
            this.noiseFrequencyBox.Location = new System.Drawing.Point(8, 127);
            this.noiseFrequencyBox.Name = "noiseFrequencyBox";
            this.noiseFrequencyBox.Size = new System.Drawing.Size(100, 20);
            this.noiseFrequencyBox.TabIndex = 10;
            this.noiseFrequencyBox.Text = "0.23";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(5, 110);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.frequencyLabel.TabIndex = 9;
            this.frequencyLabel.Text = "Frequency";
            // 
            // randomTextureScaleBox
            // 
            this.randomTextureScaleBox.Location = new System.Drawing.Point(121, 29);
            this.randomTextureScaleBox.Name = "randomTextureScaleBox";
            this.randomTextureScaleBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureScaleBox.TabIndex = 8;
            this.randomTextureScaleBox.Text = "32.00";
            // 
            // randomTextureScaleLabel
            // 
            this.randomTextureScaleLabel.AutoSize = true;
            this.randomTextureScaleLabel.Location = new System.Drawing.Point(118, 12);
            this.randomTextureScaleLabel.Name = "randomTextureScaleLabel";
            this.randomTextureScaleLabel.Size = new System.Drawing.Size(73, 13);
            this.randomTextureScaleLabel.TabIndex = 7;
            this.randomTextureScaleLabel.Text = "Texture Scale";
            // 
            // waterTab
            // 
            this.waterTab.Controls.Add(this.waterLevelBox);
            this.waterTab.Controls.Add(this.waterLevelLabel);
            this.waterTab.Location = new System.Drawing.Point(4, 22);
            this.waterTab.Name = "waterTab";
            this.waterTab.Size = new System.Drawing.Size(232, 491);
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
            // MapGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.mainOptionsControl);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.surface);
            this.Name = "MapGeneratorForm";
            this.Text = "Map Generator";
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

        void MapGeneratorForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.X >= surface.Left && e.X <= surface.Left + surface.Width &&
                e.Y >= 0 && e.Y <= surface.Height)
            {
                float scaleModified = 0.0005f;
                main.scale += scaleModified * e.Delta;
            }
        }

        void surface_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
        private Label randomTextureScaleLabel;
        private TextBox randomTextureScaleBox;
        private TabPage waterTab;
        private Label frequencyLabel;
        private TextBox noiseFrequencyBox;
        private TextBox noiseLacunarityBox;
        private Label lacunarityLabel;
        private TextBox noiseGainBox;
        private Label gainLabel;
        private TextBox waterLevelBox;
        private Label waterLevelLabel;
    }
}