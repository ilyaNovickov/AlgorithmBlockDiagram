using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    [Serializable]
    public class OperationalBlock : Shape
    {
        #region Конструкторы
        public OperationalBlock() : base()
        {

        }
        public OperationalBlock(string text) : base(text)
        {

        }
        public OperationalBlock(string text, Rectangle rectangle) : base(text, rectangle)
        {

        }
        public OperationalBlock(string text, Point point, Size size) : this(text, new Rectangle(point, size))
        {

        }
        public OperationalBlock(string text, int x, int y, int width, int heigth) : this(text, new Rectangle(x, y, width, heigth))
        {

        }
        public OperationalBlock(Point point) : base(point)
        {

        }
        public OperationalBlock(int x, int y) : base(x, y)
        {

        }
        #endregion
        #region Методы
        public override bool IsOnto(Point point)
        {
            if (this.Rectangle.Contains(point))
                return true;
            return false;
        }
        public override void Draw(Graphics g)
        {
            SolidBrush solidBrush = new SolidBrush(FillColor);
            g.FillRectangle(solidBrush, this.Rectangle);
            solidBrush.Dispose();
            Pen pen = new Pen(ContourColor, ContourThick);
            pen.DashStyle = DashStyle;
            g.DrawRectangle(pen, this.Rectangle);
            pen.Dispose();
            DrawString(g);
        }
        #endregion
    }
}
