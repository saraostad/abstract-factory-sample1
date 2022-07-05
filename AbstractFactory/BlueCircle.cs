using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    
    public class BlueCircle : IShape
    {
        public int Code { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }

        public void Generate()
        {
            Console.WriteLine("Blue Circle Generate()");
        }
    }



}
