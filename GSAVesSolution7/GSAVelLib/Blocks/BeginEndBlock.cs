using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    //Класс блока начала-конца
    [Serializable]//Атрибут сериализации
    public class BeginEndBlock : OperationalBlock//Наследование класса OperationalBlock
    {
        #region Конструкторы
        //Пустой конструктор
        public BeginEndBlock() : base()//Вызов пустого конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public BeginEndBlock(Point point) : base(point)//Вызов конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public BeginEndBlock(Rectangle rectangle) : base(rectangle)//Вызов конструктора у базового класса
        {

        }
        #endregion
        #region Свойства
        //Внутренный свойство графического пути для рисования блока
        private GraphicsPath GraphicsPath
        {
            get
            {
                //Создание объекта класса GraphicsPAth
                GraphicsPath gp = new GraphicsPath();
                //Если ширина блока больше высоты
                if (Rectangle.Width > Rectangle.Height)
                {
                    //Подсчёт радиуса окружности
                    //Если получается что radius == 0, то в переменную записывается значение 1
                    //Иначе записывается результат вычисления
                    int radius = (int)(0.5 * Rectangle.Height) == 0 ? 1 : (int)(0.5 * Rectangle.Height);
                    //Добавление в объект графического пути линий и дуг
                    gp.AddLine(new Point(Rectangle.Left + radius, Rectangle.Top), new Point(Rectangle.Right - radius, Rectangle.Top));
                    gp.AddArc(new Rectangle(Rectangle.Right - 2 * radius, Rectangle.Top, 2 * radius, 2 * radius), -90, +180);
                    gp.AddLine(new Point(Rectangle.Right - radius, Rectangle.Bottom), new Point(Rectangle.Left + radius, Rectangle.Bottom));
                    gp.AddArc(new Rectangle(Rectangle.Left, Rectangle.Top, 2 * radius, 2 * radius), +90, 180);
                }
                else
                {
                    //Иначе добавление в объект графического пути круга
                    gp.AddEllipse(Rectangle);
                }
                return gp;//Вовращение объекта класса GraphicsPAth
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
            //Рисование закращенного блока
            g.FillPath(solidBrush, this.GraphicsPath);
            //Очистка неуправляемых ресурсов объекта SolidBrush
            solidBrush.Dispose();
            //Создание объекта класса Pen
            Pen pen = new Pen(ContourColor, ContourThick);
            //Установка контура
            pen.DashStyle = DashStyle;
            //Рисование контура блока
            g.DrawPath(pen, this.GraphicsPath);
            //Очистка неуправляемых ресурсов объекта Pen
            pen.Dispose();
            //Вызов метода рисования текста
            this.DrawString(g);
        }
        #endregion
    }
}
