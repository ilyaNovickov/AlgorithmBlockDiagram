using System.Drawing;
using System.Drawing.Drawing2D;

namespace GSAVelLib
{
    /// <summary>
    /// Тип стрелки
    /// </summary>
    public enum ArrowType
    {
        None,//Нет стрелки
        Type1,//Стрелка типа №1
        Type2,//Стрелка типа №2
        Type3,//Стрелка типа №3
    }
    //Внутренный статический класс типа стрелки
    internal static class ArrowTypes
    {
        //Стрелка типа №1
        public static CustomLineCap Type1
        {
            get
            {
                //создание объекта класса GraphicsPath
                GraphicsPath gp = new GraphicsPath();
                //Добавление в грфический путь линий
                gp.AddLine(new Point(-5, -5), new Point(0, 0));
                gp.AddLine(new Point(0, 0), new Point(5, -5));
                //Создание экземпляра класса незакрашенной стрелки
                CustomLineCap type1 = new CustomLineCap(null, gp);
                //Метод задаёт то, что контики стрелки будут закруглены
                type1.SetStrokeCaps(LineCap.Round, LineCap.Round);
                return type1;//Возвращение объекта класса CustomLineCap
            }
        }
        //Стрелка типа №2
        public static CustomLineCap Type2
        {
            get
            {
                //создание объекта класса GraphicsPath
                GraphicsPath gp = new GraphicsPath();
                //Добавление в грфический путь линий
                gp.AddLine(new Point(-5, -5), new Point(0, 0));
                gp.AddLine(new Point(0, 0), new Point(5, -5));
                //Создание экземпляра класса незакрашенной стрелки
                CustomLineCap type2 = new CustomLineCap(null, gp);
                return type2;//Возвращение объекта класса CustomLineCap
            }
        }
        //Стрелка типа №3
        public static AdjustableArrowCap Type3
        {
            get
            {
                //Создание экземпляра класса закрашенной стрелки
                AdjustableArrowCap type3 = new AdjustableArrowCap(8, 8);
                return type3;//Возвращение объекта класса CustomLineCap
            }
        }
    }
}
