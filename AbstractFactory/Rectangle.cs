using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Draw()
        {
            Console.WriteLine("Rectangle Draw()");
        }
    }
}
