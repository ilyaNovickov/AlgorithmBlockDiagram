using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    [Serializable]
    public class OperationalBlock : Area
    {
        #region Конструкторы
        public OperationalBlock() : base()
        {
            
        }
        public OperationalBlock(Rectangle rectangle) : base(rectangle)
        {

        }
        #endregion
        #region Методы
        public override bool IsOnto(Point point)
        {
            return this.Rectangle.Contains(point);
        }
        
        public override void Draw(Graphics g)
        {
            SolidBrush solidBrush = new SolidBrush(FillColor);
            g.FillRectangle(solidBrush, this.Rectangle);
            solidBrush.Dispose();
            Pen pen = new Pen(this.ContourColor, this.ContourThick);
            pen.DashStyle = this.DashStyle;
            g.DrawRectangle(pen, this.Rectangle);
            pen.Dispose();
            DrawText(g);
        }
        #endregion
    }
}
