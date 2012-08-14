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
            this.randomTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.surface)).BeginInit();
            this.mainOptionsControl.SuspendLayout();
            this.outputTab.SuspendLayout();
            this.randomTab.SuspendLayout();
            this.SuspendLayout();
            this.MouseWheel += new MouseEventHandler(MapGeneratorForm_MouseWheel);
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(240, 0);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(686, 561);
            this.surface.TabIndex = 0;
            this.surface.TabStop = false;
            this.surface.MouseMove += new MouseEventHandler(this.surface_MouseMove);
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
            this.randomSeedLabel.Size = new System.Drawing.Size(75, 13);
            this.randomSeedLabel.TabIndex = 0;
            this.randomSeedLabel.Text = "Random Seed";
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
            this.randomTextureDimensionsLabel.Location = new System.Drawing.Point(6, 67);
            this.randomTextureDimensionsLabel.Name = "randomTextureDimensionsLabel";
            this.randomTextureDimensionsLabel.Size = new System.Drawing.Size(143, 13);
            this.randomTextureDimensionsLabel.TabIndex = 0;
            this.randomTextureDimensionsLabel.Text = "Random Texture Dimensions";
            // 
            // randomTextureWidthBox
            // 
            this.randomTextureWidthBox.Location = new System.Drawing.Point(9, 84);
            this.randomTextureWidthBox.Name = "randomTextureWidthBox";
            this.randomTextureWidthBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureWidthBox.TabIndex = 4;
            this.randomTextureWidthBox.Text = "64";
            // 
            // randomTextureHeightBox
            // 
            this.randomTextureHeightBox.Location = new System.Drawing.Point(121, 83);
            this.randomTextureHeightBox.Name = "randomTextureHeightBox";
            this.randomTextureHeightBox.Size = new System.Drawing.Size(100, 20);
            this.randomTextureHeightBox.TabIndex = 5;
            this.randomTextureHeightBox.Text = "64";
            // 
            // mainOptionsControl
            // 
            this.mainOptionsControl.Controls.Add(this.outputTab);
            this.mainOptionsControl.Controls.Add(this.randomTab);
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
            // randomTab
            // 
            this.randomTab.Controls.Add(this.randomTextureHeightBox);
            this.randomTab.Controls.Add(this.randomSeedLabel);
            this.randomTab.Controls.Add(this.randomTextureDimensionsLabel);
            this.randomTab.Controls.Add(this.randomSeedBox);
            this.randomTab.Controls.Add(this.randomTextureWidthBox);
            this.randomTab.Location = new System.Drawing.Point(4, 22);
            this.randomTab.Name = "randomTab";
            this.randomTab.Padding = new System.Windows.Forms.Padding(3);
            this.randomTab.Size = new System.Drawing.Size(232, 259);
            this.randomTab.TabIndex = 1;
            this.randomTab.Text = "Random";
            this.randomTab.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.surface)).EndInit();
            this.mainOptionsControl.ResumeLayout(false);
            this.outputTab.ResumeLayout(false);
            this.outputTab.PerformLayout();
            this.randomTab.ResumeLayout(false);
            this.randomTab.PerformLayout();
            this.ResumeLayout(false);

        }

        void MapGeneratorForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.X >= surface.Left && e.X <= surface.Left + surface.Width &&
                e.Y >= 0 && e.Y <= surface.Height)
            {
                float scaleModified = 0.001f;
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
        private TabPage randomTab;
    }
}