using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques2
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            var marks = new int[3];

            try
            {
                // promting user to check number of marks to be entered
                Console.WriteLine("Enter how many times marks will be entered : ");
                int numTimes = int.Parse(Console.ReadLine());
                for (int i = 0; i < numTimes; i++)
                {
                    Console.Write("Please enter Marks {0}: ", i);
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int mark))
                        {
                            if(mark >= 0 && mark <= 100)
                            {
                                marks[i] = mark;
                                break;
                            }
                            else
                                Console.Write("Value is out of range, Please enter marks {0} again: ", i);
                        }
                        else
                        {
                            Console.Write("Value entered is incorrect, Please enter marks {0} again: ", i);
                        }
                    }

                }
                double avgMarks = AvgCalculator(marks, numTimes);
                char grade = GradeCalculator(avgMarks);

                //printing output
                Console.WriteLine($"The average marks are : {avgMarks}");
                Console.WriteLine($"The grade achieved is : {grade}");
            }
            catch (FormatException f)
            {
                Console.WriteLine("Error Message = {0}", f.Message);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Error Message = {0}", de.Message);
            }
            catch (IndexOutOfRangeException id)
            {
                Console.WriteLine("Error Message = {0}", id.Message);
            }
            finally
            {
                Console.WriteLine("The program execution is complete");
            }


            Console.ReadKey();
        }

        // calculation of average of values entered
        public static double AvgCalculator(int[] marks, int numTimes)
        {
            double avgVal = marks.Sum() / numTimes;
            return avgVal;
        }
        // calculation of grade
        public static char GradeCalculator(double avgMarks)
        {
            if (avgMarks >= 90 && avgMarks <= 100)
                return 'A';
            else if (avgMarks >= 80 && avgMarks <= 89)
                return 'B';
            else if (avgMarks >= 70 && avgMarks <= 79)
                return 'C';
            else if (avgMarks >= 60 && avgMarks <= 69)
                return 'D';
            else
                return 'F';
        }

    }
}
