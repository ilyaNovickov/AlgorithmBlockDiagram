using System.Drawing;

namespace GSAVelLib
{
    //Интерфейс элемента блок-схемы
    public interface IDiagramElement
    {
        //Свойство квадрата, доступное для чтения
        Rectangle Rectangle { get; }
        //Метод перемещения элемента
        void Move(int deltaX, int deltaY);
        //Входит ли точка в элемент
        bool IsOnto(Point point);
        //Рисование элемента
        void Draw(Graphics g);
    }
}
