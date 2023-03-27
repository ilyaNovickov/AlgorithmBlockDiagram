using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoomAndDragContolLib;

namespace GraphAlgorithmFormApp
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
            zoomAndDragControl1.MouseWheel+= zoomAndDragControl1_MouseWheel;
            propertyGrid1.SelectedObject = zoomAndDragControl1;
        }
        private void zoomAndDragControl1_MouseWheel(object sender, MouseEventArgs e)
        {
            //zoomAndDragControl1.Zoom += (e.Delta * 0.01f);
            zoomAndDragControl1.Zoom += (float)Math.Exp( e.Delta * 0.01d);
        }

    }
}
