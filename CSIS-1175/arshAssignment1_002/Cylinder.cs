using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arshAssignment1_002
{
    class Cylinder
    {
		private const double PI = 3.14;
		private double radius, height;

		// default constructor
		public Cylinder()
		{
			
		}

		// paramterised constructor
		public Cylinder(double rad, double hei)
		{
			radius = rad;
			height = hei;
		}
		
		// getters and setters
		public double Radius
		{
			get { return radius; }
			set { radius = value; }
		}

		public double Height
		{
			get { return height; }
			set { height = value; }
		}

		// method to calculate surface area of Cylinder
		public double CalculateSurfaceArea()
		{
			double surfArea = Math.Round((2 * PI * Radius * Height + 2 * PI * Math.Pow(Radius, 2)),2);
			return surfArea;
		}

		// method to calculate volume of Cylinder
		public double CalculateVolume()
		{
			double cylinderVolume = Math.Round((PI * Math.Pow(Radius, 2) * Height),2);
			return cylinderVolume;
		}

		// method to calculate curved surface area of Cylinder
		public double CalculateCurvedSurface()
        {
			double curvedArea = Math.Round((2 * PI * Radius * Height),2);
			return curvedArea;
        }

		// overriding toString method to make a better output of the object
		public override string ToString()
		{
			string str;
			str = "Radius: " + Radius + "\nHeight: " + Height + "\nSurface Area: " + CalculateSurfaceArea() + "\nCurved Surface: " + CalculateCurvedSurface() + "\nVolume: " + CalculateVolume();
			return str;
		}
	}
}
