using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshQuiz2_002
{
    class Course
    {
        // declaring constant
        private const int NUM_OF_STUDENTS = 10;

        // declaring variables
        private string courseId, courseName;
        private double[] marks = new double[NUM_OF_STUDENTS];

        // default constructor
        public Course() { }

        // parameterised constructor
        public Course(string courseId, string courseName, double[] marks)
        {
            this.courseId = courseId;
            this.courseName = courseName;
            this.marks = marks;
        }

        // getter and setters
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        // getter for the number of students as it will be set in Course class only
        public int NumOfStudents
        {
            get { return NUM_OF_STUDENTS; }
        }

        // methods to get and set array values
        public double GetMarks(int index)
        {
            return marks[index];
        }
        public void SetMarks(double value, int index)
        {
            marks[index] = value;
        }


        // method to calculate average marks
        public double AvgMarks()
        {
            double avgVal = marks.Sum() / NUM_OF_STUDENTS;
            return Math.Round(avgVal,2);
        }

        // method to get lowest marks
        public double LowMarks()
        {
            double lowVal = marks.Min();
            return lowVal;
        }

        // method to format the object output
        public override string ToString()
        {
            double avgMarks = AvgMarks();
            double lowMarks = LowMarks();

            // returning the output for object
            return "Course Id : " + CourseId + " Course name : " + CourseName + "\nAverage marks obtained : " + avgMarks + "\nLowest marks : " + lowMarks;
        }

    }
}
