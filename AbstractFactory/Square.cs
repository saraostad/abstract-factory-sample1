using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Square : IShape
    {
        public int Width { get; set; }
        public void Draw()
        {
            Console.WriteLine("Square Draw()");
        }
    }
}
