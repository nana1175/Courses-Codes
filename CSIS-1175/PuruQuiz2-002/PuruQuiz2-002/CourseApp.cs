using System;
using static System.Console;

namespace PuruQuiz2_002
{
    class CourseApp
    {
        static void Main(string[] args)
        {
            CourseApp a = new CourseApp();     
            a.ShowInformation();
            ReadKey();

        }

        public void ShowInformation()
        {
            double[] Marks = new double[10];
            Course Subjects = new Course();
            
            WriteLine("Enter course Id: ");
            Subjects.CourseID = ReadLine();

            WriteLine("Enter course name: ");
            Subjects.CourseName = ReadLine();

            for (int i=0; i < Marks.Length; i++)
            {
                WriteLine($"Enter marks for student#{i+1}");
                double value = Convert.ToDouble(ReadLine());
                Subjects.Marks = value;
            }

            var avgMarks = Subjects.GetAverage();
            WriteLine($"Average marks obtained: {avgMarks}" );
            WriteLine(Subjects.ToString());

        }
    }
}
