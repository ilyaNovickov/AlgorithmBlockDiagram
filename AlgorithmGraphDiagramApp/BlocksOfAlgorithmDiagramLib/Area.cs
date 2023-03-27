using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    public abstract class Area : IDrawable
    {
        #region static values
        public static readonly int MinWidth = 40;
        public static readonly int MinHeight = 20;
        #endregion
        #region Данные
        Size size;
        #endregion
        #region Конструкторы
        internal Area()
        {
            this.Rectangle = new Rectangle(Point.Empty, new Size(150, 75));
        }
        internal Area(Rectangle rectangle)
        {
            this.Rectangle = rectangle;
        }
        internal Area(Point point, Size size) : this(new Rectangle(point, size))
        {

        }
        internal Area(int x, int y, int width, int height) : this(new Rectangle(x, y, width, height))
        {

        }
        #endregion
        #region Свойства
        [Category("Положение и размер")]
        [Description("Отвечает за положение объекта")]
        [DisplayName("Положение")]
        public Point Point { get; set; }
        [Category("Положение и размер")]
        [Description("Отвечает за размер объекта")]
        [DisplayName("Размер")]
        public Size Size
        {
            get { return size; }
            set
            {
                if (value.Width > MinWidth && value.Height > MinHeight)
                {
                    size = value;
                    return;
                }
                else
                {
                    size = value;
                    if (value.Width < MinWidth)
                        size.Width = MinWidth;
                    if (value.Height < MinHeight)
                        size.Height = MinHeight;
                    return;
                }
            }
        }
        [Category("Положение и размер")]
        [DisplayName("Занимаемая область")]
        [Description("Отвечает за положение и размер объекта")]
        public Rectangle Rectangle
        {
            get { return new Rectangle(Point, Size); }
            set
            {
                this.Size = value.Size;
                this.Point = value.Location;
            }
        }
        #endregion
        #region Методы
        public void Move(int deltaX, int deltaY)
        {
            Point point = this.Point;
            point.Offset(deltaX, deltaY);
            this.Point = point;
        }
        public abstract bool IsOnto(Point point);
        public abstract void Draw(Graphics g);
        public bool IsOnto(int x, int y)
        {
            return IsOnto(new Point(x, y));
        }
        #endregion
    }
}
