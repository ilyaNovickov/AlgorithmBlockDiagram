using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlocksDiagramLib;

namespace TestForm
{
    public partial class Form1 : Form
    {
        OperationalBlock op = new OperationalBlock(new Rectangle(100, 100, 150, 75));
        public Form1()
        {
            InitializeComponent();
            propertyGrid2.SelectedObject = op;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            op.Draw(e.Graphics);
        }
    }
}
