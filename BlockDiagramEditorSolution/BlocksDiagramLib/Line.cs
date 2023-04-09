using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    [Serializable]
    public class Line : IDiagramElement
    {
        #region Данные
        List<Point> points = new List<Point>();
        int contourThick;
        #endregion
        #region Конструкторы
        public Line() : this(new Point(0, 0), new Point(100, 100))
        {

        }
        public Line(Point point1, Point point2) : this(new Point[] { point1, point2})
        {

        }
        public Line(params Point[] points)
        {
            this.points.AddRange(points);
            DashStyle = DashStyle.Solid;
            contourThick = 2;
        }
        #endregion
        #region Свойства
        public int ContourThick
        {
            get { return contourThick; }
            set
            {
                if (value < 1)
                    throw new Exception("Толщина контура не может быть равной нулю или отрицательной");
                contourThick = value;
            }
        }
        public DashStyle DashStyle
        {
            get; set;
        }
        public Color ContourColor
        {
            get; set;
        }
        public Rectangle Rectangle
        {
            get
            {
                int left, right, top, bottom;
                left = points[0].X;
                right = points[0].X;
                top = points[0].Y;
                bottom = points[0].Y;
                foreach (Point p in points)
                {
                    if (p.X < left)
                        left = p.X;
                    if (p.X > right)
                        right = p.X;
                    if (p.Y > bottom)
                        bottom = p.Y;
                    if (p.Y < top)
                        top = p.Y;
                }
                return new Rectangle(new Point(left, top), new Size(right - left, bottom - top));
            }
        }
        public int Count
        {
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
            if (this.Contains(point))
                return;
            points.Add(point);
        }
        /// <summary>
        /// Метод добавления точки в конец списка
        /// </summary>
        /// <param name="point"></param>
        public void AddPoint(int x, int y)
        {
            AddPoint(new Point(x, y));
        }
        /// <summary>
        /// Метод удаления точки
        /// </summary>
        /// <param name="point"></param>
        public void DeletePoint(Point point)
        {
            if (points.Count < 2)
                return;
            points.Remove(point);
        }
        /// <summary>
        /// Метод удаления точки
        /// </summary>
        /// <param name="point"></param>
        public void DeletePoint(int x, int y)
        {
            if (points.Count < 2)
                return;
            points.Remove(new Point(x, y));
        }
        /// <summary>
        /// Метод удаления точки по её индексу
        /// </summary>
        /// <param name="index"></param>
        public void DeletePoint(int index)
        {
            if (points.Count < 2)
                return;
            if (0 <= index && index <= points.Count - 1)
                points.RemoveAt(index);
        }
        /// <summary>
        /// Вставить точку в индекс
        /// </summary>
        /// <param name="point"></param>
        /// <param name="index"></param>
        public void InsertPoint(Point point, int index)
        {
            if (index < 0 || index > points.Count)
                throw new Exception("Вставить точку можно только в индексы, входящие в список");
            if (this.Contains(point))
                throw new Exception("Такая точка уже есть в списке");
            points.Insert(index, point);
        }
        /// <summary>
        /// Вставить точку в индекс
        /// </summary>
        /// <param name="point"></param>
        /// <param name="index"></param>
        public void InsertPoint(int x, int y, int index)
        {
            InsertPoint(new Point(x, y), index);
        }
        //Получение точки по её индексу
        private Point GetPointByIndex(int index)
        {
            if (index >= 0 || index < points.Count)
                return points[index];
            throw new Exception("Выход за границы списка точек");
        }

        /// <summary>
        /// Индесатор для получение и иницилизации точки по её индексу
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Point this[int index]
        {
            get { return GetPointByIndex(index); }
            set { points[index] = value; }
        }
        /// <summary>
        /// Получить индекс точки
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public int GetIndexofPoint(Point point)
        {

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
            if (radius <= 2)
                return -1;
            points.Reverse();
            foreach (var p in points)
            {
                Rectangle rect = new Rectangle(p.X - radius, p.Y - radius, radius * 2, radius * 2);
                if (rect.Contains(point))
                {
                    points.Reverse();
                    return points.IndexOf(p);
                }
            }
            points.Reverse();
            return -1;
        }
        /// <summary>
        /// Получить массив всех точек линии
        /// </summary>
        /// <returns></returns>
        public Point[] GetAllPoints()
        {
            return points.ToArray();
        }
        /// <summary>
        /// Содержится ли точка в списке линии
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool Contains(Point point)
        {
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
            if (radius < 3)
                return false;
            foreach (Point p in points)
            {
                Rectangle rect = new Rectangle(p.X - radius, p.Y - radius, radius * 2, radius * 2);
                if (rect.Contains(point))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Попадает ли точка на линию
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsOnto(Point point)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddLines(points.ToArray());
            if (gp.IsOutlineVisible(point, new Pen(ContourColor, ContourThick + 8)) || Contains(point, 5))
                return true;
            return false;
        }
        /// <summary>
        /// Попадает ли точка на линию
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsOnto(int x, int y)
        {
            return IsOnto(new Point(x, y));
        }
        /// <summary>
        /// Пересекается ли линия прямоугольником
        /// </summary>
        /// <param name="rectangle"></param>
        /// <returns></returns>
        public bool IsIntersects(Rectangle rectangle)
        {
            if (rectangle.Width < 2 && rectangle.Height < 2)
                return false;
            for (int i = 0; i < points.Count - 1; i++)
            {
                Point point1 = points[i];
                Point point2 = points[i + 1];
                if (rectangle.Contains(point1) || rectangle.Contains(point2))
                    return true;
                return IsIntersects(point1, point2, new Point(rectangle.Left, rectangle.Top), new Point(rectangle.Right, rectangle.Top)) ||
                        IsIntersects(point1, point2, new Point(rectangle.Right, rectangle.Top), new Point(rectangle.Right, rectangle.Bottom)) ||
                        IsIntersects(point1, point2, new Point(rectangle.Right, rectangle.Bottom), new Point(rectangle.Left, rectangle.Bottom)) ||
                        IsIntersects(point1, point2, new Point(rectangle.Left, rectangle.Bottom), new Point(rectangle.Left, rectangle.Top));
            }
            return false;
        }
        //Метод пересечения 2-х линий по их точкам
        private bool IsIntersects(Point point1, Point point2, Point point3, Point point4)
        {
            //https://www.interestprograms.ru/source-codes-peresechenie-dvuh-otrezkov?ysclid=lfwuy9mt8x232048297
            double v1 = point2.X - point1.X;
            double w1 = point2.Y - point1.Y;
            double v2 = point4.X - point3.X;
            double w2 = point4.Y - point3.Y;
            double t34 = (v1 * (point1.Y - point3.Y) + w1 * (point3.X - point1.X))
                /
                (v1 * w2 - w1 * v2);
            double t12 = (point3.X - point1.X + v2 * t34) / v1;
            return (0 <= t12 && t12 <= 1 && 0 <= t34 && t34 <= 1);
        }
        /// <summary>
        /// Перемещение одной точки
        /// </summary>
        /// <param name="index"></param>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public void MovePoint(int index, int deltaX, int deltaY)
        {
            if (index >= 0 && index < points.Count)
            {
                Point point = points[index];
                point.Offset(deltaX, deltaY);
                points[index] = point;
            }
            else if (index == -1)
            {
                return;
            }
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
            for (int i = 0; i < points.Count; i++)
            {
                MovePoint(i, deltaX, deltaY);
            }
        }
        /// <summary>
        /// Перевернуть список
        /// </summary>
        public void ReverseList()
        {
            this.points.Reverse();
        }
        /// <summary>
        /// Рисование линии
        /// </summary>
        /// <param name="g"></param>
        public virtual void Draw(Graphics g)
        {
            using (Pen pen = new Pen(ContourColor, ContourThick))
            {
                pen.DashStyle = DashStyle;
                g.DrawLines(pen, points.ToArray());
            }
        }
        #endregion
    }
}
