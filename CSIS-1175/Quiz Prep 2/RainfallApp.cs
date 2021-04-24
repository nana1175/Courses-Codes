using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Prep_2
{
    class RainfallApp
    {
        static void Main(string[] args)
        {
            var obj = new Rainfall();
            Console.WriteLine("Enter a year: ");
            obj.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values for the various months of {0} year", obj.Year);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Rainfall for {0} Month:", i + 1);
                double val = double.Parse(Console.ReadLine());
                obj.SetRainfallVal(val, i);
                Console.WriteLine("Enter Month Name for {0} : ", i + 1);
                string str = Console.ReadLine();
                obj.SetMonthName(str, i);
            }
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }
}
