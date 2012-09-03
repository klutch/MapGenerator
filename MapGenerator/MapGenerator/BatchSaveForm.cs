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

        private void batchSaveButton_Click(object sender, EventArgs e)
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
                    MapGeneratorOptions options = mapGeneratorForm.getOptions();
                    int cellWidth = options.width;
                    int cellHeight = options.height;
                    int numCells = (int)numSurroundingCells.Value;
                    int originX = (int)options.position.X;
                    int originY = (int)options.position.Y;

                    for (int i = -numCells; i <= numCells; i++)
                    {
                        for (int j = -numCells; j <= numCells; j++)
                        {
                            int currentX = originX + (i * cellWidth);
                            int currentY = originY + (j * cellHeight);

                            options.position.X = (float)currentX;
                            options.position.Y = (float)currentY;

                            main.generateMap(options);
                            string fileBase = string.Format("{0}-batch_{1}_{2}", fileDialog.FileName, i, j);
                            main.saveLayers(fileBase);
                        }
                    }

                    options.position.X = (float)originX;
                    options.position.Y = (float)originY;
                    Close();
                }
            }));
        }

        private void batchSaveCompositesButton_Click(object sender, EventArgs e)
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
                    int cellWidth = options.width;
                    int cellHeight = options.height;
                    int numCells = (int)numSurroundingCells.Value;
                    int originX = (int)options.position.X;
                    int originY = (int)options.position.Y;

                    for (int i = -numCells; i <= numCells; i++)
                    {
                        for (int j = -numCells; j <= numCells; j++)
                        {
                            int currentX = originX + (i * cellWidth);
                            int currentY = originY + (j * cellHeight);

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
                    Close();
                }
            }));
        }
    }
}
