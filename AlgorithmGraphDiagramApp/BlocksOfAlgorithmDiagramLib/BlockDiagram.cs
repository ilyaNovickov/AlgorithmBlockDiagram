using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksOfAlgorithmDiagramLib
{
    public class BlockDiagram : IDrawable
    {
        #region Данные
        List<Area> blocks = new List<Area>();
        List<Line> lines = new List<Line>();
        object selectedItem = null;
        object[] selectedItems = null;
        #endregion
        #region Конструкторы
        public BlockDiagram() 
        { 
            
        }
        #endregion
        #region Свойства
        public object SelectedItem
        {
            get { return selectedItem; }
            set 
            {
                if (value == null)
                    selectedItem = null;
                else if (blocks.Contains(value) || lines.Contains(value))
                {
                    if (selectedItems != null)
                        selectedItems = null;
                    selectedItem = value;
                }
                else
                {
                    throw new Exception("Выбрать можно только элемент содержащийся в блок-схема");
                }
                if (selectedItemChange != null)
                    selectedItemChange(this, EventArgs.Empty);
            }
        }
        public object[] SelectedItems
        {
            get { return selectedItems; }
            set 
            {
                if (value == null)
                {
                    selectedItems = null;
                }
                else if (value.Length == 1)
                {
                    SelectedItem = value[0];
                    return;
                }
                else
                {
                    foreach (var item in value)
                    {
                        if (!(blocks.Contains(item) || lines.Contains(item)))
                            throw new Exception("Выбрать можно только элемент содержащийся в блок-схема");
                    }
                    if (selectedItem != null)
                        selectedItem = null;
                    selectedItems = value;
                }
                if (selectedItemChange != null)
                    selectedItemChange(this, EventArgs.Empty);
            }
        }
        public Rectangle Rectangle
        {
            get
            {
                if (blocks.Count == 0 && lines.Count == 0)
                    return Rectangle.Empty;
                int top = 0;
                int bottom = 0;
                int left = 0;
                int right = 0;
                if (blocks.Count != 0)
                {
                    top = blocks[0].Rectangle.Top;
                    bottom = blocks[0].Rectangle.Bottom;
                    left = blocks[0].Rectangle.Left;
                    right = blocks[0].Rectangle.Right;
                }
                else if (lines.Count != 0)
                {
                    top = lines[0].Rectangle.Top;
                    bottom = lines[0].Rectangle.Bottom;
                    left = lines[0].Rectangle.Left;
                    right = lines[0].Rectangle.Right;
                }
                foreach (var item in blocks)
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
                foreach (var line in lines)
                {
                    if (line.Rectangle.Left < left)
                        left = line.Rectangle.Left;
                    if (line.Rectangle.Right > right)
                        right = line.Rectangle.Right;
                    if (line.Rectangle.Bottom > bottom)
                        bottom = line.Rectangle.Bottom;
                    if (line.Rectangle.Top < top)
                        top = line.Rectangle.Top;
                }
                return new Rectangle(left, top, right - left, bottom - top);
            }
        }
        #endregion
        #region События
        event EventHandler selectedItemChange;
        public event EventHandler SelectedItemChanged
        {
            add { selectedItemChange += value; }
            remove { selectedItemChange -= value; }
        }
        #endregion
        #region Методы добавления элементов
        public void AddElement(Area area)
        {
            blocks.Add(area);
        }
        public void AddElement(AreaWithText area)
        {
            blocks.Add(area);
        }
        public void AddElement(object obj)
        {
            if (obj is Area)
                blocks.Add((Area)obj);
            else if (obj is Line)
                lines.Add((Line)obj);
        }
        public void AddLine()
        {
            lines.Add(new Line());
        }
        public void AddLine(Line line) 
        { 
            lines.Add(line);
        }
        public void AddLine(LineWithArrow line)
        {
            lines.Add(line);
        }
        public void AddOperationalBlock()
        {
            blocks.Add(new OperationalBlock());
        }
        public void AddOperationalBlock(OperationalBlock operationalBlock)
        {
            blocks.Add(operationalBlock);
        }
        public void AddLogicalBlock()
        {
            blocks.Add(new LogicalBlock());
        }
        public void AddLogicalBlock(LogicalBlock logicalBlock)
        {
            blocks.Add(logicalBlock);
        }
        public void AddBeginEndBlock()
        {
            blocks.Add(new BeginEndBlock());
        }
        public void AddBeginEndBlock(BeginEndBlock beginEndBlock)
        {
            blocks.Add(beginEndBlock);
        }
        public void AddComment()
        {
            blocks.Add(new Comment());
        }
        public void AddComment(Comment comment)
        {
            blocks.Add(comment);
        }
        public void AddArrow()
        {
            lines.Add(new LineWithArrow());
        }
        public void AddArrow(LineWithArrow lineWithArrow)
        {
            lines.Add(lineWithArrow);
        }
        #endregion
        #region Методы удаления элементов
        public void DeleteElement()
        {
            if (SelectedItem == null)
                return;
            if (blocks.Contains(SelectedItem))
                blocks.Remove((Shape)SelectedItem);
            else if (lines.Contains(SelectedItem))
                lines.Remove((Line)SelectedItem);
        }
        public void DeleteElement(object element)
        {
            if (element is Area)
                blocks.Remove((Area)element);
            else if (element is Line)
                lines.Remove((Line)element);
        }
        public bool TryDelete()
        {
            if (SelectedItem == null) 
                return false;
            if (blocks.Contains(SelectedItem))
            {
                blocks.Remove((Shape)SelectedItem);
                return true;
            }
            else if (lines.Contains(SelectedItem))
            {
                lines.Remove((Line)SelectedItem);
                return true;
            }
            return false;
        }
        public void DeleteRange()
        {
            if (SelectedItems == null)
                return;
            foreach (var item in SelectedItems) 
            {
                if (blocks.Contains(item))
                    blocks.Remove((Shape)item);
                else if (lines.Contains(item))
                    lines.Remove((Line)item);
            }
        }
        public void DeleteRange(object[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                blocks.Remove((Area)elements[i]);
                lines.Remove((Line)elements[i]);
            }
        }
        #endregion
        #region Методы перемещения блока на передний/задний план
        public void ToForeground()
        {
            if (SelectedItem == null)
                return;
            if (blocks.IndexOf((Area)SelectedItem) != blocks.Count - 1 && blocks.IndexOf((Area)SelectedItem) != -1)
            {
                Area sE = blocks[blocks.IndexOf((Area)SelectedItem) + 1];
                blocks[blocks.IndexOf((Area)SelectedItem) + 1] = (Area)SelectedItem;
                blocks[blocks.IndexOf((Area)SelectedItem)] = sE;
            }
            else if (lines.IndexOf((Line)SelectedItem) != lines.Count - 1 && lines.IndexOf((Line)SelectedItem) != -1)
            {
                Line sE = lines[lines.IndexOf((Line)SelectedItem) + 1];
                lines[lines.IndexOf((Line)SelectedItem) + 1] = (Line)SelectedItem;
                lines[lines.IndexOf((Line)SelectedItem)] = sE;
            }

        }
        public void ToBackground()
        {
            if (SelectedItem == null) 
                return;
            if (blocks.IndexOf((Area)SelectedItem) != 0 && blocks.IndexOf((Area)SelectedItem) != -1)
            {
                Area sE = blocks[blocks.IndexOf((Area)SelectedItem) - 1];
                blocks[blocks.IndexOf((Area)SelectedItem) - 1] = (Area)SelectedItem;
                blocks[blocks.IndexOf((Area)SelectedItem)] = sE;
            }
            else if (lines.IndexOf((Line)SelectedItem) != 0 && lines.IndexOf((Line)SelectedItem) != -1)
            {
                Line sE = lines[lines.IndexOf((Line)SelectedItem) - 1];
                lines[lines.IndexOf((Line)SelectedItem) - 1] = (Line)SelectedItem;
                lines[lines.IndexOf((Line)SelectedItem)] = sE;
            }
        }
        #endregion
        #region Метод вхождения точки
        public bool IsOnto(Point point)
        {
            blocks.Reverse();
            foreach (var block in blocks) 
            {
                if (block.IsOnto(point)) 
                    return true;
            }
            blocks.Reverse();
            lines.Reverse();
            foreach (var line in lines)
            {
                if (line.IsOnto(point))
                    return true;
            }
            lines.Reverse();
            return false;
        }
        public bool IsOnto(int x, int y)
        {
            return IsOnto(new Point(x, y));
        }
        public bool IsIntersects(Rectangle rectangle)
        {
            foreach (var block in blocks)
            {
                if (rectangle.IntersectsWith(block.Rectangle))
                    return true;
            }
            foreach (var line in lines)
            {
                if (line.IsIntersects(rectangle))
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
        public object GetElement(Point point)
        {
            blocks.Reverse();
            foreach (var block in blocks)
            {
                if (block.IsOnto(point))
                {
                    blocks.Reverse();
                    return block;
                }
            }
            blocks.Reverse();
            lines.Reverse();
            foreach (var line in lines)
            {
                if (line.Contains(point))
                { 
                    lines.Reverse();
                    return line;
                }
            }
            lines.Reverse();
            return null;
        }
        public List<object> GetElements(Rectangle rectangle)
        {
            List<object> list = new List<object>();
            foreach (var block in blocks)
            {
                if (rectangle.IntersectsWith(block.Rectangle))
                    list.Add(block);
            }
            foreach (var line in lines)
            {
                if (line.IsIntersects(rectangle))
                    list.Add(line);
            }
            return list;
        }
        public bool GetElement(Point point, out object element)
        {
            blocks.Reverse();
            foreach (var block in blocks)
            {
                if (block.IsOnto(point))
                {
                    blocks.Reverse();
                    element = block;
                    return true;
                }
            }
            blocks.Reverse();
            lines.Reverse();
            foreach (var line in lines)
            {
                if (line.IsOnto(point))
                {
                    lines.Reverse();
                    element = line;
                    return true;
                }
            }
            lines.Reverse();
            element = null;
            return false;
        }
        #endregion
        #region Метод перемещения всех элементов
        public void MoveElements(int deltaX, int deltaY, object[] elements)
        {
            foreach (var element in elements)
            {
                if (element is Area)
                {
                    if (!blocks.Contains(element))
                        throw new Exception("Перемещать можно только те элементы, которые содержатся в блок-схеме");
                    ((Area)(element)).Move(deltaX, deltaY);
                }
                else if (element is Line)
                {
                    if (!lines.Contains(element))
                        throw new Exception("Перемещать можно только те элементы, которые содержатся в блок-схеме");
                    ((Line)(element)).MoveAllPoints(deltaX, deltaY);
                }
            }
        }
        public void MoveAllElements(int deltaX, int deltaY)
        {
            foreach (var block in blocks)
            {
                block.Move(deltaX, deltaY);
            }
            foreach (var line in lines)
            {
                line.MoveAllPoints(deltaX, deltaY);
            }
        }
        #endregion
        #region Методы рисования
        public void Draw(Graphics g)
        {
            //blocks.Reverse();
            //lines.Reverse();
            foreach (var line in lines)
            {
                line.Draw(g);
                //if (SelectedItem != null && line == SelectedItem)
                //{
                //    DrawSelectedLine(g, line);
                //}
                //else if (SelectedItems != null && SelectedItems.Contains((object)line))
                //{
                //    DrawSelectedLine(g, line);
                //}
            }
            foreach (var element in blocks)
            {
                element.Draw(g);
            //    if (SelectedItem != null && element == SelectedItem)
            //    {
            //        DrawSelectedArea(g, element);
            //    }
            //    else if (SelectedItems != null && SelectedItems.Contains((object)element))
            //    {
            //        DrawSelectedArea(g, element);
            //    }
            }
            //blocks.Reverse();
            //lines.Reverse();
        }
        //private void DrawSelectedLine(Graphics g, Line line)
        //{
        //    Rectangle[] rectangles = new Rectangle[line.GetAllPoints().Length];
        //    for (int i = 0; i < line.GetAllPoints().Length; i++)
        //    {
        //        rectangles[i] = new Rectangle(line[i].X - 5, line[i].Y - 5, 10, 10);
        //    }
        //    SolidBrush solidBrush = new SolidBrush(Color.Blue);
        //    g.FillRectangles(solidBrush, rectangles);
        //    solidBrush.Dispose();
        //    Pen pen = new Pen(Color.Black);
        //    pen.Width = 2;
        //    g.DrawRectangles(pen, rectangles);
        //    pen.Dispose();
        //}
        //private void DrawSelectedArea(Graphics g, Area area)
        //{
        //    Pen pen = new Pen(Color.Black);
        //    pen.DashStyle = DashStyle.DashDot;
        //    g.DrawRectangle(pen, area.Rectangle);
        //    pen.Dispose();

        //}
        #endregion
    }
}
