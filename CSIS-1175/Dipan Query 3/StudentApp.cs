using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dipan_Query_3
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            // declaring number of courses as constant
            const int NUM_OF_COURSES = 5;

            // path of text file
            string file = @"C:\Users\arshs\Downloads\StudentData.txt";
            string outputFile = @"C:\Users\arshs\Downloads\studentsGPA.dat";

            // string for the result
            string str = "";

            // reading the file line by line
            if (File.Exists(file))
            {
                // file found
                Console.WriteLine("The text file StudentData.txt opened for reading...");
                Console.WriteLine("The binary file studentGPA.dat opened for writing...");

                // store each line in array of strings
                string[] lines = File.ReadAllLines(file);

                // counter
                int counter = 1;

                foreach(string ln in lines)
                {
                    Console.WriteLine($"\nReading record {counter} ...");

                    // splitting each line in the file 
                    string[] details = ln.Split(' ');

                    // declaring object
                    var stuObj = new Student(NUM_OF_COURSES);

                    // reading student name
                    stuObj.StudentName = details[0];
                    for (int i = 1; i <= NUM_OF_COURSES; i++)
                        stuObj.SetGrades(double.Parse(details[i]), i - 1);

                    // GPA calculation
                    double gpaVal = stuObj.GetGPA(NUM_OF_COURSES);

                    // creating string of data
                    str = str + stuObj.StudentName + " " + gpaVal + "\n";

                    Console.WriteLine($"Writing to the binary file ... {stuObj.StudentName} {gpaVal}");

                    counter++;
                }
            }

            // writing to a file
            File.WriteAllText(outputFile, str);

            Console.WriteLine("\n\n\nPress any key to quit...");

            Console.ReadKey();
        }
    }
}
