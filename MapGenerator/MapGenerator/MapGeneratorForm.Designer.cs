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
            ((System.ComponentModel.ISupportInitialize)(this.surface)).BeginInit();
            this.SuspendLayout();
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(239, 0);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(686, 561);
            this.surface.TabIndex = 0;
            this.surface.TabStop = false;
            // 
            // randomSeedBox
            // 
            this.randomSeedBox.Location = new System.Drawing.Point(12, 79);
            this.randomSeedBox.Name = "randomSeedBox";
            this.randomSeedBox.Size = new System.Drawing.Size(100, 20);
            this.randomSeedBox.TabIndex = 1;
            this.randomSeedBox.Text = "123456";
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(9, 62);
            this.randomSeedLabel.Name = "randomSeedLabel";
            this.randomSeedLabel.Size = new System.Drawing.Size(75, 13);
            this.randomSeedLabel.TabIndex = 2;
            this.randomSeedLabel.Text = "Random Seed";
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.generateButton.Location = new System.Drawing.Point(12, 526);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 13);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(121, 13);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height";
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(12, 30);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(100, 20);
            this.widthBox.TabIndex = 6;
            this.widthBox.Text = "1680";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(124, 30);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(100, 20);
            this.heightBox.TabIndex = 7;
            this.heightBox.Text = "1050";
            // 
            // randomTextureDimensionsLabel
            // 
            this.randomTextureDimensionsLabel.AutoSize = true;
            this.randomTextureDimensionsLabel.Location = new System.Drawing.Point(9, 117);
            this.randomTextureDimensionsLabel.Name = "randomTextureDimensionsLabel";
            this.randomTextureDimensionsLabel.Size = new System.Drawing.Size(143, 13);
            this.randomTextureDimensionsLabel.TabIndex = 8;
            this.randomTextureDimensionsLabel.Text = "Random Texture Dimensions";
            // 
            // randomTextureWidthBox
            // 
            this.randomTextureWidthBox.Location = new System.Drawing.Point(12, 134);
            this.randomTextureWidthBox.Name = "randomTextureWidthBox";
            this.randomTextureWidthBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureWidthBox.TabIndex = 9;
            this.randomTextureWidthBox.Text = "64";
            // 
            // randomTextureHeightBox
            // 
            this.randomTextureHeightBox.Location = new System.Drawing.Point(124, 133);
            this.randomTextureHeightBox.Name = "randomTextureHeightBox";
            this.randomTextureHeightBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureHeightBox.TabIndex = 10;
            this.randomTextureHeightBox.Text = "64";
            // 
            // MapGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.randomTextureHeightBox);
            this.Controls.Add(this.randomTextureWidthBox);
            this.Controls.Add(this.randomTextureDimensionsLabel);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.randomSeedLabel);
            this.Controls.Add(this.randomSeedBox);
            this.Controls.Add(this.surface);
            this.Name = "MapGeneratorForm";
            this.Text = "Map Generator";
            ((System.ComponentModel.ISupportInitialize)(this.surface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}