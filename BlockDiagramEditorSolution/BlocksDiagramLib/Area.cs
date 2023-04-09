using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    [Serializable]
    public abstract class Area : IDiagramElement
    {
        #region Данные
        int contourThick;
        Rectangle rectangle;
        Size minSize;
        Size maxSize;
        Text text;
        #endregion
        #region Конструкторы
        internal Area() : this(new Rectangle(0, 0, 150, 75)) 
        {

        }
        internal Area(Rectangle rectangle)
        {
            this.MinSize = new Size(10, 10);
            this.MaxSize = new Size(300, 300);
            this.rectangle = rectangle;
            this.contourThick = 2;
            this.FillColor = Color.White;
            this.ContourColor = Color.Black;
            this.DashStyle = DashStyle.Solid;
            this.text = new Text();
            this.text.String = "Empty Text";
        }
        internal Area(Point point, Size size) : this(new Rectangle(point, size))
        { 
            
        }
        #endregion
        #region Свойства
        public int ContourThick
        {
            get { return contourThick; }
            set 
            {
                if (value < 1)
                    throw new Exception("Толщина контура не может быть равной нулю или отрицательной");
                contourThick = value;
            }
        }
        public Color ContourColor
        {
            get; set;
        }
        public Color FillColor
        {
            get; set;
        }
        public Size MinSize
        {
            get { return minSize; }
            set
            {
                if (value.Width <= 0 || value.Height <= 0)
                    throw new Exception("Размер не может быть отрицательным или равным нулю");
                if (maxSize.Width > minSize.Width || maxSize.Height > minSize.Height)
                    throw new Exception("Минимальный размер не может быть больше максимального");
                minSize = value;
            }
        }
        public Size MaxSize
        {
            get { return maxSize; }
            set
            {
                if (value.Width <= 0 || value.Height <= 0)
                    throw new Exception("Размер не может быть отрицательным или равным нулю");
                if (maxSize.Width < minSize.Width || maxSize.Height < minSize.Height)
                    throw new Exception("Максимальный размер не может быть меньше минимального");
                maxSize = value;
            }
        }
        private Size Size
        {
            //get { return rectangle.Size; }
            set
            {
                if (value.Width < minSize.Width)
                    value.Width = minSize.Width;
                else if (value.Width > maxSize.Width)
                    value.Width = maxSize.Width;
                if (value.Height < minSize.Height)
                    value.Height = minSize.Height;
                else if (value.Height > maxSize.Height)
                    value.Height = maxSize.Height;
                rectangle.Size = value;
            }
        }
        public Rectangle Rectangle
        {
            get { return rectangle; }
            set 
            { 
                rectangle.Location = value.Location;
                this.Size = value.Size;
            }
        }
        public DashStyle DashStyle
        {
            get; set;
        }
        public string String
        {
            get { return text.String; }
            set { text.String = value; }
        }
        public Color FontColor
        {
            get { return text.FontColor; }
            set { text.FontColor = value; }
        }
        public string FontName
        {
            get { return text.FontName; }
            set { text.FontName = value; }
        }
        public float FontSize
        {
            get { return text.FontSize; }
            set { text.FontSize = value; }
        }
        #endregion
        #region Методы
        public void Move(int offsetX, int offsetY)
        {
            Point point = this.Rectangle.Location;
            point.Offset(offsetX, offsetY);
            this.Rectangle = new Rectangle(point, this.Rectangle.Size);
        }
        public abstract bool IsOnto(Point point);
        public bool IsIntersects(Rectangle rectangle)
        {
            return rectangle.IntersectsWith(this.Rectangle);
        }
        public abstract void Draw(Graphics g);
        protected void DrawText(Graphics g)
        {
            this.text.Draw(g, this.Rectangle);
        }
        #endregion
    }
}
