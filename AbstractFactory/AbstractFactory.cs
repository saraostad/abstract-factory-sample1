using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AbstractFactory : IAbstractFactory
    {
        public IColor GetColor(Colors colorType)
        {
            var colorFactory = new ColorFactory();
            return colorFactory.GetColor(colorType);
        }

        public IShape GetShape(Shapes shapeType)
        {
            var shapeFactory = new ShapeFactory();
            return shapeFactory.GetShape(shapeType);
        }
    }
}
