using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Shapes
{
    class RoundShape : IComparable
    {
        protected Point center;
        protected double radius;

        public RoundShape(int x, int y, double r)
        {
            center = new Point(x, y);
            radius = r;
        }
        // Compare the current object and obj by radius
        public int CompareTo(object obj)
        {
            if (obj == null)
                return 2;
            if (!(obj is RoundShape shape))
                throw new ArgumentException("Object is not a RoundShape");
            return radius.CompareTo(shape.radius);
        }
        public override String ToString()
        {
            return "\tCenter: (" + center.X + ", " + center.Y + "), \tRadius: " + radius;
        }
    }
}
