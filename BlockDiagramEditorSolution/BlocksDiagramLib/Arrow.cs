using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    public enum Direction
    {
        To,
        From,
        Bidertional
    }
    [Serializable]
    public class Arrow : Line
    {
        #region Конструкторы
        public Arrow() : this(new Point(0, 0), new Point(100, 100))
        {

        }
        public Arrow(Point point1, Point point2) : this(new Point[] { point1, point2 })
        {

        }
        public Arrow(params Point[] points) : base(points)
        {
            this.ArrowType = ArrowType.Type1;
            this.Direction = Direction.To;
        }
        #endregion
        #region Свойства
        public ArrowType ArrowType
        {
            get; set;
        }
        public Direction Direction
        {
            get; set;
        }
        #endregion
        #region Методы
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(ContourColor, ContourThick);
            pen.DashStyle = DashStyle;
            switch (ArrowType)
            {
                case ArrowType.None:
                    break;
                case ArrowType.Type1:
                    DeterminingDirection(pen, ArrowTypes.Type1);
                    break;
                case ArrowType.Type2:
                    DeterminingDirection(pen, ArrowTypes.Type2);
                    break;
                case ArrowType.Type3:
                    DeterminingDirection(pen, ArrowTypes.Type3);
                    break;
            }
            g.DrawLines(pen, this.GetAllPoints());
            pen.Dispose();
        }
        private void DeterminingDirection(Pen pen, CustomLineCap customLineCap)
        {
            switch (Direction)
            {
                case Direction.To:
                    pen.CustomEndCap = customLineCap;
                    break;
                case Direction.From:
                    pen.CustomStartCap = customLineCap;
                    break;
                case Direction.Bidertional:
                    pen.CustomStartCap = customLineCap;
                    pen.CustomEndCap = customLineCap;
                    break;
            }
        }
        #endregion
    }
}
