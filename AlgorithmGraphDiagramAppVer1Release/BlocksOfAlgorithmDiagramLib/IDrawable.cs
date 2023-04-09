using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    public interface IDrawable
    {
        void Draw(Graphics g);
    }
}
