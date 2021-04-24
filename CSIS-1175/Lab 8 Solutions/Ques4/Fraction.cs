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
        int num, denom;
        double frac;

        // default constructor
        public Fraction() { }

        // parameterised constructor
        public Fraction(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
        }

        // getter and setter
        public int Num { get; set; }
        public int Denom { get; set; }
        public double Frac
        {
            set { frac = value; }
        }

        // method to calculate fraction
        public void FractionCalculator()
        {
            if (Denom == 0)
                Frac = Convert.ToDouble(Num / Denom);
            else
                Frac = Convert.ToDouble(Num) / Convert.ToDouble(Denom);
        }

        // method to format the object output
        public override string ToString()
        {
            return "Numerator : " + Num + "\nDenominator : " + Denom + "\nFraction Value : " + frac;
        }
    }
}
