using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IAbstractFactory
    {
        IShape GetShape(Shapes shapeType);
        IColor GetColor(Colors colorType);
    }
}
