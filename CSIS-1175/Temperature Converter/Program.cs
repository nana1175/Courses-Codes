using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting Input
            Console.Write("Enter the temperature for conversion: ");
            double celTemp = double.Parse(Console.ReadLine());

            // Formula for conversion
            double finalTemp = ((celTemp * 9 / 5) + 32);

            Console.Write("The converted temperature in Fahrenhiet is " + Math.Round(finalTemp, 1));

            Console.ReadKey();
        }
    }
}
