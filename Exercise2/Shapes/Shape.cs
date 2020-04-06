using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Shape
    {
        private List<IShape> shapes;
        public Shape()
        {
            shapes = new List<IShape>();
        }
        public void Add(IShape shape)
        {
            shapes.Add(shape);
        }
        public double this[string name]
        {
            get
            {
                double sum = 0.0;
                int count = 0;
                foreach (IShape s in shapes)
                    if (name == s.Name)
                    {
                        sum += s.Area();
                        count++;
                    }
                if (count == 0)
                    throw new ArgumentException("Shape does not contain " +
                    name + "s!");
                return sum / count;
            }
        }
    }
}
