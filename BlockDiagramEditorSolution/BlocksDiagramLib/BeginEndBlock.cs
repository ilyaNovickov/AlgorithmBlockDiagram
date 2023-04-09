using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    [Serializable]
    public class BeginEndBlock : Area
    {
        #region Свойства
        private GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath gp = new GraphicsPath();
                if (Rectangle.Width > Rectangle.Height)
                {
                    int radius = (int)(0.5 * Rectangle.Height);
                    gp.AddLine(new Point(Rectangle.Left + radius, Rectangle.Top), new Point(Rectangle.Right - radius, Rectangle.Top));
                    gp.AddArc(new Rectangle(Rectangle.Right - 2 * radius, Rectangle.Top, 2 * radius, 2 * radius), -90, +180);
                    gp.AddLine(new Point(Rectangle.Right - radius, Rectangle.Bottom), new Point(Rectangle.Left + radius, Rectangle.Bottom));
                    gp.AddArc(new Rectangle(Rectangle.Left, Rectangle.Top, 2 * radius, 2 * radius), +90, 180);
                }
                else
                {
                    gp.AddEllipse(Rectangle);
                }
                return gp;
            }
        }
        #endregion
        #region Методы
        public override bool IsOnto(Point point)
        {
            if (this.GraphicsPath.IsVisible(point))
                return true;
            return false;
        }
        public override void Draw(Graphics g)
        {
            SolidBrush solidBrush = new SolidBrush(FillColor);
            g.FillPath(solidBrush, this.GraphicsPath);
            solidBrush.Dispose();
            Pen pen = new Pen(ContourColor, ContourThick);
            pen.DashStyle = DashStyle;
            g.DrawPath(pen, this.GraphicsPath);
            pen.Dispose();
            DrawText(g);
        }
        #endregion
    }
}
