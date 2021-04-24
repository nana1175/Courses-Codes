using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace david002_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrObj = new Student[35];

            int counter = 0;

            while (true)
            {
                string str;
                WriteLine("Do you want to enter a record, enter Y or N :");
                str = ReadLine();

                if (str == "N" || str == "n")
                    break;
                for (int i = 1; i < 36; i++)
                {
                    var obj = new Student();
                    WriteLine($"For student #{i} enter the student ID : ");
                    string str1 = ReadLine();
                    obj.StudentID = int.Parse(str1);

                    WriteLine($"For student #{i} enter student name : ");
                    string str2 = ReadLine();
                    obj.StudentName = str2;
                    for (int j = 0; j < 3; j++)
                    {
                        WriteLine($"For student #{j + 1}, enter ID for course #{j + 1} : ");
                        string str3 = ReadLine();
                        obj.SetCourseID(str3, j);

                        WriteLine($"For student #{j + 1}, enter credits for course #{j + 1} : ");
                        while (true)
                        {
                            if (int.TryParse(ReadLine(), out int cred))
                            {
                                obj.SetCreditHours(cred, j);
                                WriteLine($"For student #{j + 1}, enter grade for course #{j + 1} : ");
                                while (true)
                                {
                                    if (char.TryParse(ReadLine(), out char gr) && (gr == 'A' || gr == 'B' || gr == 'C' || gr == 'D' || gr == 'F'))
                                    {
                                        obj.SetGrade(gr, j);
                                        break;
                                    }
                                    else
                                        WriteLine($"For student #{j + 1}, enter grade for course #{j + 1} : ");
                                }
                                break;
                            }
                            else
                                WriteLine($"For student #{j + 1}, enter credits for course #{j + 1} : ");

                        }






                    }

                    arrObj[i - 1] = obj;



                    WriteLine("Do you want to enter a record, enter Y or N :");
                    str = ReadLine();
                    if (str == "N" || str == "n")
                        break;
                    else
                        counter++;
                }
                break;
            }




                for (int i = 0; i <= counter; i++)
                {
                    Console.WriteLine("Student Details:");
                    Console.WriteLine(arrObj[i]);
                }


                ReadKey();
            }
        }
    }

