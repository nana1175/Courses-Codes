using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques3
{
    class BMI
    {
        // declaring variables
        double weight, height, bmi;

        // default constructor
        public BMI() { }

        // parameterised constructor
        public BMI(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }

        // getters and setters
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMIVal
        {
            set { bmi = value; }
        }
        // method to calculate BMI based on metric
        public double CalculateBMI()
        {
            double bmiVal = Weight / Math.Pow(Height, 2);
            return Math.Round(bmiVal,2);
        }

        // to make the object output formatted
        public override string ToString()
        {
            return "Weight : " + Weight + "\nHeight : " + Height + "\nBMI : " + bmi;
        }
    }
}
