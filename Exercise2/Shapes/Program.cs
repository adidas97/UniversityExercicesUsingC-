using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IShape[] shapes = { new Circle(10, 10, 10), new Sphere(10, 10, 20), new Circle(0, 0, 5) };
            Array.Sort(shapes, 0, 3);
            foreach (IShape shape in shapes)
                Console.WriteLine(shape.Name + "\n" + shape + "\tArea: {0:F3}",
                shape.Area());

            Circle circle = new Circle(10, 10, 10);
            Sphere sphere = new Sphere(10, 10, 10);
            Console.WriteLine(circle.Name + "\n" + circle + "\tArea: {0:F3}",
            ((IShape)circle).Area());
            Console.WriteLine(sphere.Name + "\n" + sphere + "\tArea: {0:F3}",
            ((IShape)sphere).Area());            
            switch (circle.CompareTo(sphere))
            {
                case -1:
                    Console.WriteLine("Circle is less than sphere.");
                    break;
                case 0:
                    Console.WriteLine("Circle is equal to sphere.");
                    break;
                case 1:
                    Console.WriteLine("Circle is greater than sphere.");
                    break;
                case 2:
                    Console.WriteLine("The given object is null.");
                    break;
            }

            Cylinder cylinder = new Cylinder(10, 10, 10);
            // Check for interface implementation with is operator
            if (cylinder is IShape figure)
            {
                Console.WriteLine(figure.Name + "\n" + figure + "\tArea: {0:F3}",
                figure.Area());
            }
            else
                Console.WriteLine("{0} does not implement IShape.",
                cylinder.GetType());

            // Check for interface implementation with as operator
            IShape fig = cylinder as IShape;
            if (null != fig)
            {
                Console.WriteLine(fig.Name + "\n" + fig + "\tArea: {0:F3}",
                fig.Area());
            }
            else
                Console.WriteLine("{0} does not implement IShape.",
                cylinder.GetType());

            Shape s = new Shape();
            s.Add(new Circle(10, 10, 10));
            s.Add(new Sphere(10, 10, 20));
            s.Add(new Circle(0, 0, 5));
            s.Add(new Rectangle(5, 2));
            double meanOfCircles = s["Circle"];
            Console.WriteLine("Mean = {0:F3}", meanOfCircles);
            double meanOfRectangles = s["Rectangle"];
            Console.WriteLine("Mean = {0:F3}", meanOfRectangles);
        }
    }
}
