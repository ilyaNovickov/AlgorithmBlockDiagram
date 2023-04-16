using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    //Класс области
    [Serializable]//Атрибут сериализации
    public abstract class Area : ClassWithRect, IDiagramElement//Наследование класса ClassWithRect и интерфейса IDiagramElement
    {
        #region Данные
        int contourThick;//Толщина контура
        Color contourColor;//Цвет контура
        Color fillColor;//Цвет заливки
        DashStyle dashStyle;//Тип контура
        Text text;//Экземпляр класса текста
        #endregion
        #region Конструкторы
        //Внутренный пустой конструктор
        internal Area() : this(new Rectangle(0, 0, 150, 75))//Вызов др конструктора с аргументом
        {

        }
        //Внутренный конструктор, принимающий точку в качестве аргумента
        internal Area(Point point) : this(new Rectangle(point, new Size(150, 75)))//Вызов др конструктора с аргументом
        {

        }
        //Внутренный конструктор, принимающий квадрат в качестве аргумента
        internal Area(Rectangle rectangle)
        {
            //Иницилизация данных
            this.MaxSize = new Size(300, 300);
            this.MinSize = new Size(10, 10);
            this.Rectangle = rectangle;
            this.contourThick = 2;
            this.FillColor = Color.White;
            this.ContourColor = Color.Black;
            this.DashStyle = DashStyle.Solid;
            this.text = new Text()
            {
                String = "Empty Text",
                AutoSize = false,
                Rectangle = this.Rectangle,
                HorizantalAligment = StringAlignment.Center,
                VerticalAligment = StringAlignment.Center
            };
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
            get { return contourColor; }
            //Метод установки в свойство значения
            set { contourColor = value; }
        }
        /// <summary>
        /// Цвет заливки
        /// </summary>
        public Color FillColor
        {
            //Метод возвращающий значение из свойства
            get { return fillColor; }
            //Метод установки в свойство значения
            set { fillColor = value; }
        }
        /// <summary>
        /// Тип контура
        /// </summary>
        public DashStyle DashStyle
        {
            //Метод возвращающий значение из свойства
            get { return dashStyle; }
            //Метод установки в свойство значения
            set { dashStyle = value; }
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
        public StringAlignment HorintalAligment
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
        //Абстрактный метод, входит ли точка внутрь блока
        public abstract bool IsOnto(Point point);
        //Абстрактный метод рисование блока
        public abstract void Draw(Graphics g);
        /// <summary>
        /// Защищённый метод рисования надписи в блоке
        /// </summary>
        /// <param name="g"></param>
        protected void DrawText(Graphics g)
        {
            this.text.Rectangle = this.Rectangle;
            this.text.Draw(g);
        }
        #endregion
    }
}
