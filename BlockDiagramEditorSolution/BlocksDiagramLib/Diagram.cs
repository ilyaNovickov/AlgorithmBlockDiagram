using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlocksDiagramLib
{
    [Serializable]
    public class Diagram
    {
        #region Данные
        List<IDiagramElement> elements = new List<IDiagramElement>();
        #endregion
        #region Конструкторы
        public Diagram()
        {

        }
        #endregion
        #region Свойства
        public Rectangle Rectangle
        {
            get
            {
                if (elements.Count == 0)
                    return Rectangle.Empty;
                int top = elements[0].Rectangle.Top;
                int bottom = elements[0].Rectangle.Bottom;
                int left = elements[0].Rectangle.Left;
                int right = elements[0].Rectangle.Right;
                foreach (var item in elements)
                {
                    if (item.Rectangle.Left < left)
                        left = item.Rectangle.Left;
                    if (item.Rectangle.Right > right)
                        right = item.Rectangle.Right;
                    if (item.Rectangle.Bottom > bottom)
                        bottom = item.Rectangle.Bottom;
                    if (item.Rectangle.Top < top)
                        top = item.Rectangle.Top;
                }
                return new Rectangle(left, top, right - left, bottom - top);
            }
        }
        #endregion
        #region Методы
        #region Методы добавления элементов
        public void AddElement(IDiagramElement element)
        {
            elements.Add(element);
        }
        public void AddElement(Area area)
        {
            elements.Add(area);
        }
        public void AddElement(object obj)
        {
            if (obj is IDiagramElement)
                elements.Add((IDiagramElement)obj);
        }
        public void AddLine()
        {
            elements.Add(new Line());
        }
        public void AddLine(Line line)
        {
            elements.Add(line);
        }
        public void AddLine(Arrow line)
        {
            elements.Add(line);
        }
        public void AddOperationalBlock()
        {
            elements.Add(new OperationalBlock());
        }
        public void AddOperationalBlock(OperationalBlock operationalBlock)
        {
            elements.Add(operationalBlock);
        }
        public void AddLogicalBlock()
        {
            elements.Add(new LogicalBlock());
        }
        public void AddLogicalBlock(LogicalBlock logicalBlock)
        {
            elements.Add(logicalBlock);
        }
        public void AddBeginEndBlock()
        {
            elements.Add(new BeginEndBlock());
        }
        public void AddBeginEndBlock(BeginEndBlock beginEndBlock)
        {
            elements.Add(beginEndBlock);
        }
        public void AddComment()
        {
            elements.Add(new Comment());
        }
        public void AddComment(Comment comment)
        {
            elements.Add(comment);
        }
        public void AddArrow()
        {
            elements.Add(new Arrow());
        }
        public void AddArrow(Arrow lineWithArrow)
        {
            elements.Add(lineWithArrow);
        }
        #endregion
        #region Методы удаления элементов
        public void DeleteElement(IDiagramElement element)
        {
            elements.Remove(element);
        }
        public bool TryDelete(IDiagramElement element)
        {
            return elements.Remove(element);
        }
        public void DeleteRange(IEnumerable<IDiagramElement> elements)
        {
            foreach (var element in elements)
            {
                this.DeleteElement(element);
            }
        }
        #endregion
        #region Методы перемещения блока на передний/задний план
        public void ToForeground(IDiagramElement element)
        {
            if (elements.IndexOf(element) == -1 && elements.IndexOf(element) == elements.Count - 1)
                return;
            IDiagramElement diagElem = elements[elements.IndexOf(element) + 1];
            elements[elements.IndexOf(element) + 1] = element;
            elements[elements.IndexOf(element)] = diagElem;
        }
        public void ToBackground(IDiagramElement element)
        {
            if (elements.IndexOf(element) == -1 && elements.IndexOf(element) == 0)
                return;
            IDiagramElement diagElem = elements[elements.IndexOf(element) - 1];
            elements[elements.IndexOf(element) - 1] = element;
            elements[elements.IndexOf(element)] = diagElem;
        }
        #endregion
        #region Метод вхождения точки
        public bool IsOnto(Point point)
        {
            elements.Reverse();
            foreach (var element in elements)
            {
                if (element.IsOnto(point))
                    return true;
            }
            elements.Reverse();
            return false;
        }
        public bool IsOnto(int x, int y)
        {
            return IsOnto(new Point(x, y));
        }
        public bool IsIntersects(Rectangle rectangle)
        {
            foreach (var element in elements)
            {
                if (element.IsIntersects(rectangle))
                    return true;
            }
            return false;
        }
        public bool IsIntersects(int x, int y, int width, int height)
        {
            return IsIntersects(new Rectangle(x, y, width, height));
        }
        #endregion
        #region Получение элемента схемы
        public IDiagramElement GetElement(Point point)
        {
            elements.Reverse();
            foreach (var element in elements)
            {
                if (element.IsOnto(point))
                {
                    elements.Reverse();
                    return element;
                }
            }
            elements.Reverse();
            return null;
        }
        public List<IDiagramElement> GetElements(Rectangle rectangle)
        {
            List<IDiagramElement> list = new List<IDiagramElement>();
            foreach (var element in elements)
            {
                if (element.IsIntersects(rectangle))
                {
                    list.Add(element);
                }
            }
            return list;
        }
        public bool GetElement(Point point, out IDiagramElement element)
        {
            elements.Reverse();
            foreach (var item in elements)
            {
                if (item.IsOnto(point))
                {
                    element = item;
                    return true;
                }
            }
            elements.Reverse();
            element = null;
            return false;
        }
        #endregion
        #region Метод перемещения всех элементов
        public void MoveElements(int deltaX, int deltaY, IEnumerable<IDiagramElement> elements)
        {
            foreach (var element in elements)
            {
                    if (!this.elements.Contains(element))
                        throw new Exception("Перемещать можно только те элементы, которые содержатся в блок-схеме");
                    element.Move(deltaX, deltaY);
            }
        }
        public void MoveAllElements(int deltaX, int deltaY)
        {
            foreach (var element in elements)
            {
                element.Move(deltaX, deltaY);
            }
        }
        #endregion
        #region Методы рисования
        public void Draw(Graphics g)
        {
            foreach (var element in elements)
            {
                element.Draw(g);
            }
        }
        #endregion
        #endregion
    }
}
