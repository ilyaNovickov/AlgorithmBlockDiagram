using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    [Serializable]
    public class LogicalBlock : Shape
    {
        #region Конструкторы
        public LogicalBlock() : base()
        {

        }
        public LogicalBlock(string text) : base(text)
        {

        }
        public LogicalBlock(string text, Rectangle rectangle) : base(text, rectangle)
        {

        }
        public LogicalBlock(string text, Point point, Size size) : this(text, new Rectangle(point, size))
        {

        }
        public LogicalBlock(string text, int x, int y, int width, int heigth) : this(text, new Rectangle(x, y, width, heigth))
        {

        }
        public LogicalBlock(Point point) : base(point)
        {

        }
        public LogicalBlock(int x, int y) : base(x, y)
        {

        }
        #endregion
        #region Свойства
        private GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                path.AddLine(new Point(Rectangle.Left, Rectangle.Top + Size.Height / 2), new Point(Rectangle.Left + Size.Width / 2, Rectangle.Top));
                path.AddLine(new Point(Rectangle.Left + Size.Width / 2, Rectangle.Top), new Point(Rectangle.Right, Rectangle.Top + Size.Height / 2));
                path.AddLine(new Point(Rectangle.Right, Rectangle.Top + Size.Height / 2), new Point(Rectangle.Left + Size.Width / 2, Rectangle.Bottom));
                path.AddLine(new Point(Rectangle.Left + Size.Width / 2, Rectangle.Bottom), new Point(Rectangle.Left, Rectangle.Top + Size.Height / 2));
                path.AddLine(new Point(Rectangle.Left, Rectangle.Top + Size.Height / 2), new Point(Rectangle.Left + Size.Width / 2, Rectangle.Top));
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
            DrawString(g);
        }
        #endregion
    }
}
