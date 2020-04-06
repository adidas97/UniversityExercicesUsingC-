using System;
using System.Drawing;

namespace Delegates
{
    class Program
    {
        public static Point PointFToPoint(PointF pf)
        {
            return new Point(((int)pf.X), ((int)pf.Y));
        }
        public static double LitersToGallons(double l)
        {
            return l / 3.7854;
        }
        public static float FahrenheitToCelsius(float f)
        {
            return (f - 32) / 1.8f;
        }
        public static float CelsiusToFahrenheit(float f)
        {
            return f * 1.8f + 32;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Convert from Rational to float\n");
                
                Rational[] ar = { new Rational(1,2), new Rational(1,3), new Rational(1,5) };
                
                Rational r = new Rational();
                Converter<Rational, float> d =
                new Converter<Rational, float>(r.RationalToFloat);
                float[] af = Convert.ConvertAll(ar, d);
                
                for (int i = 0; i < ar.Length; i++)
                    Console.WriteLine(ar[i] + "\t=>\t" + af[i]);
                Console.WriteLine("\nConvert from PointF to Point\n");
               
                PointF[] apf = { new PointF(27.8F, 32.62F), new PointF(99.3F, 147.273F), new PointF(7.5F, 1412.2F) };
                
                Point[] ap = Convert.ConvertAll(apf,
                new Converter<PointF, Point>(PointFToPoint));
                
                for (int i = 0; i < apf.Length; i++)
                    Console.WriteLine(apf[i] + "\t=>\t" + ap[i]);
                Console.WriteLine("\nConvert from Liters to Gallons\n");
                double[] al = { 100, 500, 1000 };
                double[] ag = Convert.ConvertAll(al,
                new Converter<double, double>(LitersToGallons));
                for (int i = 0; i < al.Length; i++)
                    Console.WriteLine(al[i] + "\t=>\t" + ag[i]);
                Console.WriteLine("\nConvert from Fahrenheit to Celsius\n");
                float[] arf = { 500.0f, 800.0f, 32.0f };
                float[] ac = Convert.ConvertAll(arf,
                new Converter<float, float>(FahrenheitToCelsius));
                for (int i = 0; i < arf.Length; i++)
                    Console.WriteLine(arf[i] + "\t=>\t" + ac[i]);
                Console.WriteLine();

                Console.WriteLine("\nConvert from Celsius to Fahrenheit\n");
                float[] cf = Convert.ConvertAll(ac,
               new Converter<float, float>(CelsiusToFahrenheit));
                for (int i = 0; i < arf.Length; i++)
                    Console.WriteLine(ac[i] + "\t=>\t" + cf[i]);

                Console.WriteLine();
                Car car = new Car(120);
                Traffic t = new Traffic(car);
                float a = 10;
                for (int i = 1; i < 21; i++)
                {
                    car.Accelerate(a);
                }

            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
