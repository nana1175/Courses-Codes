using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoggingTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring Constants
            const double STRIDE = 2.5;
            const double FEET_PER_MILE = 5280;

            Console.Write("Number of strides during first minute: ");
            int initialStrideCount = int.Parse(Console.ReadLine());
            Console.Write("Number of strides during last minute: ");
            int finalStrideCount = int.Parse(Console.ReadLine());
            Console.Write("Enter the total jogging time in minutes: ");
            int totalMinutes = int.Parse(Console.ReadLine());
           


            // Getting average number of strides per minutes
            double numberOfStepsPerMin = (Convert.ToDouble(initialStrideCount) + Convert.ToDouble(finalStrideCount) / 2) * STRIDE;


            // Total distance traveled
            double distanceTraveled = ((numberOfStepsPerMin * Convert.ToDouble(totalMinutes)) / FEET_PER_MILE);

            Console.WriteLine("Total distance travelled in miles is {0}", Math.Round(distanceTraveled,2));

            Console.ReadKey();

        }
    }
}
