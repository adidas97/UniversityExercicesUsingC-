using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Sphere : RoundShape, IShape
    {
        public Sphere(int x, int y, double r) : base(x, y, r) { }
        public string Name
        {
            get { return "Sphere"; }
        }
         double IShape.Area()
        {
            return 4 * Math.PI * Math.Pow(radius, 2.0);
        }
    }
}
