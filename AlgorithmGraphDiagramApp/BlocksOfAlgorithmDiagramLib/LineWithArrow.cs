using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    public enum Direction
    {
        To,
        From,
        Bidertional
    }
    public class LineWithArrow : Line
    {
        #region Данные
        
        #endregion
        #region Конструкторы
        public LineWithArrow() : base()
        {
            DefaultInitilization();
        }
        public LineWithArrow(params Point[] points) : base(points)
        {
            DefaultInitilization();
        }
        public LineWithArrow(Color contourColor, int contourThick, params Point[] points) : base(contourColor, contourThick, points)
        {
            DefaultInitilization();
        }
        private void DefaultInitilization()
        {
            ArrowType = ArrowType.Type1;
            Direction = Direction.To;
        }
        #endregion
        #region Свойства
        [Category("Вид")]
        [Description("Отвечает за тип стрелки")]
        [DisplayName("Тип стрелки")]
        public ArrowType ArrowType
        {
            get; set;
        }
        [Category("Вид")]
        [Description("Отвечает за направление стрелки")]
        [DisplayName("Направление стрелки")]
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
                    DeterminingDirection(pen, Arrow.Type1);
                    break;
                case ArrowType.Type2:
                    DeterminingDirection(pen, Arrow.Type2);
                    break;
                case ArrowType.Type3:
                    DeterminingDirection(pen, Arrow.Type3);
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
