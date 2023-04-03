using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace BlocksOfAlgorithmDiagramLib
{
    public class BeginEndBlock : Shape
    {
        #region Конструкторы
        public BeginEndBlock() : base()
        {

        }
        public BeginEndBlock(string text) : base(text)
        {

        }
        public BeginEndBlock(string text, Rectangle rectangle) : base(text, rectangle)
        {

        }
        public BeginEndBlock(string text, Point point, Size size) : this(text, new Rectangle(point, size))
        {

        }
        public BeginEndBlock(string text, int x, int y, int width, int heigth) : this(text, new Rectangle(x, y, width, heigth))
        {

        }
        public BeginEndBlock(Point point) : base(point)
        {

        }
        public BeginEndBlock(int x, int y) : base(x, y)
        {

        }
        #endregion
        #region Свойства
        private GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath gp = new GraphicsPath();
                if (Size.Width > Size.Height)
                {
                    int radius = (int)(0.5 * Size.Height);
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
            DrawString(g);
        }
        #endregion
    }
}
