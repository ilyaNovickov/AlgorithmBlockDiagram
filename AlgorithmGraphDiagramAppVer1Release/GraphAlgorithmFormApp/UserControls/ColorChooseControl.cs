using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphAlgorithmFormApp
{
    public partial class ColorChooseControl : UserControl
    {
        public ColorChooseControl()
        {
            InitializeComponent();
            colorPanel.BackColor = Color.White;
        }
        public Color Color 
        { 
            get { return colorPanel.BackColor; }
            set { colorPanel.BackColor = value; }
        }
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        private void fillColorPanel_Click(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = cd.Color;
                Color = cd.Color;
            }
            cd.Dispose();
        }
    }
}
