using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSAVelLib
{
    //Класс Прямоугольник
    [Serializable]//Атрибут для сериализации
    public abstract class ClassWithRect
    {
        #region Данные
        Size minSize;//Минимальный размер
        Size maxSize;//Максимальный размер
        Rectangle rectangle;//Прямоугольник
        #endregion
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
    }
}
