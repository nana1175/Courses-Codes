using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arshAssignment1_002
{
    class AreaApp
    {
        public static void Main()
        {
			// introductory statements to application
			Console.WriteLine("This application performs computations for three types of different shapes.");
			Console.WriteLine("Four tests will be performed...\n");
			Console.WriteLine("Unique calculations for each shape will be shown.");
			Console.WriteLine("You will be asked to select a shape and enter it's dimensions.\n");
			Console.WriteLine("Press any key when you are ready to begin");

			Console.ReadKey();

			// loop to execute the App tests four times
			for (int i = 0; i < 4; i++)
			{
				DisplayInstructions();
				// to display next text statement only thrice in the output
				if (i <= 2)
                {
					CallMethod();
					Console.WriteLine("Press any key to see the next test...");
					Console.ReadKey();
				}
                else
                {
					CallMethod();
                }			
			}
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}

		// method to provide required details statements
		private static void DisplayInstructions()
        {
			Console.WriteLine("\nPlease select a figure by using the following options:\n");
			Console.WriteLine("   CIRCLE.......enter \'C\'");
			Console.WriteLine("   RECTANGLE....enter \'R\'");
			Console.WriteLine("   CYLINDER.....enter \'Y\'");
			Console.Write("Enter your choice here: ");
		}

		// method to use the choice entered by the user and provide required output from different classes
		private static void CallMethod()
        {
			char choice = char.Parse(Console.ReadLine());
			if (choice == 'C')
			{
				Console.Write("Please enter the Diameter: ");
				double diameter = double.Parse(Console.ReadLine());
				Console.WriteLine("Circle\n");
				// creating object of Circle Class
				Circle cir = new Circle(diameter);
				Console.WriteLine(cir);
			}
			else if (choice == 'R')
			{
				Console.Write("Please enter the Length: ");
				double length = double.Parse(Console.ReadLine());
				Console.Write("Please enter the Width: ");
				double width = double.Parse(Console.ReadLine());
				Console.WriteLine("Rectangle\n");
				// creating object of Rectangle Class
				Rectangle rec = new Rectangle(length, width);
				Console.WriteLine(rec);
			}
			else if (choice == 'Y')
			{
				Console.Write("Please enter the Height: ");
				double height = double.Parse(Console.ReadLine());
				Console.Write("Please enter the Radius: ");
				double radius = double.Parse(Console.ReadLine());
				Console.WriteLine("Cylinder\n");
				// creating object for Cylinder Class
				Cylinder cyl = new Cylinder(radius, height);
				Console.WriteLine(cyl);
			}
			else
			{
				Console.WriteLine("UNACCEPTABLE INPUT");
			}
		}
    }
}
