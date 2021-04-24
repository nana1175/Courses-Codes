using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace david002_assignment
{
    class Student
    {
        // declaring constant
        public const int courseNumber = 35;

        // declaring variables
        private int studentID;
        private string studentName;
        string[] courseID = new string[courseNumber];
        int[] creditHrs = new int[courseNumber];
        char[] letterGrade = new char[courseNumber];
       
        // default constructor
        public Student()
        {
        }

        // parameterised constructor
        public Student(int StudID)
        {
            studentID = StudID;
        }

        public Student(string studName)
        {
            studentName = studName;
        }

        //getter and setters
        public int StudentID { get; set; }
        public string StudentName { get; set; }
       
        //array get and set
        public void SetCourseID(string value, int index)
        {
            courseID[index] = value;
        }

        public string GetCourseID(int index)
        {
            return courseID[index];
        }

        public void SetCreditHours(int value, int index)
        {
            creditHrs[index] = value;
        }

        public int GetCreditHours(int index)
        {
            return creditHrs[index];
        }

        public void SetGrade(char value, int index)
        {
            letterGrade[index] = value;
        }

        public char GetGrade(int index)
        {
            return letterGrade[index];
        }

        // creating a formatted string for the object 
        public override string ToString()
        {
            string dataString = "";

            // storing all the info in a format except Student ID in a string
            for (int i = 1; i < 4; i++)
            {
                dataString = dataString + "Course # " + i + " Id : " + courseID[i - 1] + " Credits : " + creditHrs[i - 1] + " Grade : " + letterGrade[i - 1] + "\n";
            }

            // complete string for object presentation
            string alString = " Name : " + StudentName + "\n" + dataString;

            return alString;

        }

    }
}
