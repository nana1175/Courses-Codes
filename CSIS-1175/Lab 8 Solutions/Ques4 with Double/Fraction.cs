using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques4
{
    class Fraction
    {
        // declaration of variables
        double num, denom;
        double frac;

        // default constructor
        public Fraction() { }

        // parameterised constructor
        public Fraction(double num, double denom)
        {
            this.num = num;
            this.denom = denom;
        }

        // getter and setter
        public double Num { get; set; }
        public double Denom { get; set; }
        

        // method to calculate fraction
        public double FractionCalculator()
        {
            frac = Num / Denom;
            return frac;
        }

        // method to format the object output
        public override string ToString()
        {
            return "Numerator : " + Num + "\nDenominator : " + Denom + "\nFraction Value : " + frac;
        }
    }
}
