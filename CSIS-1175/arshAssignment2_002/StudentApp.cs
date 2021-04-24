using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arshAssignment2_002
{
    class StudentApp
    {
        static void Main(string[] args)
        {
            // declaring variables
            char choice;

            // declaring list of objects
            List<Student> stuList = new List<Student>();

            // for using counter
            int objCounter = 0;

            Console.Write("Do you want to enter a record, enter Y or N : ");
            choice = char.Parse(Console.ReadLine());

            // loop based on client choice for adding more students information
            while(choice == 'Y')
            { 
                var stuObj = new Student();
                Console.Write("For student # {0} enter the student ID : ", objCounter + 1);

                while(true)
                {
                    if (int.TryParse(Console.ReadLine(), out int stuId))
                    {
                        stuObj.StudentId = stuId;
                        Console.Write("For student # {0} enter student name : ", objCounter + 1);
                        stuObj.StudentName = Console.ReadLine();

                        // loop to read the details for 3 courses
                        for (int y = 1; y < 4; y++)
                        {
                            Console.Write("For student # {0}, enter id for course # {1} : ", objCounter + 1, y);
                            string _ = Console.ReadLine();
                            stuObj.SetCourseId(y - 1, _);
                            Console.Write("For student # {0}, enter credits for course # {1} : ", objCounter + 1, y);

                            // loop to keep checking until credits in int or double or float are not entered
                            while (true)
                            {
                                // checking the correct type of the credits
                                if (int.TryParse(Console.ReadLine(), out int finalCredit))
                                {
                                    stuObj.SetCreditHours(y - 1, finalCredit);

                                    Console.Write("For student # {0}, enter grade for course # {1} : ", objCounter + 1, y);

                                    // loop to keep checking until defined grades are not entered
                                    while (true)
                                    {
                                        string grade = Console.ReadLine();

                                        // defined grades array
                                        char[] gradeArr = new char[] { 'A', 'B', 'C', 'F', 'D' };

                                        // checking the correct type and existence of that value in defined grades
                                        if (char.TryParse(grade, out char finalGrade) && Array.Exists(gradeArr, x => x == finalGrade))
                                        {
                                            stuObj.SetGrade(y - 1, finalGrade);
                                            break;
                                        }
                                        // if grade entered is incorrect client will be asked to reenter the grade
                                        else
                                        {
                                            Console.Write("For student # {0}, enter grade for course # {1} : ", objCounter + 1, y);
                                        }

                                    }
                                    break;
                                }
                                else
                                {
                                    Console.Write("For student # {0}, enter credits for course # {1} : ", objCounter + 1, y);
                                }


                            }

                        }
                        break;
                    }
                    else
                    {
                        Console.Write("For student # {0} enter the student ID : ", objCounter + 1);
                    }
                }


                // placing the created object in array of objects
                stuList.Add(stuObj);

                // asking client to enter another input
                Console.WriteLine("Do you want to enter more records? Enter Y or N");
                while (true)
                {
                    if (char.TryParse(Console.ReadLine(), out char ch) && (ch == 'Y' || ch == 'N'))
                    {
                        choice = ch;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect choice. Please choose again.");
                        Console.WriteLine("Do you want to enter more records? Enter Y or N");
                    }
                }
               

                // incrementing the counter;
                objCounter++;
            }

            // counter for assigning number of students
            int counter = 1;

            // if no record is entered
            if(stuList.Capacity < 1)
            {
                Console.WriteLine("No records are added");
            }
            // if records are entered
            else
            {
                // reading each object in the list
                foreach (Student obj in stuList)
                {
                    Console.WriteLine("Student details :");
                    Console.WriteLine("Student #{0} Id : {1}", counter, obj.StudentId);
                    Console.WriteLine(obj);
                    counter++;
                }
            }
           
            
            // to keep screen open until the client presses any key
            Console.ReadKey();
        }
    }
}
