namespace MapGenerator
{
    partial class BatchSaveForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.batchSaveLayersButton = new System.Windows.Forms.Button();
            this.numSurroundingCells = new System.Windows.Forms.NumericUpDown();
            this.batchSaveLabel = new System.Windows.Forms.Label();
            this.batchCancelButton = new System.Windows.Forms.Button();
            this.batchSaveCompositesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSurroundingCells)).BeginInit();
            this.SuspendLayout();
            // 
            // batchSaveLayersButton
            // 
            this.batchSaveLayersButton.Location = new System.Drawing.Point(12, 51);
            this.batchSaveLayersButton.Name = "batchSaveLayersButton";
            this.batchSaveLayersButton.Size = new System.Drawing.Size(95, 23);
            this.batchSaveLayersButton.TabIndex = 0;
            this.batchSaveLayersButton.Text = "Save Layers";
            this.batchSaveLayersButton.UseVisualStyleBackColor = true;
            this.batchSaveLayersButton.Click += new System.EventHandler(this.batchSaveButton_Click);
            // 
            // numSurroundingCells
            // 
            this.numSurroundingCells.Location = new System.Drawing.Point(12, 25);
            this.numSurroundingCells.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numSurroundingCells.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSurroundingCells.Name = "numSurroundingCells";
            this.numSurroundingCells.Size = new System.Drawing.Size(216, 20);
            this.numSurroundingCells.TabIndex = 1;
            this.numSurroundingCells.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // batchSaveLabel
            // 
            this.batchSaveLabel.AutoSize = true;
            this.batchSaveLabel.Location = new System.Drawing.Point(12, 9);
            this.batchSaveLabel.Name = "batchSaveLabel";
            this.batchSaveLabel.Size = new System.Drawing.Size(176, 13);
            this.batchSaveLabel.TabIndex = 2;
            this.batchSaveLabel.Text = "Number of surrounding cells to save";
            // 
            // batchCancelButton
            // 
            this.batchCancelButton.Location = new System.Drawing.Point(153, 80);
            this.batchCancelButton.Name = "batchCancelButton";
            this.batchCancelButton.Size = new System.Drawing.Size(75, 23);
            this.batchCancelButton.TabIndex = 3;
            this.batchCancelButton.Text = "Cancel";
            this.batchCancelButton.UseVisualStyleBackColor = true;
            this.batchCancelButton.Click += new System.EventHandler(this.batchCancelButton_Click);
            // 
            // batchSaveCompositesButton
            // 
            this.batchSaveCompositesButton.Location = new System.Drawing.Point(113, 51);
            this.batchSaveCompositesButton.Name = "batchSaveCompositesButton";
            this.batchSaveCompositesButton.Size = new System.Drawing.Size(115, 23);
            this.batchSaveCompositesButton.TabIndex = 4;
            this.batchSaveCompositesButton.Text = "Save Composites";
            this.batchSaveCompositesButton.UseVisualStyleBackColor = true;
            this.batchSaveCompositesButton.Click += new System.EventHandler(this.batchSaveCompositesButton_Click);
            // 
            // BatchSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 119);
            this.ControlBox = false;
            this.Controls.Add(this.batchSaveCompositesButton);
            this.Controls.Add(this.batchCancelButton);
            this.Controls.Add(this.batchSaveLabel);
            this.Controls.Add(this.numSurroundingCells);
            this.Controls.Add(this.batchSaveLayersButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BatchSaveForm";
            this.Text = "Batch Save";
            ((System.ComponentModel.ISupportInitialize)(this.numSurroundingCells)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button batchSaveLayersButton;
        private System.Windows.Forms.NumericUpDown numSurroundingCells;
        private System.Windows.Forms.Label batchSaveLabel;
        private System.Windows.Forms.Button batchCancelButton;
        private System.Windows.Forms.Button batchSaveCompositesButton;
    }
}