using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BlocksDiagramLib
{
    [Serializable]
    public class LogicalBlock : Area
    {
        #region Конструкторы
        public LogicalBlock() : base()
        {

        }
        public LogicalBlock(Rectangle rectangle) : base(rectangle) 
        {

        }
        #endregion
        #region Свойства
        private GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddLine(new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top));
                path.AddLine(new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top), new Point(Rectangle.Right, Rectangle.Top + Rectangle.Height / 2));
                path.AddLine(new Point(Rectangle.Right, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Bottom));
                path.AddLine(new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Bottom), new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2));
                path.AddLine(new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top));
                return path;
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
