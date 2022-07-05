using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class BlueShapeFactory : IShapeFactory
    {
        public IShape CreateShape(string shapeName)
        {
            switch (shapeName)
            {
                case "Rectangle":
                    {
                        BlueRectangle model = new BlueRectangle();
                        model.Code = 1;
                        model.Color = "Blue";
                        model.Model = "BlueRectangle";
                        model.Name = "BlueRectangleName";
                        IShape Imodel = model;
                        return Imodel;
                    }
                case "Circle":
                    {
                        BlueCircle model = new BlueCircle();
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
                        //throw new Exception("Value Is Invalid");
                    }
            }
            
        }
    }
}
