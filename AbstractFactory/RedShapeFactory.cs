using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RedShapeFactory : IShapeFactory
    {
        public IShape CreateShape(string shapeName)
        {
            
            switch (shapeName)
            {
                case "Rectangle":
                    {
                        RedRectangle model = new RedRectangle();
                        model.Code = 1;
                        model.Color = "Blue";
                        model.Model = "BlueRectangle";
                        model.Name = "BlueRectangleName";
                        IShape Imodel = model;
                        return Imodel;
                    }
                    //break;
                case "Circle":
                    {
                        RedCircle model = new RedCircle();
                        model.Code = 1;
                        model.Color = "Blue";
                        model.Model = "BlueCircle";
                        model.Name = "BlueCircleName";
                        IShape Imodel = model;
                        return Imodel;
                    }
                default:
                    {
                        return null;
                    }
                    //break;
            }
        }
    }
}
