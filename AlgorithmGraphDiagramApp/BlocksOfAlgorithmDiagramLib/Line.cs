using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BlocksOfAlgorithmDiagramLib
{
    public class Line : IDrawable
    {
        #region Данные
        List<Point> points = new List<Point>();
        int contourThick;
        #endregion
        #region Конструкторы
        public Line()
        {
            points.Add(new Point(0, 0));
            points.Add(new Point(50, 50));
            DefaultInitilization();
        }
        public Line(params Point[] points)
        {
            this.points.AddRange(points);
            DefaultInitilization();
        }
        public Line(Color contourColor, int contourThick, params Point[] points)
        {
            this.points.AddRange(points);
            this.contourThick = contourThick;
            this.DashStyle = DashStyle.Solid;
            this.ContourColor = contourColor;
        }
        private void DefaultInitilization()
        {
            this.DashStyle = DashStyle.Solid;
            this.ContourColor = Color.Black;
            this.ContourThick = 2;
        }
        #endregion
        #region Свойства
        [Category("Вид")]
        [Description("Отвечает за тип линии")]
        [DisplayName("Тип линии")]
        public DashStyle DashStyle
        {
            get; set;
        }
        [Category("Вид")]
        [Description("Отвечает за цвет линии")]
        [DisplayName("Цвет линии")]
        public Color ContourColor
        {
            get; set;
        }
        [Category("Вид")]
        [Description("Отвечает за толщину линии")]
        [DisplayName("Толщина линии")]
        public int ContourThick
        {
            get { return contourThick; }
            set
            {
                if (value < 1)
                {
                    contourThick = 1;
                    return;
                }
                contourThick = value;
            }
        }
        [Category("Процее")]
        [Description("Отвечает за прямоугольную область, занимаемую линией")]
        [DisplayName("Занимаемая область")]
        public Rectangle Area
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
        #endregion
        #region Методы
        public void AddPoint(Point point)
        {
            //if (this.Contains(point))
            //    throw new Exception("Такая точка уже содержится в списке");
            if (this.Contains(point))
                return;
            points.Add(point);
        }
        public void AddPoint(int x, int y)
        {
            AddPoint(new Point(x, y));
        }
        public void DeletePoint(Point point)
        {
            points.Remove(point);
        }
        public void DeletePoint(int x, int y)
        {
            points.Remove(new Point(x, y));
        }
        public void DeletePoint(int index)
        {
            points.RemoveAt(index);
        }
        public void InsertPoint(Point point, int index)
        {
            if (index < 0 || index > points.Count)
                throw new Exception("Вставить точку можно только в индексы, входящие в список");
            if (this.Contains(point))
                throw new Exception("Такая точка уже есть в списке");
            points.Insert(index, point);
        }
        public void InsertPoint(int x, int y, int index)
        {
            InsertPoint(new Point(x, y), index);
        }
        public Point GetPointByIndex(int index)
        {
            if (index >= 0 || index < points.Count)
                return points[index];
            throw new Exception("Выход за границы списка точек");
        }
        public Point this[int index]
        {
            get { return GetPointByIndex(index); }
            set { points[index] = value; }
        }
        public int GetIndexofPoint(Point point)
        {
            return points.IndexOf(point);
        }
        public Point[] GetAllPoints()
        {
            return points.ToArray();
        }
        public bool Contains(Point point)
        {
            if (points.Contains(point))
                return true;
            return false;
        }
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
        public void MovePoint(int index, int deltaX, int deltaY)
        {
            if (index >= 0 || index < points.Count)
            {
                Point point = points[index];
                point.Offset(deltaX, deltaY);
                points[index] = point;
            }
            else
            {
                throw new Exception("Выход за границы списка");
            }
        }
        public void MoveAllPoint(int deltaX, int deltaY)
        {
            for (int i = 0; i < points.Count; i++)
            {
                MovePoint(i, deltaX, deltaY);
            }
        }
        public void ReverseList()
        {
            this.points.Reverse();
        }
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
