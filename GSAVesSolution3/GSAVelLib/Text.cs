using System;
using System.Drawing;

namespace GSAVelLib
{
    //Класс текста 
    [Serializable]//Атрибут для сериализации
    public class Text : ClassWithRect, IDiagramElement//Наследование класса ClassWithRect и интерфейса IDiagramElement
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
        public Text() : this(Point.Empty)//Вызов конструктора с параметрами
        {
            
        }
        public Text(Point point)
        {
            //Иницилизация данных
            text = "Empty Text";
            fontColor = Color.Black;
            font = new Font("Times New Roman", 12f);
            horizontalAligment = StringAlignment.Center;
            verticalAligment = StringAlignment.Center;
            this.Rectangle = new Rectangle(point, Size.Empty);
            this.MaxSize = new Size(300, 300);
            this.MinSize = new Size(10, 10);
            AutoSize = true;
        }
        #endregion
        #region Свойства
        /// <summary>
        /// Авторазмер
        /// </summary>
        public bool AutoSize
        {
            //Краткие методы свойства
            get; set;
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
        /// Перемещение блока
        /// </summary>
        /// <param name="offsetX">Смещение по оси X</param>
        /// <param name="offsetY">Смещение по оси Y</param>
        public void Move(int offsetX, int offsetY)
        {
            //Создание вспомогательной переменной структуры точки
            Point point = this.Rectangle.Location;
            point.Offset(offsetX, offsetY);//Смещение точки 
            //Установка нового положения
            this.Point = point;
        }
        /// <summary>
        /// Входит ли точка в блок
        /// </summary>
        /// <param name="point">Проверяемая точка</param>
        /// <returns></returns>
        public bool IsOnto(Point point)
        {
            //Возвращает логическое значение содержится ли точка в прямоугольной области
            return this.Rectangle.Contains(point);
        }
        /// <summary>
        /// Входит ли точка в блок
        /// </summary>
        /// <param name="x">Координата по оси X</param>
        /// <param name="y">Координата по оси Y</param>
        /// <returns></returns>
        public bool IsOnto(int x, int y)
        {
            //Вовращает логическое значение содержится ли точка в прямоугольной области
            return this.IsOnto(new Point(x, y));
        }
        /// <summary>
        /// Рисование текста
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            //Если авторазмер включен или размер прямоугольной области равень нулю
            if (AutoSize || this.Size == Size.Empty)
                //Определение размера прямоугольника, в котором будет рисоваться текст 
                this.Size = g.MeasureString(this.String, new Font(this.FontName, this.FontSize)).ToSize();
            //Создание экземпляра класса SolidBrush
            using (SolidBrush solidBrush = new SolidBrush(this.FontColor))
            {
                //Если авторазмер включен
                if (AutoSize)
                    //то рисование текста по его положению
                    g.DrawString(this.String, new Font(this.FontName, this.FontSize), solidBrush, Point);
                else
                    //иначе рисовать текст в прямоугольнике
                    g.DrawString(this.String, new Font(this.FontName, this.FontSize), solidBrush, Rectangle, new StringFormat() { Alignment = this.HorizantalAligment, LineAlignment = this.VerticalAligment });
            }
        }
        #endregion
    }
}

