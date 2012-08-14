using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapGenerator
{
    public partial class MapGeneratorForm : Form
    {
        public MapGeneratorForm()
        {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(MapGeneratorForm_FormClosed);
            ResizeEnd += new EventHandler(MapGeneratorForm_ResizeEnd);
        }

        void MapGeneratorForm_ResizeEnd(object sender, EventArgs e)
        {
            surface.Width = Width - surface.Location.X;
            surface.Height = Height;

            Main.graphics.PreferredBackBufferWidth = surface.Width;
            Main.graphics.PreferredBackBufferHeight = surface.Height;
            Main.graphics.ApplyChanges();
        }

        void MapGeneratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
