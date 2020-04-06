using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class Rational
    {
        public int Nominator { get; set; }
        public int Denominator { get; set; }
        public Rational()
        {
            Nominator = 0;
            Denominator = 1;
        }
        public Rational(int nominator, int denominator)
        {
            Nominator = nominator;
            Denominator = denominator;
        }
        public float RationalToFloat(Rational r)
        {
            return (float)r.Nominator / r.Denominator;
        }
        public override string ToString()
        {
            return Nominator + "/" + Denominator;
        }
    }
}
