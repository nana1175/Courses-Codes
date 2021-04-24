using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshQuiz2_002
{
    class CourseApp
    {
        // declaring constant for number of exeutions
        private const int NUM_OF_EXEC = 1;
        static void Main(string[] args)
        {
            
            // object creation
            Course obj = new Course();

            // loop for number of times to be executed
            for(int i = 0; i < NUM_OF_EXEC; i++)
            {
                // getting course id
                Console.Write("Enter course Id : ");
                obj.CourseId = Console.ReadLine();

                // getting course name
                Console.Write("Enter course name : ");
                obj.CourseName = Console.ReadLine();

                // loop for getting marks for number of students
                for(int j = 0; j < obj.NumOfStudents; j++)
                {
                    Console.Write("Enter marks for student# {0} : ", j + 1);

                    // infinite loop for prompting the user continuosuly until correct input is entered
                    while(true)
                    {
                        // conditional check for marks
                        if(double.TryParse(Console.ReadLine(), out double finalVal) && finalVal <= 100)
                        {
                            // placing value for a particular index in marks array
                            obj.SetMarks(finalVal, j);

                            // after success breaking out of infinite loop
                            break;
                        }
                        // if incorrect value is entered
                        else
                            Console.Write("Enter marks for student# {0} : ", j + 1);
                    }
                }

                // printing the object output
                Console.WriteLine(obj);
            }

            // to keep the console open until the client presses a key
            Console.ReadKey();

        }
    }
}
