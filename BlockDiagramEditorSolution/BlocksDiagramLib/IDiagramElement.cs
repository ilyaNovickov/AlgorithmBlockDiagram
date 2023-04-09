using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocksDiagramLib
{
    public interface IDiagramElement : IDrawable
    {
        Rectangle Rectangle { get; }
        bool IsOnto(Point point);
        bool IsIntersects(Rectangle rectangle);
        void Move(int offsetX, int offsetY);
    }
}
