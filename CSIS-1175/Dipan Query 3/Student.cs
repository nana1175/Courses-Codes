using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dipan_Query_3
{
    class Student
    {
        // declaring variables
        string studentName;
        double[] studentGrades = new double[10];
        double studentGPA;

        // public constructor
        public Student() { }

        // parameterised constructor
        // parameter is the number of courses
        public Student(int num)
        {
            studentGrades = new double[num];
        }


        // getter and setters
        public string StudentName {get; set;}
        public float StudentGPA { get; set; }

        public double GetGrades(int index)
        {
            return studentGrades[index];
        }
        public void SetGrades(double value, int index)
        {
            studentGrades[index] = value;
        }

        // calculating gpa of a student
        public double GetGPA(int num)
        {
            double avg = studentGrades.Sum() / num;
            return avg;
        }

    }
}
