using System;
using System.Drawing;

namespace GSAVelLib
{
    //Класс операционного блока 
    [Serializable]//Атрибут сериализации
    public class OperationalBlock : Area//Наследование класса Area
    {
        #region Конструкторы
        //Пустой конструктор
        public OperationalBlock() : base()//Вызов пустого конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public OperationalBlock(Point point) : base(point)//Вызов конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public OperationalBlock(Rectangle rectangle) : base(rectangle)//Вызов конструктора у базового класса
        {

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
            //Возвращает логическое значение содержится ли точка в прямоугольной области
            return this.Rectangle.Contains(point);
        }
        /// <summary>
        /// Рисование блока
        /// </summary>
        /// <param name="g"></param>
        public override void Draw(Graphics g)
        {
            //Создание объекта класса SolidBrush
            SolidBrush solidBrush = new SolidBrush(FillColor);
            //Рисование закращенного прямоугольника
            g.FillRectangle(solidBrush, this.Rectangle);
            //Очистка неуправляемых ресурсов объекта SolidBrush
            solidBrush.Dispose();
            //Создание объекта класса Pen
            Pen pen = new Pen(this.ContourColor, this.ContourThick);
            //Установка контура
            pen.DashStyle = this.DashStyle;
            //Рисование контура прямоугольника
            g.DrawRectangle(pen, this.Rectangle);
            //Очистка неуправляемых ресурсов объекта Pen
            pen.Dispose();
            //Рисование текста
            this.DrawText(g);
        }
        #endregion
    }
}
