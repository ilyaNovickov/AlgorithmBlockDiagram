using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GSAVelLib
{
    [Serializable]
    public class Diagram
    {
        #region Данные
        List<IDiagramElement> elements = new List<IDiagramElement>();//Список элементов блок-схемы
        #endregion
        #region Конструкторы
        //Пустой конструктор
        public Diagram()
        {

        }
        #endregion
        #region Свойства
        /// <summary>
        /// Область, занимаемая блок-схемой
        /// </summary>
        public Rectangle Rectangle
        {
	        //Метод получения значения свойства
            get
            {
		        //Если в блок схеме нет элементов
                if (elements.Count == 0)
                    return Rectangle.Empty;//то вернуть пустой прямоугольник
		        //Иначе установить начальные значения верхней, нижней, левой и правой границы прямоугольника
                int top = elements[0].Rectangle.Top;
                int bottom = elements[0].Rectangle.Bottom;
                int left = elements[0].Rectangle.Left;
                int right = elements[0].Rectangle.Right;
		        //Проход по элементам блок-схемы
                foreach (var item in elements)
                {
                    //Если найден более левый край блок-схемы
                    if (item.Rectangle.Left < left)
                        left = item.Rectangle.Left;//то он считается более левым
                    //Если найден более правый край блок-схемы
                    if (item.Rectangle.Right > right)
                        right = item.Rectangle.Right;//то он считается более правый
                    //Если найден более нижний край блок-схемы
                    if (item.Rectangle.Bottom > bottom)
                        bottom = item.Rectangle.Bottom;//то он считается более нижним
                    //Если найден более верхним край блок-схемы
                    if (item.Rectangle.Top < top)
                        top = item.Rectangle.Top;//то он считается более верхним
                }
                //Возврат прямоугольника
                return new Rectangle(left, top, right - left, bottom - top);
            }
        }
        /// <summary>
        /// Количество элементов в блок-схеме
        /// </summary>
        public int Count
        {
            //Метод возврата значения свойства
            get => elements.Count;
        }
        #endregion
        #region Методы
        #region Методы добавления элементов
        /// <summary>
        /// Добавление элемента в блок-схему
        /// </summary>
        /// <param name="element"></param>
        public void AddElement(object element)
        {
            //Если добавляемый элемент относится к типу элемента блок-схемы
            if (element is IDiagramElement)
                //то добавить элемент в блок-схему
                elements.Add((IDiagramElement)element);
        }
        /// <summary>
        /// Добавление линии в блок-схемы
        /// </summary>
        public void AddLine()
        {
            //Добавление линии в блок-схему
            elements.Add(new Line());
        }
        /// <summary>
        /// Добавление линии в блок-схемы
        /// </summary>
        public void AddLine(Line line)
        {
            //Добавление линии в блок-схему
            elements.Add(line);
        }
        /// <summary>
        /// Добавление линии в блок-схемы
        /// </summary>
        public void AddLine(Arrow line)
        {
            //Добавление линии в блок-схему
            elements.Add(line);
        }
        /// <summary>
        /// Добавление операционного блока в блок-схемы
        /// </summary>
        public void AddOperationalBlock()
        {
            //Добавление операционного блока в блок-схему
            elements.Add(new OperationalBlock());
        }
        /// <summary>
        /// Добавление операционного блока в блок-схемы
        /// </summary>
        public void AddOperationalBlock(OperationalBlock operationalBlock)
        {
            //Добавление операционного блока в блок-схему
            elements.Add(operationalBlock);
        }
        /// <summary>
        /// Добавление логического блока в блок-схемы
        /// </summary>
        public void AddLogicalBlock()
        {
            //Добавление логического блока в блок-схему
            elements.Add(new LogicalBlock());
        }
        /// <summary>
        /// Добавление логического блока в блок-схемы
        /// </summary>
        public void AddLogicalBlock(LogicalBlock logicalBlock)
        {
            //Добавление логического блока в блок-схему
            elements.Add(logicalBlock);
        }
        /// <summary>
        /// Добавление блока начала-конца в блок-схемы
        /// </summary>
        public void AddBeginEndBlock()
        {
            //Добавление блока начала-конца в блок-схему
            elements.Add(new BeginEndBlock());
        }
        /// <summary>
        /// Добавление блока начала-конца в блок-схемы
        /// </summary>
        public void AddBeginEndBlock(BeginEndBlock beginEndBlock)
        {
            //Добавление блока начала-конца в блок-схему
            elements.Add(beginEndBlock);
        }
        /// <summary>
        /// Добавления стрелки в блок-схему
        /// </summary>
        public void AddArrow()
        {
            //Добавление стрелки в блок-схему
            elements.Add(new Arrow());
        }
        /// <summary>
        /// Добавления стрелки в блок-схему
        /// </summary>
        public void AddArrow(Arrow lineWithArrow)
        {
            //Добавление стрелки в блок-схему
            elements.Add(lineWithArrow);
        }
        /// <summary>
        /// Добавления комментария в блок-схему
        /// </summary>
        public void AddComment()
        {
            //Добавление комментария в блок-схему
            elements.Add(new Text());
        }
        /// <summary>
        /// Добавления комментария в блок-схему
        /// </summary>
        public void AddComment(Text comment)
        {
            //Добавление комментария в блок-схему
            elements.Add(comment);
        }
        #endregion
        #region Методы удаления элементов
        /// <summary>
        /// Удаление элемента из блок-схемы
        /// </summary>
        /// <param name="element"></param>
        public void DeleteElement(IDiagramElement element)
        {
            //Удаление элемента из блок-схемы
            elements.Remove(element);
        }
        #endregion
        #region Метод вхождения точки
        /// <summary>
        /// Входит ли точка в какой-либо элемент
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool IsOnto(Point point)
        {
            //Проход по списке элементов блок-схемы в обратном порядке
            foreach (var element in elements.Reverse<IDiagramElement>())
            {
                //Если точка входит в элемент, то вернуть true
                if (element.IsOnto(point))
                    return true;
            }
            //иначе вернуть false
            return false;
        }
        /// <summary>
        /// Входит ли точка в какой-либо элемент
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool IsOnto(int x, int y)
        {
            //Вызов метода определяющий входит ли точка в какой-либо элемент
            return IsOnto(new Point(x, y));
        }
        #endregion
        #region Получение элемента схемы
        /// <summary>
        /// Метод получения элемента блок-схемы по точке
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public IDiagramElement GetElement(Point point)
        {
            //Проход по спсику элементов блок-схемы в обратном порядке
            foreach (var element in elements.Reverse<IDiagramElement>())
            {
                //Если точка входит в элемент
                if (element.IsOnto(point))
                    return element;//то вернуть элемент
            }
            //Иначе ничего не возвращать
            return null;
        }
        /// <summary>
        /// Метод получения элемента блок-схемы по точке
        /// </summary>
        /// <param name="point"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool GetElement(Point point, out IDiagramElement element)
        {
            //Проход по спсику элементов блок-схемы в обратном порядке
            foreach (var item in elements.Reverse<IDiagramElement>())
            {
                //Если точка входит в элемент
                if (item.IsOnto(point))
                {
                    element = item;//то вернуть true и этот элемент
                    return true;
                }
            }
            //Иначе вернуть false без элемента
            element = null;
            return false;
        }
        #endregion
        #region Метод перемещения всех элементов
        /// <summary>
        /// Перемещение всех элементов блок-схемы
        /// </summary>
        /// <param name="deltaX"></param>
        /// <param name="deltaY"></param>
        public void MoveAllElements(int deltaX, int deltaY)
        {
            //Проход по всем элементам блок-схемы
            foreach (var element in elements)
            {
                //Переместить элемент
                element.Move(deltaX, deltaY);
            }
        }
        #endregion
        #region Методы рисования
        /// <summary>
        /// Рисование элементов блок-схемы
        /// </summary>
        /// <param name="g"></param>
        public void Draw(Graphics g)
        {
            //Проход по элементам блок-схемы
            foreach (var element in elements)
            {
                //Рисование элемента блок-схемы
                element.Draw(g);
            }
        }
        #endregion
        #endregion
    }
}
