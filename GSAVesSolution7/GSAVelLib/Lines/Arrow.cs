using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    /// <summary>
    /// Направление стрелки
    /// </summary>
    public enum Direction
    {
        To,//Направление в одну сторону
        From,//Направление в другую сторону
        Bidertional//Направление в обе стороны
    }
    //Класс линии
    [Serializable]//Атрибут сериализации
    public class Arrow : Line//Наследование класса Line
    {
        #region Конструкторы
        //Пустой конструктор
        public Arrow() : this(new Point(0, 0), new Point(100, 100))//Вызов конструктора с аргументами
        {

        }
        //Конструктор, принимающий две точки в аргумент
        public Arrow(Point point1, Point point2) : this(new Point[] { point1, point2 })//Вызов конструктора с аргументами
        {

        }
        //Конструктор, принимающий множество точек в качестве аргумента
        public Arrow(params Point[] points) : base(points)//Вызов конструктора у базового класса
        {
            //Иницилизация данных
            this.ArrowType = ArrowType.Type1;
            this.Direction = Direction.To;
        }
        #endregion
        #region Свойства
        /// <summary>
        /// Тип стрелки
        /// </summary>
        public ArrowType ArrowType
        {
            //Метод возвращающий значение из свойства
            get;
            //Метод установки в свойство значения
            set;
        }
        /// <summary>
        /// Направление стрелки
        /// </summary>
        public Direction Direction
        {
            //Метод возвращающий значение из свойства
            get;
            //Метод установки в свойство значения
            set;
        }
        #endregion
        #region Методы
        /// <summary>
        /// Рисование стрелки
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            //Создание экхемпляра класса Pen
            Pen pen = new Pen(ContourColor, ContourThick);
            //Установка типа линии
            pen.DashStyle = DashStyle;
            //Выбор между типами стрелки
            switch (ArrowType)
            {
                //Если стрелки нет, то выход из выбора
                case ArrowType.None:
                    break;
                //Если выбран тип №1
                case ArrowType.Type1:
                    //Определение направления стрелки
                    DeterminingDirection(pen, ArrowTypes.Type1);
                    break;
                //Если выбран тип №2
                case ArrowType.Type2:
                    //Определение направления стрелки
                    DeterminingDirection(pen, ArrowTypes.Type2);
                    break;
                //Если выбран тип №3
                case ArrowType.Type3:
                    //Определение направления стрелки
                    DeterminingDirection(pen, ArrowTypes.Type3);
                    break;
            }
            //Рисование кривой линии п оточкам
            g.DrawLines(pen, this.GetAllPoints());
            //Освобождение неуправляемых ресурсов класса Pen
            pen.Dispose();
        }
        //Определение направления стрелки
        private void DeterminingDirection(Pen pen, CustomLineCap customLineCap)
        {
            //Выбор между направлениями стрелки
            switch (Direction)
            {
                //Если направлено в одну сторону
                case Direction.To:
                    //Установка того, что линия закончится стрелкой
                    pen.CustomEndCap = customLineCap;
                    break;
                //Если направлено в другую сторону
                case Direction.From:
                    //Установка того, что линия начнётся стрелкой
                    pen.CustomStartCap = customLineCap;
                    break;
                //Если направлено в обе стороны
                case Direction.Bidertional:
                    //Установка того, что линия закончится и начнётся стрелкой
                    pen.CustomStartCap = customLineCap;
                    pen.CustomEndCap = customLineCap;
                    break;
            }
        }
        #endregion
    }
}
