using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle : RoundShape, IShape
    {
        public Circle(int x, int y, double r) : base(x, y, r) { }
        public string Name
        {
            get { return this.GetType().Name; }
        }
         double IShape.Area()
        {
            return Math.PI * Math.Pow(radius, 2.0);
        }
    }
}
