using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlocksOfAlgorithmDiagramLib
{
    public class Comment : AreaWithText
    {
        #region Конструкторы
        public Comment() : base()
        { 

        }
        public Comment(string text) : base(text)
        {

        }
        public Comment(string text, Rectangle rectangle) : base(text, rectangle)
        {

        }
        public Comment(string text, Point point, Size size) : this(text, new Rectangle(point, size))
        {

        }
        public Comment(string text, int x, int y, int width, int heigth) : this(text, new Rectangle(x, y, width, heigth)) 
        {

        }
        #endregion
        #region Методы
        public override void Draw(Graphics g)
        {
            DrawString(g);
        }
        public override bool IsOnto(Point point)
        {
            if (this.Rectangle.Contains(point))
                return true;
            return false;
        }
        #endregion
    }
}
