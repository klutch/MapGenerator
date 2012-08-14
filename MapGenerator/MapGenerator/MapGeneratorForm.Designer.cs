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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.randomSeedLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.surface)).BeginInit();
            this.SuspendLayout();
            // 
            // surface
            // 
            this.surface.Location = new System.Drawing.Point(234, 0);
            this.surface.Name = "surface";
            this.surface.Size = new System.Drawing.Size(691, 561);
            this.surface.TabIndex = 0;
            this.surface.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "123456";
            // 
            // randomSeedLabel
            // 
            this.randomSeedLabel.AutoSize = true;
            this.randomSeedLabel.Location = new System.Drawing.Point(9, 12);
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
            // 
            // MapGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.randomSeedLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.surface);
            this.Name = "MapGeneratorForm";
            this.Text = "Map Generator";
            ((System.ComponentModel.ISupportInitialize)(this.surface)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox surface;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label randomSeedLabel;
        private System.Windows.Forms.Button generateButton;
    }
}