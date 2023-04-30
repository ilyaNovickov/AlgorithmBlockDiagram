using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    //Класс блока начала-конца
    [Serializable]//Атрибут сериализации
    public class LogicalBlock : OperationalBlock//Наследование класса OperaitonalBlock
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
                //Иницилизация массива точек, образующих ромб
                Point[] points = new Point[]
                {
                    new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top),
                    new Point(Rectangle.Right, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Bottom),
                    new Point(Rectangle.Left, Rectangle.Top + Rectangle.Height / 2), new Point(Rectangle.Left + Rectangle.Width / 2, Rectangle.Top)
                };
                //Добавление в объект графического пути точек, образующих ромб
                path.AddLines(points);
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
            //Вызов метода рисования текста
            this.DrawString(g);
        }
        #endregion
    }
}
