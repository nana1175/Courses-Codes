using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arshAssignment1_002
{
    class Rectangle
    {
		private double length, width;

		// default constructor
		public Rectangle() 
		{
			
		}

		// parameterised constructor
		public Rectangle(double len, double wid)
		{
			length = len;
			width = wid;
		}

		// getters and setters
		public double Length
		{
			get { return length; }
			set { length = value; }
		}

		public double Width
		{
			get { return width; }
			set { width = value; }
		}

		// method to calculate area of Rectangle
		public double CalculateArea()
		{
			double areaOfRectangle = Math.Round((Length * Width),2);
			return areaOfRectangle;
		}

		// method to calculate perimeter of Rectangle
		public double CalculatePerimeter()
		{
			double rectanglePerimeter = Math.Round((2 * (Length + Width)),2);
			return rectanglePerimeter;
		}

		// method to calculate diagonals of a Rectangle
		public double CalculateRectangleDiagonals()
		{
			double rectangleDiagonal = Math.Round((Math.Sqrt(Math.Pow(Length, 2) + Math.Pow(Width, 2))),2);
			return rectangleDiagonal;
		}


		// overriding toString method to make a formatted output of the object
		public override string ToString()
		{
			string str;
			str = "Length: " + Length + "\nWidth: " + Width + "\nArea: " + CalculateArea() + "\nPerimeter: " + CalculatePerimeter() + "\nPolygon Diagonal: " + CalculateRectangleDiagonals();
			return str;
		}
}
}
