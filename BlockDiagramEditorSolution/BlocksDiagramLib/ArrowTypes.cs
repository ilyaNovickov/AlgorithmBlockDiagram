using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    public enum ArrowType
    {
        None,
        Type1,
        Type2,
        Type3
    }
    internal class ArrowTypes
    {
        public static CustomLineCap Type1
        {
            get
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddLine(new Point(-5, -5), new Point(0, 0));
                gp.AddLine(new Point(0, 0), new Point(5, -5));
                CustomLineCap type1 = new CustomLineCap(null, gp);
                type1.SetStrokeCaps(LineCap.Round, LineCap.Round);
                return type1;
            }
        }
        public static CustomLineCap Type2
        {
            get
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddLine(new Point(-5, -5), new Point(0, 0));
                gp.AddLine(new Point(0, 0), new Point(5, -5));
                CustomLineCap type2 = new CustomLineCap(null, gp);
                return type2;
            }
        }
        public static CustomLineCap Type3
        {
            get
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddLine(0, 0, -5, -5);
                gp.AddLine(-5, -5, 5, -5);
                gp.AddLine(5, -5, 0, 0);
                CustomLineCap type3 = new CustomLineCap(gp, null, LineCap.ArrowAnchor, 1);
                return type3;
            }
        }
    }
}
