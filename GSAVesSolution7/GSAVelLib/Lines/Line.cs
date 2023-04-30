using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    //Класс линии
    [Serializable]//Атрибут сериализации
    public class Line : IDiagramElement//Наследование интерфейса IDiagramElement
    {
        #region Данные
        List<Point> points = new List<Point>();//Список точек
        int contourThick;//Толщина контура
        #endregion
        #region Конструкторы
        //Пустой конструктор
        public Line() : this(new Point(0, 0), new Point(100, 100))//Вызов конструктора с аргументами
        {

        }
        //Конструктор, принимающий две точки в аргумент
        public Line(Point point1, Point point2) : this(new Point[] { point1, point2 })//Вызов конструктора с аргументами
        {

        }
        //Конструктор, принимающий множество точек в качестве аргумента
        public Line(params Point[] points)
        {
            this.points.AddRange(points);
            if (points.Length == 1)
                this.points.Add(new Point(points[0].X + 100, points[0].Y + 100));
            DashStyle = DashStyle.Solid;
            ContourColor = Color.Black;
            contourThick = 2;
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
        /// Тип контура
        /// </summary>
        public DashStyle DashStyle
        {
            //Метод возвращающий значение из свойства
            get;
            //Метод установки в свойство значения
            set;
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
        /// Область, занимаемая линией
        /// </summary>
        public Rectangle Rectangle
        {
            //Метод возвращающий значение из свойства
            get
            {
                //Объявление координат прямоугольника
                int left, right, top, bottom;
                //Иницилизация их первоначальными значениями
                left = points[0].X;
                right = points[0].X;
                top = points[0].Y;
                bottom = points[0].Y;
                //Проход по всем точкам линии
                foreach (Point p in points)
                {
                    //Если точка находится левее
                    if (p.X < left)
                        left = p.X;//то она считается левым краем прямоугольника
                    //Если точка находится правее
                    if (p.X > right)
                        right = p.X;//то она считается правым краем прямоугольника
                    //Если точка находится Ниже
                    if (p.Y > bottom)
                        bottom = p.Y;//то она считается нижней краем прямоугольника
                    //Если точка находится выше
                    if (p.Y < top)
                        top = p.Y;//то она считается высшей краем прямоугольника
                }
                //Возвращение структуры прямоугольника, занимаемой линией
                return new Rectangle(new Point(left, top), new Size(right - left, bottom - top));
            }
        }
        /// <summary>
        /// Количество точек у линии
        /// </summary>
        public int Count
        {
            //Метод возвращающий значение из свойства
            get => points.Count;
        }
        #endregion
        #region Методы
        /// <summary>
        /// Метод добавления точки в конец списка
        /// </summary>
        /// <param name="point"></param>
        public void AddPoint(Point point)
        {
            //Если точка уже содержится в списке
            if (this.Contains(point))
                return;//то выход из метода
            //иначе добавления точки в список
            points.Add(point);
        }
        /// <summary>
        /// Метод добавления точки в конец списка
        /// </summary>
        /// <param name="point"></param>
        public void AddPoint(int x, int y)
        {
            //Вызов метода добавления точки в линию
            AddPoint(new Point(x, y));
        }
        /// <summary>
        /// Метод удаления точки
        /// </summary>
        /// <param name="point"></param>
        public void DeletePoint(Point point)
        {
            //Если кол-во точек меньше или равно 2 в списке точек линии
            if (points.Count <= 2)
                return;//то выход из метода
            //Иначе удаления точки
            points.Remove(point);
        }
        /// <summary>
        /// Метод удаления точки
        /// </summary>
        /// <param name="point"></param>
        public void DeletePoint(int x, int y)
        {
            //Вызов метода удаления точки
            DeletePoint(new Point(x, y));
        }
        /// <summary>
        /// Метод удаления точки по её индексу
        /// </summary>
        /// <param name="index"></param>
        public void DeletePoint(int index)
        {
            //Если кол-во точек меньше или равно 2 в списке точек линии
            if (points.Count <= 2)
                return;//то выход из метода
            //Если индекс удаляемой точки входит в список 
            if (0 <= index && index <= points.Count - 1)
                points.RemoveAt(index);//Удаление точки по её индексу
        }
        /// <summary>
        /// Вставить точку в индекс
        /// </summary>
        /// <param name="point"></param>
        /// <param name="index"></param>
        public void InsertPoint(Point point, int index)
        {
            //Если индекс не входит в список
            if (index < 0 || index > points.Count)
                return;//то выход из метода
            //Если точка уже содержится в списке
            if (this.Contains(point))
                return;//то выход из метода
            //Вставить точку по индексу
            points.Insert(index, point);
        }
        /// <summary>
        /// Вставить точку в индекс
        /// </summary>
        /// <param name="point"></param>
        /// <param name="index"></param>
        public void InsertPoint(int x, int y, int index)
        {
            //Вызов метода вставки точки по индексу
            InsertPoint(new Point(x, y), index);
        }
        //Получение точки по её индексу
        private Point GetPointByIndex(int index)
        {
            //Если индекс входит в список точек
            if (index >= 0 || index < points.Count)
                //то вернуть точку из списка по индексу
                return points[index];
            //Иначе выброс исключения 
            throw new Exception("Выход за границы списка точек");
        }

        /// <summary>
        /// Индексатор для получение и иницилизации точки по её индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Point this[int index]
        {
            //Метод получения точки по индексу
            get { return GetPointByIndex(index); }
            //Метод устанавливающий точку в список точек
            set { points[index] = value; }
        }
        /// <summary>
        /// Получить индекс точки
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public int GetIndexofPoint(Point point)
        {
            //Получение индекса точки
            return points.IndexOf(point);
        }
        /// <summary>
        /// Получение индекса точки через радиус 
        /// </summary>
        /// <param name="point"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public int GetIndexofPoint(Point point, int radius)
        {
            //Если радиус меньше или равень 2
            if (radius <= 2)
                //То выход из метода (точка не найдена)
                return -1;
            //Переворативание списка точек
            points.Reverse();
            //Проход по точка в спике
            foreach (var p in points)
            {
                //Создание прямоугольника, центром которого является нынешная точка
                Rectangle rect = new Rectangle(p.X - radius, p.Y - radius, radius * 2, radius * 2);
                //Если точка содержится в прямоугольнике 
                if (rect.Contains(point))
                {
                    //то перевернуть список точек
                    points.Reverse();
                    //Вернуть индекс точки
                    return points.IndexOf(p);
                }
            }
            //Переворативание списка точек
            points.Reverse();
            //Если точка не найдена, то вернуть -1
            return -1;
        }
        /// <summary>
        /// Получить массив всех точек линии
        /// </summary>
        /// <returns></returns>
        public Point[] GetAllPoints()
        {
            //Возвращение массива точек из списка точек линии
            return points.ToArray();
        }
        /// <summary>
        /// Содержится ли точка в списке линии
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool Contains(Point point)
        {
            //Возвращает лог значение содержится ли точка в списке точек линии
            return points.Contains(point);
        }
        /// <summary>
        /// Входит ли точка в линию по радиусу
        /// </summary>
        /// <param name="point"></param>
        /// <param name="radius"></param>
        /// <returns></returns>
        public bool Contains(Point point, int radius)
        {
            //Если радиус для поиска меньше 3
            if (radius < 3)
                return false;//то точка не содержится в списке
            //Проход по точка в списке в обратном порядке
            foreach (Point p in points.Reverse<Point>())
            {
                //Создание прямоугольника, центром которого является нынешная точка
                Rectangle rect = new Rectangle(p.X - radius, p.Y - radius, radius * 2, radius * 2);
                //Если точка содержится в прямоугольнике 
                if (rect.Contains(point))
                    //Возвращенито того что точка найдена
                    return true;
            }
            //Возвращение того что точка не найдена
            return false;
        }
        /// <summary>
        /// Попадает ли точка на линию
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsOnto(Point point)
        {
            //Создание экземпляра класса GraphicsPath
            GraphicsPath gp = new GraphicsPath();
            //Добавления в графический путь кривой линии по точкам
            gp.AddLines(points.ToArray());
            //Если точка попадает в линию (с учётом её толщены) или попадает в точку
            if (gp.IsOutlineVisible(point, new Pen(ContourColor, ContourThick + 8)) || Contains(point, 5))
                return true;//то точка входит в линию
            //Иначе точка не входит в линию
            return false;
        }
        /// <summary>
        /// Попадает ли точка на линию
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsOnto(int x, int y)
        {
            //Вызов метода попадает ли точка в линию
            return IsOnto(new Point(x, y));
        }
        /// <summary>
        /// Перемещение одной точки
        /// </summary>
        /// <param name="index"></param>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public void MovePoint(int index, int deltaX, int deltaY)
        {
            //Если индекс входит в список
            if (index >= 0 && index < points.Count)
            {
                //Создание вспомогательной точка
                Point point = points[index];
                //Смещение вспомогательной точки
                point.Offset(deltaX, deltaY);
                //Установка нового значения в перемещяемую точку
                points[index] = point;
            }
            //Иначе если индекс равень -1
            else if (index == -1)
            {
                //то выход из метода
                return;
            }
            //Иначе выброс ошибки
            else
            {
                throw new Exception("Выход за границы списка");
            }
        }
        /// <summary>
        /// Перемещение всех точек линии
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public void Move(int deltaX, int deltaY)
        {
            //Проход по всем точка линии
            for (int i = 0; i < points.Count; i++)
            {
                //Вызов метода перемещения точки по индексу
                MovePoint(i, deltaX, deltaY);
            }
        }
        /// <summary>
        /// Рисование линии
        /// </summary>
        /// <param name="g"></param>
        public virtual void Draw(Graphics g)
        {
            //Создание экземпляра класса Pen
            using (Pen pen = new Pen(ContourColor, ContourThick))
            {
                //Установка типа линии
                pen.DashStyle = DashStyle;
                //Рисование кривой линии
                g.DrawLines(pen, this.GetAllPoints());
            }
        }
        #endregion
    }
}
