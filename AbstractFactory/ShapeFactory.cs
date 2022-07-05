using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ShapeFactory : IShapeFactory
    {
        public IShape CreateShape(string shapeType)
        {

            switch (shapeType)
            {
                case "RectangleBlue":
                    return new BlueRectangle();
                case "SQUARE":
                    return new Square();
                case "CIRCLE":
                    return new Circle();
                default:
                    return null;
            }
        }
    }
}
