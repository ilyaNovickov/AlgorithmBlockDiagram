using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BlocksOfAlgorithmDiagramLib
{
    public interface IDiagramElement : IDrawable
    {
        Rectangle Rectangle { get; }
        bool IsOnto(Point point);
        bool IsIntersects(Rectangle rectangle);
    }
}
