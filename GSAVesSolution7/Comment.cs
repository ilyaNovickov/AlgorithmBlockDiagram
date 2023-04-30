using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAVelLib
{
    //Класс текстового коментария (надписи)
    [Serializable]//Атрибут сериализации
    public class Comment : IDiagramElement//Наследование интерфейса IDiagramElement
    {
        #region Данные
        Text text;
        Rectangle rectangle;
        Size minSize;
        Size maxSize;
        #endregion
        #region Конструкторы
        //Внутренный пустой конструктор
        public Comment() : this(new Rectangle(0, 0, 150, 75))//Вызов др конструктора с аргументом
        {

        }
        //Внутренный конструктор, принимающий точку в качестве аргумента
        public Comment(Point point) : this(new Rectangle(point, new Size(150, 75)))//Вызов др конструктора с аргументом
        {

        }
        //Внутренный конструктор, принимающий квадрат в качестве аргумента
        public Comment(Rectangle rectangle)
        {
            //Иницилизация данных
            this.MaxSize = new Size(300, 300);
            this.MinSize = new Size(10, 10);
            this.Rectangle = rectangle;
            this.text = new Text()
            {
                String = "Empty Text",
                HorizantalAligment = StringAlignment.Center,
                VerticalAligment = StringAlignment.Center
            };
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
        /// Надпись
        /// </summary>
        public string String
        {
            //Метод возвращающий значение из свойства
            get { return text.String; }
            //Метод установки в свойство значения
            set { text.String = value; }
        }
        /// <summary>
        /// Цвет контура
        /// </summary>
        public Color FontColor
        {
            //Метод возвращающий значение из свойства
            get { return text.FontColor; }
            //Метод установки в свойство значения
            set { text.FontColor = value; }
        }
        /// <summary>
        /// Имя шрифта
        /// </summary>
        public string FontName
        {
            //Метод возвращающий значение из свойства
            get { return text.FontName; }
            //Метод установки в свойство значения
            set { text.FontName = value; }
        }
        /// <summary>
        /// Размер шрифта
        /// </summary>
        public float FontSize
        {
            //Метод возвращающий значение из свойства
            get { return text.FontSize; }
            //Метод установки в свойство значения
            set { text.FontSize = value; }
        }
        /// <summary>
        /// Горизонтальное выравнивание текста
        /// </summary>
        public StringAlignment HorizantalAligment
        {
            //Метод возвращающий значение из свойства
            get { return text.HorizantalAligment; }
            //Метод установки в свойство значения
            set { text.HorizantalAligment = value; }
        }
        /// <summary>
        /// Вертикальное выравнивание текста
        /// </summary>
        public StringAlignment VerticalAligment
        {
            //Метод возвращающий значение из свойства
            get { return text.VerticalAligment; }
            //Метод установки в свойство значения
            set { text.VerticalAligment = value; }
        }
        #endregion
        #region Методы
        /// <summary>
        /// Входит ли точка в область надписи
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsOnto(Point point)
        {
            //Возвращает логическое значение попала ли точка в прямоугольник
            return this.Rectangle.Contains(point);
        }
        /// <summary>
        /// Перемещение надписи
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public void Move(int deltaX, int deltaY)
        {
            //Создание вспомогательной переменной, которая хранит значение положения элемента
            Point point = this.Point;
            //Смещение вспомогательной точки на велечину перемещения
            point.Offset(deltaX, deltaY);
            //Установка нового положения элемента
            this.Point = point;
        }
        /// <summary>
        /// Рисование надписи
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            //Создание экземпляра класса SolidBrush
            using (SolidBrush solidBrush = new SolidBrush(this.FontColor))
                //Рисовние строки внутри прямоугольника
                g.DrawString(this.String, new Font(this.FontName, this.FontSize), solidBrush, this.Rectangle,
                    new StringFormat() { Alignment = this.HorizantalAligment, LineAlignment = this.VerticalAligment });
        }
        #endregion
    }
}
