using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akansha_Query
{
    class Program
    {

        const double STRIDE = 2.5;
        const int FEET_PER_MILE = 5280;
        static void Main(string[] args)
        {
            

            int hrs, mins = 0;

            DisplayInstructions();

            int initialStrideCount = GetNumberStrides("first");
            int finalStrideCount = GetNumberStrides("last");
            InputJoggingTime(out hrs, out mins);
            int totalMinutes = CalculateTime(hrs, mins);
            double numberOfStepsPerMin = CalculateAvgSteps(initialStrideCount, finalStrideCount);
            double distanceTraveled = CalculateDistance(numberOfStepsPerMin, totalMinutes);
            DisplayResults(numberOfStepsPerMin, mins, hrs, distanceTraveled);


            Console.ReadKey();
        }

        static void DisplayInstructions()
        {
            Console.WriteLine("This program calculates various values");
        }

        static int GetNumberStrides(string when)
        {
            Console.WriteLine("Enter the number of steps during {0} minute: ", when);
            int numberOfSteps = int.Parse(Console.ReadLine());
            return numberOfSteps;
        }

        static void InputJoggingTime(out int hrs, out int mins)
        {
            Console.WriteLine("Enter the number of hours: ");
            hrs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of mins: ");
            mins = int.Parse(Console.ReadLine());
        }

        static int CalculateTime(int hrs, int mins)
        {
            return hrs * 60 + mins;
        }

        static double CalculateAvgSteps(int initialStrideCount, int finalStrideCount)
        {
            return (initialStrideCount + finalStrideCount) / 2.0;
        }

        static double CalculateDistance(double numberOfStepsPerMin, int totalMinutes)
        {
            return (numberOfStepsPerMin * STRIDE * totalMinutes) / FEET_PER_MILE;
        }

        static void DisplayResults(double numberOfStepsPerMin, int mins, int hrs, double distanceTraveled)
        {
            Console.Clear();
            Console.WriteLine("{0,35}","Jogging Distance Calculator");
            Console.WriteLine();
            Console.WriteLine("{0,-25} {1} Feet Per Step ", "Stride:", STRIDE);
            Console.WriteLine("{0,-25} {1} Steps","Strides Per" + "Minute: ", numberOfStepsPerMin);
            Console.WriteLine("{0,-25} {1} Hour(s) and {2} Minute(s)", "Jogging Time:", hrs, mins);
            Console.WriteLine("{0,-25} {1} Miles", "Distance Travelled:", Math.Round(distanceTraveled,2));
        }

    }
}
