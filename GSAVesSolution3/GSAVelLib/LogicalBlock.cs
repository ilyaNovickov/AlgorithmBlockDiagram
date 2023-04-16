using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    //Класс блока начала-конца
    [Serializable]//Атрибут сериализации
    public class LogicalBlock : Area//Наследование класса Area
    {
        #region Конструкторы
        //Пустой конструктор
        public LogicalBlock() : base()//Вызов пустого конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public LogicalBlock(Point point) : base(point)//Вызов конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public LogicalBlock(Rectangle rectangle) : base(rectangle)//Вызов конструктора у базового класса
        {

        }
        #endregion
        #region Свойства
        //Внутренный свойство графического пути для рисования ромба
        private GraphicsPath GraphicsPath
        {
            get
            {
                //Создание объекта класса GraphicsPAth
                GraphicsPath path = new GraphicsPath();
                //Добавление в объект графического пути линий, образующий ромб
                path.AddLine(new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top));
                path.AddLine(new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top), new Point(Rectangle.Right, Rectangle.Top + Rectangle.Height / 2));
                path.AddLine(new Point(Rectangle.Right, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Bottom));
                path.AddLine(new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Bottom), new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2));
                path.AddLine(new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top));
                return path;//Вовращение объекта класса GraphicsPAth
            }
        }
        #endregion
        #region Методы
        /// <summary>
        /// Входит ли точка в блок
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public override bool IsOnto(Point point)
        {
            //Возвращает значение входит ли точка в ромб 
            return this.GraphicsPath.IsVisible(point);
        }
        /// <summary>
        /// Рисование блока
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            //Создание объекта класса SolidBrush
            SolidBrush solidBrush = new SolidBrush(FillColor);
            //Рисование закращенного ромба
            g.FillPath(solidBrush, this.GraphicsPath);
            //Очистка неуправляемых ресурсов объекта SolidBrush
            solidBrush.Dispose();
            //Создание объекта класса Pen
            Pen pen = new Pen(ContourColor, ContourThick);
            //Установка контура
            pen.DashStyle = DashStyle;
            //Рисование контура ромба
            g.DrawPath(pen, this.GraphicsPath);
            //Очистка неуправляемых ресурсов объекта Pen
            pen.Dispose();
            //Рисование текста
            DrawText(g);
        }
        #endregion
    }
}
