using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AbstractFactory : IShapeFactoryGetColor
    {
        public IShapeFactory GetFactoryShape (string shapeColor)
        {
            switch (shapeColor)
            {
                case "Blue":
                    {
                        return new BlueShapeFactory();
                    }
                case "Red":
                    {
                        return new RedShapeFactory();
                    }
                default:
                    return null;
            }
            
        }
    }
}
