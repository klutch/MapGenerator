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
            this.numSurroundingCells = new System.Windows.Forms.NumericUpDown();
            this.batchSaveLabel = new System.Windows.Forms.Label();
            this.batchCancelButton = new System.Windows.Forms.Button();
            this.saveMethodGroup = new System.Windows.Forms.GroupBox();
            this.saveLayersRadio = new System.Windows.Forms.RadioButton();
            this.saveCompositeRadio = new System.Windows.Forms.RadioButton();
            this.saveLayersGroup = new System.Windows.Forms.GroupBox();
            this.saveShadowLayer = new System.Windows.Forms.CheckBox();
            this.saveNormalsLayer = new System.Windows.Forms.CheckBox();
            this.saveDetailsLayer3 = new System.Windows.Forms.CheckBox();
            this.saveDetailsLayer2 = new System.Windows.Forms.CheckBox();
            this.saveFloraLayer2 = new System.Windows.Forms.CheckBox();
            this.saveFloraLayer1 = new System.Windows.Forms.CheckBox();
            this.saveWaterLayer = new System.Windows.Forms.CheckBox();
            this.saveDetailsLayer1 = new System.Windows.Forms.CheckBox();
            this.saveBaseLayer = new System.Windows.Forms.CheckBox();
            this.batchSaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSurroundingCells)).BeginInit();
            this.saveMethodGroup.SuspendLayout();
            this.saveLayersGroup.SuspendLayout();
            this.SuspendLayout();
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
            this.numSurroundingCells.Size = new System.Drawing.Size(115, 20);
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
            this.batchSaveLabel.Size = new System.Drawing.Size(89, 13);
            this.batchSaveLabel.TabIndex = 2;
            this.batchSaveLabel.Text = "Surrounding Cells";
            // 
            // batchCancelButton
            // 
            this.batchCancelButton.Location = new System.Drawing.Point(243, 160);
            this.batchCancelButton.Name = "batchCancelButton";
            this.batchCancelButton.Size = new System.Drawing.Size(85, 23);
            this.batchCancelButton.TabIndex = 3;
            this.batchCancelButton.Text = "Cancel";
            this.batchCancelButton.UseVisualStyleBackColor = true;
            this.batchCancelButton.Click += new System.EventHandler(this.batchCancelButton_Click);
            // 
            // saveMethodGroup
            // 
            this.saveMethodGroup.Controls.Add(this.saveLayersRadio);
            this.saveMethodGroup.Controls.Add(this.saveCompositeRadio);
            this.saveMethodGroup.Location = new System.Drawing.Point(12, 60);
            this.saveMethodGroup.Name = "saveMethodGroup";
            this.saveMethodGroup.Size = new System.Drawing.Size(115, 94);
            this.saveMethodGroup.TabIndex = 6;
            this.saveMethodGroup.TabStop = false;
            this.saveMethodGroup.Text = "Save";
            // 
            // saveLayersRadio
            // 
            this.saveLayersRadio.AutoSize = true;
            this.saveLayersRadio.Location = new System.Drawing.Point(7, 44);
            this.saveLayersRadio.Name = "saveLayersRadio";
            this.saveLayersRadio.Size = new System.Drawing.Size(56, 17);
            this.saveLayersRadio.TabIndex = 1;
            this.saveLayersRadio.Text = "Layers";
            this.saveLayersRadio.UseVisualStyleBackColor = true;
            this.saveLayersRadio.CheckedChanged += new System.EventHandler(this.saveLayersRadio_CheckedChanged);
            // 
            // saveCompositeRadio
            // 
            this.saveCompositeRadio.AutoSize = true;
            this.saveCompositeRadio.Checked = true;
            this.saveCompositeRadio.Location = new System.Drawing.Point(7, 19);
            this.saveCompositeRadio.Name = "saveCompositeRadio";
            this.saveCompositeRadio.Size = new System.Drawing.Size(74, 17);
            this.saveCompositeRadio.TabIndex = 0;
            this.saveCompositeRadio.TabStop = true;
            this.saveCompositeRadio.Text = "Composite";
            this.saveCompositeRadio.UseVisualStyleBackColor = true;
            this.saveCompositeRadio.CheckedChanged += new System.EventHandler(this.saveCompositeRadio_CheckedChanged);
            // 
            // saveLayersGroup
            // 
            this.saveLayersGroup.Controls.Add(this.saveShadowLayer);
            this.saveLayersGroup.Controls.Add(this.saveNormalsLayer);
            this.saveLayersGroup.Controls.Add(this.saveDetailsLayer3);
            this.saveLayersGroup.Controls.Add(this.saveDetailsLayer2);
            this.saveLayersGroup.Controls.Add(this.saveFloraLayer2);
            this.saveLayersGroup.Controls.Add(this.saveFloraLayer1);
            this.saveLayersGroup.Controls.Add(this.saveWaterLayer);
            this.saveLayersGroup.Controls.Add(this.saveDetailsLayer1);
            this.saveLayersGroup.Controls.Add(this.saveBaseLayer);
            this.saveLayersGroup.Enabled = false;
            this.saveLayersGroup.Location = new System.Drawing.Point(142, 12);
            this.saveLayersGroup.Name = "saveLayersGroup";
            this.saveLayersGroup.Size = new System.Drawing.Size(186, 142);
            this.saveLayersGroup.TabIndex = 7;
            this.saveLayersGroup.TabStop = false;
            this.saveLayersGroup.Text = "Layers";
            // 
            // saveShadowLayer
            // 
            this.saveShadowLayer.AutoSize = true;
            this.saveShadowLayer.Checked = true;
            this.saveShadowLayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveShadowLayer.Location = new System.Drawing.Point(111, 43);
            this.saveShadowLayer.Name = "saveShadowLayer";
            this.saveShadowLayer.Size = new System.Drawing.Size(70, 17);
            this.saveShadowLayer.TabIndex = 8;
            this.saveShadowLayer.Text = "Shadows";
            this.saveShadowLayer.UseVisualStyleBackColor = true;
            // 
            // saveNormalsLayer
            // 
            this.saveNormalsLayer.AutoSize = true;
            this.saveNormalsLayer.Location = new System.Drawing.Point(111, 20);
            this.saveNormalsLayer.Name = "saveNormalsLayer";
            this.saveNormalsLayer.Size = new System.Drawing.Size(64, 17);
            this.saveNormalsLayer.TabIndex = 7;
            this.saveNormalsLayer.Text = "Normals";
            this.saveNormalsLayer.UseVisualStyleBackColor = true;
            // 
            // saveDetailsLayer3
            // 
            this.saveDetailsLayer3.AutoSize = true;
            this.saveDetailsLayer3.Checked = true;
            this.saveDetailsLayer3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveDetailsLayer3.Location = new System.Drawing.Point(7, 112);
            this.saveDetailsLayer3.Name = "saveDetailsLayer3";
            this.saveDetailsLayer3.Size = new System.Drawing.Size(67, 17);
            this.saveDetailsLayer3.TabIndex = 6;
            this.saveDetailsLayer3.Text = "Details 3";
            this.saveDetailsLayer3.UseVisualStyleBackColor = true;
            // 
            // saveDetailsLayer2
            // 
            this.saveDetailsLayer2.AutoSize = true;
            this.saveDetailsLayer2.Checked = true;
            this.saveDetailsLayer2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveDetailsLayer2.Location = new System.Drawing.Point(7, 89);
            this.saveDetailsLayer2.Name = "saveDetailsLayer2";
            this.saveDetailsLayer2.Size = new System.Drawing.Size(67, 17);
            this.saveDetailsLayer2.TabIndex = 5;
            this.saveDetailsLayer2.Text = "Details 2";
            this.saveDetailsLayer2.UseVisualStyleBackColor = true;
            // 
            // saveFloraLayer2
            // 
            this.saveFloraLayer2.AutoSize = true;
            this.saveFloraLayer2.Checked = true;
            this.saveFloraLayer2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveFloraLayer2.Location = new System.Drawing.Point(111, 89);
            this.saveFloraLayer2.Name = "saveFloraLayer2";
            this.saveFloraLayer2.Size = new System.Drawing.Size(58, 17);
            this.saveFloraLayer2.TabIndex = 4;
            this.saveFloraLayer2.Text = "Flora 2";
            this.saveFloraLayer2.UseVisualStyleBackColor = true;
            // 
            // saveFloraLayer1
            // 
            this.saveFloraLayer1.AutoSize = true;
            this.saveFloraLayer1.Checked = true;
            this.saveFloraLayer1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveFloraLayer1.Location = new System.Drawing.Point(111, 66);
            this.saveFloraLayer1.Name = "saveFloraLayer1";
            this.saveFloraLayer1.Size = new System.Drawing.Size(58, 17);
            this.saveFloraLayer1.TabIndex = 3;
            this.saveFloraLayer1.Text = "Flora 1";
            this.saveFloraLayer1.UseVisualStyleBackColor = true;
            // 
            // saveWaterLayer
            // 
            this.saveWaterLayer.AutoSize = true;
            this.saveWaterLayer.Checked = true;
            this.saveWaterLayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveWaterLayer.Location = new System.Drawing.Point(7, 43);
            this.saveWaterLayer.Name = "saveWaterLayer";
            this.saveWaterLayer.Size = new System.Drawing.Size(55, 17);
            this.saveWaterLayer.TabIndex = 2;
            this.saveWaterLayer.Text = "Water";
            this.saveWaterLayer.UseVisualStyleBackColor = true;
            // 
            // saveDetailsLayer1
            // 
            this.saveDetailsLayer1.AutoSize = true;
            this.saveDetailsLayer1.Checked = true;
            this.saveDetailsLayer1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveDetailsLayer1.Location = new System.Drawing.Point(7, 66);
            this.saveDetailsLayer1.Name = "saveDetailsLayer1";
            this.saveDetailsLayer1.Size = new System.Drawing.Size(67, 17);
            this.saveDetailsLayer1.TabIndex = 1;
            this.saveDetailsLayer1.Text = "Details 1";
            this.saveDetailsLayer1.UseVisualStyleBackColor = true;
            // 
            // saveBaseLayer
            // 
            this.saveBaseLayer.AutoSize = true;
            this.saveBaseLayer.Checked = true;
            this.saveBaseLayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveBaseLayer.Location = new System.Drawing.Point(7, 20);
            this.saveBaseLayer.Name = "saveBaseLayer";
            this.saveBaseLayer.Size = new System.Drawing.Size(50, 17);
            this.saveBaseLayer.TabIndex = 0;
            this.saveBaseLayer.Text = "Base";
            this.saveBaseLayer.UseVisualStyleBackColor = true;
            // 
            // batchSaveButton
            // 
            this.batchSaveButton.Location = new System.Drawing.Point(142, 160);
            this.batchSaveButton.Name = "batchSaveButton";
            this.batchSaveButton.Size = new System.Drawing.Size(85, 23);
            this.batchSaveButton.TabIndex = 8;
            this.batchSaveButton.Text = "Save";
            this.batchSaveButton.UseVisualStyleBackColor = true;
            this.batchSaveButton.Click += new System.EventHandler(this.batchSaveButton_Click);
            // 
            // BatchSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 192);
            this.ControlBox = false;
            this.Controls.Add(this.batchSaveButton);
            this.Controls.Add(this.saveLayersGroup);
            this.Controls.Add(this.saveMethodGroup);
            this.Controls.Add(this.batchCancelButton);
            this.Controls.Add(this.batchSaveLabel);
            this.Controls.Add(this.numSurroundingCells);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "BatchSaveForm";
            this.Text = "Batch Save";
            ((System.ComponentModel.ISupportInitialize)(this.numSurroundingCells)).EndInit();
            this.saveMethodGroup.ResumeLayout(false);
            this.saveMethodGroup.PerformLayout();
            this.saveLayersGroup.ResumeLayout(false);
            this.saveLayersGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSurroundingCells;
        private System.Windows.Forms.Label batchSaveLabel;
        private System.Windows.Forms.Button batchCancelButton;
        private System.Windows.Forms.GroupBox saveMethodGroup;
        private System.Windows.Forms.RadioButton saveLayersRadio;
        private System.Windows.Forms.RadioButton saveCompositeRadio;
        private System.Windows.Forms.GroupBox saveLayersGroup;
        private System.Windows.Forms.CheckBox saveDetailsLayer1;
        private System.Windows.Forms.CheckBox saveBaseLayer;
        private System.Windows.Forms.CheckBox saveWaterLayer;
        private System.Windows.Forms.CheckBox saveFloraLayer1;
        private System.Windows.Forms.CheckBox saveDetailsLayer2;
        private System.Windows.Forms.CheckBox saveFloraLayer2;
        private System.Windows.Forms.CheckBox saveShadowLayer;
        private System.Windows.Forms.CheckBox saveNormalsLayer;
        private System.Windows.Forms.CheckBox saveDetailsLayer3;
        private System.Windows.Forms.Button batchSaveButton;
    }
}