using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arshAssignment2_002
{
    class Student
    {

        // declaring requried variables
        private int studentId;
        private string studentName;
        private int[] creditHours = new int[3];
        private string[] courseId = new string[3];
        private char[] letterGrade = new char[3];

        // default constructor
        public Student() { }

        // declaring getter and setters
        public int StudentId { get; set; }
        public string StudentName { get; set; }

       // Get and Set method for Arrays
       public int GetCreditHours(int i)
        {
            return creditHours[i];
        }
        public void SetCreditHours(int i, int val)
        {
            creditHours[i] = val;
        }
        public string GetCourseId(int i)
        {
            return courseId[i];
        }
        public void SetCourseId(int i, string val)
        {
            courseId[i] = val;
        }
        public char GetGrade(int i)
        {
            return letterGrade[i];
        }
        public void SetGrade(int i, char val)
        {
            letterGrade[i] = val;
        }

        // overriding tostring method for formatting the object output
        public override string ToString()
        {
            string dataString = "";
            
            // storing all the info in a format except Student ID in a string
            for(int i=1; i < 4; i++)
            {
                dataString = dataString + "Course # " + i + " Id : " + courseId[i - 1] + " Credits : " + creditHours[i - 1] + " Grade : " + letterGrade[i - 1] + "\n"; 
            }

            // complete string for object presentation
            string finalString = " Name : " + StudentName + "\n" + dataString;


            return finalString;
        }
        

        


    }
}
