using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShapeFactory : IShapeFactory
    {
        public IShape GetShape(Shapes shapeType)
        {

            switch (shapeType)
            {
                case Shapes.RECTANGLE:
                    return new Rectangle();
                case Shapes.SQUARE:
                    return new Square();
                case Shapes.CIRCLE:
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
