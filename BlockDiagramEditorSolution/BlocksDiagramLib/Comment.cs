using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    public class Comment : IDiagramElement
    {
        #region Данные
        Text text;
        Rectangle rectangle;
        Size minSize;
        Size maxSize;
        #endregion
        #region Конструкторы
        public Comment()
        {

        }
        #endregion
        #region Свойства
        public bool AutoSize
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

        public void Draw(Graphics g)
        {
            string.Format()
        }
        #endregion
    }
}
