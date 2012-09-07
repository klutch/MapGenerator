using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MapGenerator
{
    public struct BatchSaveLayerOptions
    {
        public bool baseLayer;
        public bool waterLayer;
        public bool detailsLayer1;
        public bool detailsLayer2;
        public bool detailsLayer3;
        public bool normalsLayer;
        public bool shadowLayer;
        public bool floraLayer1;
        public bool floraLayer2;
    };

    public partial class BatchSaveForm : Form
    {
        private Main main;
        private MapGeneratorForm mapGeneratorForm;

        public BatchSaveForm(MapGeneratorForm mapGeneratorForm)
        {
            this.main = mapGeneratorForm.main;
            this.mapGeneratorForm = mapGeneratorForm;

            InitializeComponent();
        }

        private void batchCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveCompositeRadio_CheckedChanged(object sender, EventArgs e)
        {
            saveLayersGroup.Enabled = !saveCompositeRadio.Checked;
        }

        private void saveLayersRadio_CheckedChanged(object sender, EventArgs e)
        {
            saveLayersGroup.Enabled = saveLayersRadio.Checked;
        }

        private void batchSaveButton_Click(object sender, EventArgs e)
        {
            if (saveCompositeRadio.Checked)
            {
                ////////////////////////////////////////////////
                // Save composites
                ////////////////////////////////////////////////
                SaveFileDialog fileDialog = new SaveFileDialog();
                // Create output directory if needed
                DirectoryInfo directory = new DirectoryInfo(MapGeneratorForm.outputDirectory);
                if (!directory.Exists)
                    directory.Create();
                fileDialog.InitialDirectory = MapGeneratorForm.outputDirectory;
                fileDialog.Title = "Save Composites";
                fileDialog.Filter = "PNG Files (*.png)|*.png";
                Invoke((Action)(() =>
                {
                    if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        MapGeneratorOptions options = mapGeneratorForm.getOptions();

                        // Calculate correct cell dimensions
                        float smallSide = Math.Min(options.width, options.height);
                        float aspectX = options.width / smallSide;
                        float aspectY = options.height / smallSide;
                        int cellWidth = (int)(((float)options.width * aspectX) / options.scale);
                        int cellHeight = (int)(((float)options.height * aspectY) / options.scale);
                        int numCells = (int)numSurroundingCells.Value;
                        int originX = (int)options.position.X;
                        int originY = (int)options.position.Y;

                        for (int i = -numCells; i <= numCells; i++)
                        {
                            for (int j = -numCells; j <= numCells; j++)
                            {
                                int currentX = originX + (-i * cellWidth);
                                int currentY = originY + (-j * cellHeight);

                                Console.WriteLine("Saving at position: {0}, {1}", currentX, currentY);

                                options.position.X = (float)currentX;
                                options.position.Y = (float)currentY;

                                main.generateMap(options);
                                string modifiedFileName = fileDialog.FileName.Replace(".png", "");
                                string fileBase = string.Format("{0}-batch_{1}_{2}.png", modifiedFileName, i, j);
                                main.saveComposite(fileBase);
                            }
                        }

                        options.position.X = (float)originX;
                        options.position.Y = (float)originY;
                        mapGeneratorForm.ignoreSurfaceClick = true;
                        Close();
                    }
                }));
            }
            else
            {
                ////////////////////////////////////////////////
                // Save layers
                ////////////////////////////////////////////////
                SaveFileDialog fileDialog = new SaveFileDialog();
                // Create output directory if needed
                DirectoryInfo directory = new DirectoryInfo(MapGeneratorForm.outputDirectory);
                if (!directory.Exists)
                    directory.Create();
                fileDialog.InitialDirectory = MapGeneratorForm.outputDirectory;
                fileDialog.Title = "Save Layers";

                Invoke((Action)(() =>
                {
                    if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        // Map options
                        MapGeneratorOptions options = mapGeneratorForm.getOptions();

                        // Layer options
                        BatchSaveLayerOptions saveLayerOptions = new BatchSaveLayerOptions();
                        saveLayerOptions.baseLayer = saveBaseLayer.Checked;
                        saveLayerOptions.waterLayer = saveWaterLayer.Checked;
                        saveLayerOptions.detailsLayer1 = saveDetailsLayer1.Checked;
                        saveLayerOptions.detailsLayer2 = saveDetailsLayer2.Checked;
                        saveLayerOptions.detailsLayer3 = saveDetailsLayer3.Checked;
                        saveLayerOptions.normalsLayer = saveNormalsLayer.Checked;
                        saveLayerOptions.shadowLayer = saveShadowLayer.Checked;
                        saveLayerOptions.floraLayer1 = saveFloraLayer1.Checked;
                        saveLayerOptions.floraLayer2 = saveFloraLayer2.Checked;

                        // Calculate correct cell dimensions
                        float smallSide = Math.Min(options.width, options.height);
                        float aspectX = options.width / smallSide;
                        float aspectY = options.height / smallSide;
                        int cellWidth = (int)(((float)options.width * aspectX) / options.scale);
                        int cellHeight = (int)(((float)options.height * aspectY) / options.scale);
                        int numCells = (int)numSurroundingCells.Value;
                        int originX = (int)options.position.X;
                        int originY = (int)options.position.Y;

                        for (int i = -numCells; i <= numCells; i++)
                        {
                            for (int j = -numCells; j <= numCells; j++)
                            {
                                int currentX = originX + (-i * cellWidth);
                                int currentY = originY + (-j * cellHeight);

                                options.position.X = (float)currentX;
                                options.position.Y = (float)currentY;

                                main.generateMap(options);
                                string fileBase = string.Format("{0}-batch_{1}_{2}", fileDialog.FileName, i, j);
                                main.saveLayers(fileBase, options, saveLayerOptions);
                            }
                        }

                        options.position.X = (float)originX;
                        options.position.Y = (float)originY;
                        mapGeneratorForm.ignoreSurfaceClick = true;
                        Close();
                    }
                }));
            }
        }
    }
}
