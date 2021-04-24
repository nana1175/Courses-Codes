using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arshAssignment1_002
{
    class Circle
    {
		private const double PI = 3.14;
		private double radius, diameter;

		// default constructor
		public Circle()
		{
			
		}

		// parameterised constructor
		public Circle(double dia)
		{
			diameter = dia;
			radius = diameter / 2;
		}
		
		// getters and setters
		public double Diameter
		{
			get { return diameter; }
			set { diameter = value; }
		}

		public double Radius
		{
			get { return radius; }
			set { radius = value; }
		}

		// method to calculate area of circle
		public double CalculateArea()
		{
			double areaOfCircle = Math.Round((PI * Math.Pow(Radius,2)),2);
			return areaOfCircle;
		}

		// method to calculate circumference of Circle
		public double CalculateCircumference()
		{
			double circleCircumference = Math.Round((2 * PI * Radius),2);
			return circleCircumference;
		}

		// overriding toString method to make a formatted output of the object
		public override string ToString()
		{
			string str;
			str = "Radius: " + Radius + "\nArea: " + CalculateArea() + "\nCircumference: " + CalculateCircumference();
			return str;
		}
	}
}
