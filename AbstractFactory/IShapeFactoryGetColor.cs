using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IShapeFactoryGetColor 
    {
        IShapeFactory GetFactoryShape(string Color);

    }
}
