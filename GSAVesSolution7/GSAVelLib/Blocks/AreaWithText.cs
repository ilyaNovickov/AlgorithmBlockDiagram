using System;
using System.Drawing;

namespace GSAVelLib
{
    //Класс текста 
    [Serializable]//Атрибут для сериализации
    public class AreaWithText : IDiagramElement
    {
        #region Данные
        Size minSize;//Минимальный размер
        Size maxSize;//Максимальный размер
        Rectangle rectangle;//Прямоугольник
        string text;//Строка текста
        Font font;//Шрифт
        Color fontColor;//Цвет шрифта
        StringAlignment horizontalAligment;//Горизонтальное выравнивание текста
        StringAlignment verticalAligment;//Вертикальное выравнивание текса
        #endregion
        #region Конструкторы
        //Конструктор класса
        public AreaWithText() : this(Point.Empty)//Вызов конструктора с параметрами
        {
            
        }
        //Конструктор, принимающий точку в качестве аргумента
        public AreaWithText(Point point) : this(new Rectangle(point, new Size(160, 80)))//Вызов конструктора с параметрами
        {

        }
        //Конструктор, принимающий прямоугольник в качестве аргумента
        public AreaWithText(Rectangle rectangle)
        {
            //Иницилизация данных
            this.MaxSize = new Size(300, 300);
            this.MinSize = new Size(10, 10);
            this.Rectangle = rectangle;
            text = "Empty Text";
            fontColor = Color.Black;
            font = new Font("Times New Roman", 12f);
            horizontalAligment = StringAlignment.Center;
            verticalAligment = StringAlignment.Center;
        }
        #endregion
        #region Свойства
        /// <summary>
        /// Положение
        /// </summary>
        public Point Point
        {
            //Метод вовращающий знаение
            get { return rectangle.Location; }
            //Метод устанавливающий положение
            set { rectangle.Location = value; }
        }
        /// <summary>
        /// Минимальный размер
        /// </summary>
        public Size MinSize
        {
            //Метод вовращающий знаение
            get { return minSize; }
            //Метод устанавливающий положение
            set
            {
                //Если устанавливаемый размер отрицательный то выход из метода
                if (value.Width <= 0 || value.Height <= 0)
                    return;
                //Если устанавливаемый размер больше максимального то выход из метода
                if (value.Width > maxSize.Width || value.Height > maxSize.Height)
                    return;
                minSize = value;//Установка значения
            }
        }
        /// <summary>
        /// Максимальный размер
        /// </summary>
        public Size MaxSize
        {
            //Метод вовращающий знаение
            get { return maxSize; }
            //Метод устанавливающий положение
            set
            {
                //Если устанавливаемый размер отрицательный то выход из метода
                if (value.Width <= 0 || value.Height <= 0)
                    return;
                //Если устанавливаемый размер меньше минимального то выход из метода
                if (value.Width < minSize.Width || value.Height < minSize.Height)
                    return;
                maxSize = value;//Установка значения
            }
        }
        /// <summary>
        /// Размер
        /// </summary>
        public Size Size
        {
            //Метод вовращающий знаение
            get { return rectangle.Size; }
            //Метод устанавливающий положение
            set
            {
                //Если ширина устнавливаемого размера меньше минимального
                if (value.Width < minSize.Width)
                    //То установка в него минимальной ширины
                    value.Width = minSize.Width;
                //Иначе если ширина устнавливаемого размера больше максимальной
                else if (value.Width > maxSize.Width)
                    //То установка в него максиамльной ширины
                    value.Width = maxSize.Width;
                //Аналогично для высоты
                if (value.Height < minSize.Height)
                    value.Height = minSize.Height;
                else if (value.Height > maxSize.Height)
                    value.Height = maxSize.Height;
                //Установка размера в прямоугольник
                rectangle.Size = value;
            }
        }
        /// <summary>
        /// Область
        /// </summary>
        public Rectangle Rectangle
        {
            //Метод вовращающий знаение
            get { return rectangle; }
            //Метод устанавливающий положение
            set
            {
                //Установка положения прямоугольника
                rectangle.Location = value.Location;
                //Установка размер прямоугольника
                this.Size = value.Size;
            }
        }
        /// <summary>
        /// Строка текста
        /// </summary>
        public string String
        {
            //Метод возвращающий значение из свойства
            get { return text; }
            //Метод установки в свойство значения
            set { text = value; }
        }
        /// <summary>
        /// Цвет шрифта
        /// </summary>
        public Color FontColor
        {
            //Метод возвращающий значение из свойства
            get { return fontColor; }
            //Метод установки в свойство значения
            set { fontColor = value; }
        }
        /// <summary>
        /// Имя шрифта
        /// </summary>
        public string FontName
        {
            //Метод возвращающий значение из свойства
            get { return font.Name; }
            //Метод установки в свойство значения
            set { font = new Font(value, font.Size); }
        }
        /// <summary>
        /// Размер шрифта
        /// </summary>
        public float FontSize
        {
            //Метод возвращающий значение из свойства
            get { return font.Size; }
            //Метод установки в свойство значения
            set { font = new Font(font.Name, value); }
        }
        /// <summary>
        /// Вертикальное выравнивание текста
        /// </summary>
        public StringAlignment VerticalAligment
        {
            //Метод возвращающий значение из свойства
            get { return verticalAligment; }
            //Метод установки в свойство значения
            set { verticalAligment = value; }
        }
        /// <summary>
        /// Горизонтальное выравнивание текста
        /// </summary>
        public StringAlignment HorizantalAligment
        {
            //Метод возвращающий значение из свойства
            get { return horizontalAligment; }
            //Метод установки в свойство значения
            set { horizontalAligment = value; }
        }
        #endregion
        #region Методы
        /// <summary>
        /// Входит ли точка в область надписи
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public virtual bool IsOnto(Point point)
        {
            return this.Rectangle.Contains(point);
        }
        /// <summary>
        /// Перемещение надписи
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public void Move(int deltaX, int deltaY)
        {
            Point point = this.Point;
            point.Offset(deltaX, deltaY);
            this.Point = point;
        }
        /// <summary>
        /// Рисование надписи
        /// </summary>
        /// <param name="g"></param>
        public virtual void Draw(Graphics g)
        {
            this.DrawString(g);
        }
        protected void DrawString(Graphics g)
        {
            //Если размер - нулевой,
            if (this.Size == Size.Empty)
                //то размер прямоугольной области равень размеру строки
                this.Size = g.MeasureString(this.String, new Font(this.FontName, this.FontSize)).ToSize();
            //Создание экземпляра класса SolidBrush
            using (SolidBrush solidBrush = new SolidBrush(this.FontColor))
            {
                //Рисование строки
                g.DrawString(this.String, new Font(this.FontName, this.FontSize), solidBrush, this.Rectangle,
                    new StringFormat() { Alignment = this.HorizantalAligment, LineAlignment = this.VerticalAligment });
            }
        }
        #endregion
    }
}

