using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    //Класс операционного блока 
    [Serializable]//Атрибут сериализации
    public class OperationalBlock : AreaWithText, IDiagramElement//Наследование класса Area и интерфейса IDiagramElement
    {
        #region Данные
        int contourThick;//Толщина контура
        #endregion
        #region Конструкторы
        //Пустой конструктор
        public OperationalBlock() : this(Point.Empty)//Вызов пустого конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public OperationalBlock(Point point) : this(new Rectangle(point, new Size(160, 80)))//Вызов конструктора у базового класса
        {

        }
        //Конструктор с аргументом
        public OperationalBlock(Rectangle rectangle) : base(rectangle)//Вызов конструктора у базового класса
        {
            //Иницилизация данных
            this.FillColor = Color.White;
            this.ContourColor = Color.Black;
            this.DashStyle = DashStyle.Solid;
        }
        #endregion
        #region Свойства
        /// <summary>
        /// Толщина контура
        /// </summary>
        public int ContourThick
        {
            //Метод возвращающий значение из свойства
            get { return contourThick; }
            //Метод установки в свойство значения
            set
            {
                //Если устанавливаемое значение меньше 1 
                if (value < 1)
                    //то установка в него значения 1
                    value = 1;
                //Установка значения 
                contourThick = value;
            }
        }
        /// <summary>
        /// Цвет контура
        /// </summary>
        public Color ContourColor
        {
            //Метод возвращающий значение из свойства
            get;
            //Метод установки в свойство значения
            set;
        }
        /// <summary>
        /// Цвет заливки
        /// </summary>
        public Color FillColor
        {
            //Метод возвращающий значение из свойства
            get;
            //Метод установки в свойство значения
            set;
        }
        /// <summary>
        /// Тип контура
        /// </summary>
        public DashStyle DashStyle
        {
            //Метод возвращающий значение из свойства
            get;
            //Метод установки в свойство значения
            set;
        }
        #endregion
        #region Методы
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
            //Вызов метода рисования текста
            this.DrawString(g);
        }
        #endregion
    }
}
