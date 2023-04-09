using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BlocksOfAlgorithmDiagramLib
{
    [Serializable]
    public abstract class Shape : AreaWithText
    {
        #region Данные
        int contourThick;
        #endregion 
        #region Конструкторы
        internal Shape() : base()
        {
            DefaultInitilization();
        }
        public Shape(string text) : base(text)
        {
            DefaultInitilization();
        }
        public Shape(string text, Rectangle rectangle) : base(text, rectangle)
        {
            DefaultInitilization();
        }
        public Shape(string text, Point point, Size size) : this(text, new Rectangle(point, size))
        {
            DefaultInitilization();
        }
        public Shape(string text, int x, int y, int width, int heigth) : this(text, new Rectangle(x, y, width, heigth))
        {
            DefaultInitilization();
        }
        public Shape(Point point) : base(point)
        {

        }
        public Shape(int x, int y) : base(x, y)
        {

        }
        private void DefaultInitilization()
        {
            FillColor = Color.White;
            ContourColor = Color.Black;
            ContourThick = 2;
            DashStyle = DashStyle.Solid;
        }
        #endregion
        #region Свойства
        [DisplayName("Цвет заливки")]
        [Category("Вид")]
        [Description("Определяет цвет заливки блока")]
        public Color FillColor
        {
            get; set;
        }
        [DisplayName("Цвет контура")]
        [Category("Вид")]
        [Description("Определяет цвет контура блока")]
        public Color ContourColor
        {
            get; set;
        }
        [DisplayName("Тип контура")]
        [Category("Вид")]
        [Description("Определяет тип контура блока")]
        public DashStyle DashStyle
        {
            get; set;
        }
        [DisplayName("Толщина контура")]
        [Category("Вид")]
        [Description("Определяет толщину контура блока")]
        public int ContourThick
        {
            get { return contourThick; }
            set
            {
                if (value < 1)
                    throw new Exception("Толщина контура не может быть отрицательной");
                contourThick = value;
            }
        }
        #endregion
    }
}
