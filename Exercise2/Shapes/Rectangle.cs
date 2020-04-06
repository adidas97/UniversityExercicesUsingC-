using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle : IShape
    {
        public Rectangle(double side, double height)
        {
            Side = side;
            Height = height;
        }
        public string Name
        {
            get { return "Rectangle"; }
        }

        public double Side { get; set; }
        public double Height { get; set; }

        public double Area()
        {
            return Side * Height;
        }
    }
}
