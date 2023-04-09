using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    [Serializable]
    public abstract class Area : IDiagramElement
    {
        #region Данные
        Size size;
        [NonSerialized]
        int minWidth = 40;
        [NonSerialized]
        int minHeight = 20;
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
        internal Area(Point point) : this(new Rectangle(point.X, point.Y, 150, 75))
        {

        }
        internal Area(int x, int y) : this(new Rectangle(x, y, 150, 75))
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
                if (value.Width > minWidth && value.Height > minHeight)
                {
                    size = value;
                    return;
                }
                else
                {
                    size = value;
                    if (value.Width < minWidth)
                        size.Width = minWidth;
                    if (value.Height < minHeight)
                        size.Height = minHeight;
                    return;
                }
            }
        }
        [Category("Положение и размер")]
        [Description("Отвечает за минимальную ширину объекта")]
        [DisplayName("Минимальная ширина")]
        public int MinWidth
        {
            get { return minWidth; }
            set 
            {
                if (value < 0)
                    throw new Exception("Размер не может быть отрицательным");
                minWidth = value;
            }
        }
        [Category("Положение и размер")]
        [Description("Отвечает за минимальную высоту объекта")]
        [DisplayName("Минимальная высота")]
        public int MinHeight
        {
            get { return minHeight; }
            set
            {
                if (value < 0)
                    throw new Exception("Размер не может быть отрицательным");
                minHeight = value;
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
        public bool IsIntersects(Rectangle rectangle)
        {
            if (rectangle.IntersectsWith(this.Rectangle))
                return true;
            return false;
        }
        public bool IsIntersects(int x, int y, int width, int height)
        {
            return IsIntersects(new Rectangle(x, y, width, height));
        }
        #endregion
    }
}
