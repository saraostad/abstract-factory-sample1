using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Circle : IShape
    {
        public int Radius { get; set; }
        public void Draw()
        {
            Console.WriteLine("Circle Draw()");
        }
    }
}
