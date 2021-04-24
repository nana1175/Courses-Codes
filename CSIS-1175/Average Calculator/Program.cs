using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many values need to be entered for calculation: ");
            int limitValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values for calculating average: ");

            // Getting input
            List<double> numbers = new List<double>();
            for (int i = 0; i < limitValue; i++)
            {
                numbers.Add(double.Parse(Console.ReadLine()));
            }

            double sumValue = 0.0;

            for(int i = 0; i < limitValue; i++)
            {
                sumValue = numbers[i] + sumValue;
            }

            double avgValue = sumValue / limitValue;


            Console.WriteLine("The average value is calculated and the result is " + Math.Round(avgValue, 2));

            Console.ReadKey();

        }
    }
}
