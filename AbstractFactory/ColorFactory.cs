using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ColorFactory : IColorFactory
    {
        public IColor GetColor(Colors color)
        {
            switch (color)
            {
                case Colors.RED:
                    return new Red();
                case Colors.GREEN:
                    return new Green();
                case Colors.BLUE:
                    return new Blue();
                default:
                    return null;
            }
        }
    }
}
