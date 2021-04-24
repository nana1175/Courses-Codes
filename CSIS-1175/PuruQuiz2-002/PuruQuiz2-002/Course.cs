using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PuruQuiz2_002
{
    class Course
    {

        //declarations
        private string courseID, courseName;
        private double[] arrMarks;
        internal double Marks;

        //def const
        public Course()
        {
        
        }

        //properties of the class
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public double[] ArrMarks { get; set; }

        //param constr
        public Course(string id, string name, double[] marks)
        {
            courseID = id;
            courseName = name;
            arrMarks = new double[10];
            for (int i = 0; i < arrMarks.Length; i++)
            {
                arrMarks[i] = marks[i];
            }
        }

        //method to calculate average marks 
        public double GetAverage()
        {
            double total = 0;
            double average;
            for (int i = 0; i < arrMarks.Length; i++)        //error on this like I couldnt rectiffy
            {
                total += arrMarks[i];
            }
            average = total / 10;
            return average;
        }

        //method to calculate minimun marks outof the array that is passed using the predefined Min()
        public double GetMin()
        {
            var minIndex = arrMarks.Min();

            return minIndex;

        }

        //ToString method to displaying info about the object
        public override string ToString()
        {
            return "Course Id: " + courseID + " \n Average marks obtained " + GetAverage() + " \n Lowest marks: " + GetMin();
        }
    }
}
