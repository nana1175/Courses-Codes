using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Prep_2
{
    class Rainfall
    {
        // declaring constant
        private const int NUM_OF_MONTHS = 3;

        // declaring variables
        private int year;
        private double[] rainfallVal = new double[NUM_OF_MONTHS];
        private string[] monthName = new string[NUM_OF_MONTHS];

        // default constructor
        public Rainfall() { }

        // parameterised constructor
        public Rainfall(int year, double[] rainVal)
        {
            this.year = year;
            this.rainfallVal = rainVal;
        }

        // getter and setter
        public int Year { get; set; }
        public double[] RainfallVal { get; set; }

        // array getter and setter
        public double GetRainfallVal(int index)
        {
            return rainfallVal[index];
        }
        public void SetRainfallVal(double value, int index)
        {
            rainfallVal[index] = value;
        }
        public string GetMonthName(int index)
        {
            return monthName[index];
        }
        public void SetMonthName(string val, int index)
        {
            monthName[index] = val;
        }
        // calculating average of values in rainfall array
        public double RainfallAvg()
        {
            double avgVal = rainfallVal.Sum() / NUM_OF_MONTHS;
            return avgVal;
        }

        // checking for month with most rain
        public double MaxRainfall()
        {
            double maxVal = rainfallVal.Max();
            return maxVal;
        }

        // creating a formatted string for the object 
        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < NUM_OF_MONTHS; i++)
            {
                double val = GetRainfallVal(i);
                string val1 = GetMonthName(i);
                str = str + "Rainfall in " + i + "month is " + val + " Month Name is " + val1 + "\n";
            }
            double avg = RainfallAvg();
            return str + "Average Value is " + avg;
        }

    }
}
