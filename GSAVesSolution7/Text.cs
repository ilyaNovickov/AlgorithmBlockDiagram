using System;
using System.Drawing;

namespace GSAVelLib
{
    //Класс текста 
    [Serializable]//Атрибут для сериализации
    public class Text 
    {
        #region Данные
        string text;//Строка текста
        Font font;//Шрифт
        Color fontColor;//Цвет шрифта
        StringAlignment horizontalAligment;//Горизонтальное выравнивание текста
        StringAlignment verticalAligment;//Вертикальное выравнивание текса
        #endregion
        #region Конструкторы
        //Конструктор класса
        public Text()
        {
            //Иницилизация данных
            text = "Empty Text";
            fontColor = Color.Black;
            font = new Font("Times New Roman", 12f);
            horizontalAligment = StringAlignment.Center;
            verticalAligment = StringAlignment.Center;
        }
        #endregion
        #region Свойства
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
    }
}

