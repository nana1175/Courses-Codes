/*
 *Programmer: [Arsh Sharma]
*Date: Winter 2020
* Purpose: This program uses methods for better code reusability and readability purposes
 */

using System;
using static System.Console;

namespace WeightedAverageCalc
{
    class WAC
    {
        static void Main(string[] args)
        {
            // constant weights are defined here
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float QUIZ_PERCENTAGE = 0.1f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;
            const byte MIN = 0, MAX = 100;

            // variables for storing the grades of a student
            float assignments;
            float midtermExam;
            float quiz1;
            float quiz2;
            float finalExam;

            float weightedExams = 0;
            float totalWeightedAverage = 0;


            Title = "CSIS1175 - Assignment 3 - By [Arsh Sharma]";

            DisplayBanner("Total Weighted Average Calculator");

            // The user enters the grades, the program gets them and stores them in the corresponding variable
            bool isAssignmentsInputValid, isMidtermInputValid,isQuiz1InputValid,isQuiz2InputValid,isFinalExamInputValid;
            isAssignmentsInputValid = GetUserInput("Assignments", MIN, MAX, out assignments);
            isMidtermInputValid = GetUserInput("Midterm Exam", MIN, MAX, out midtermExam);
            isQuiz1InputValid = GetUserInput("Quiz1", MIN, MAX, out quiz1);
            isQuiz2InputValid = GetUserInput("Quiz2", MIN, MAX, out quiz2);
            isFinalExamInputValid = GetUserInput("Final Exam", MIN, MAX, out finalExam);
            if ( isAssignmentsInputValid && isMidtermInputValid && isQuiz1InputValid && isQuiz2InputValid && isFinalExamInputValid)
            {
                // Total Weighted Avergae is sum of products of grades and their weight
                totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

                DisplayTableRow("Assessment", "Percentage", "Your Grade");
                DisplayTableRow("--------------", " -----------", "----------");

                DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments, LetterGrade(assignments));
                DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam, LetterGrade(midtermExam));
                DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1, LetterGrade(quiz1));
                DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2, LetterGrade(quiz2));
                DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam, LetterGrade(finalExam));

                WriteLine("----------------------------------------");

                // change the following line of code such that the Floor value of totalWeightedAverage is displayed on Console
                DisplayTableRow("Weighted Total", "1", Convert.ToString(Math.Floor(Convert.ToDouble(totalWeightedAverage))), LetterGrade(totalWeightedAverage)); //** Change only this line **//

                WriteLine("\n");

                weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
                weightedExams /= 0.8f;

                // change the following line of code such that the Ceiling value of weightedExams is displayed on Console
                if (weightedExams >= 50)
                {
                    WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0} ({1})", Math.Ceiling(weightedExams), LetterGrade(weightedExams)); //** Change only this line **//
                    WriteLine("The student PASSES the course.");
                }
                else
                {
                    WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0} ({1})", Math.Ceiling(weightedExams), LetterGrade(weightedExams)); //** Change only this line **//
                    WriteLine("The student FAILS the course.");
                }
                

            }


            WriteLine("\nPress a key to quit...");
            ReadKey();
        }

        //  your method definitions are written here (out of Main method). A method cannot be defined inside another method

        static bool GetUserInput(string textMessage, byte min, byte max, out float userInputValue)
        {
            Console.Write("Enter a value for {0} : ", textMessage);
            string data = Console.ReadLine();
            
            if(float.TryParse(data,out userInputValue) !=  true)
            {
                Console.WriteLine("Input data is invalid");
                userInputValue = 0;
                return false;
            }
            else if (min < 0 && max > 100)
            {
                Console.WriteLine("The min and max is not within range");
                userInputValue = 0;
                return false;
            }
            else
            {
                userInputValue = float.Parse(data);
                return true;
            }
        }

        static void DisplayBanner(string textMessage)
        {
            Console.WriteLine("{0}", textMessage);
        }

        static void DisplayTableRow(string val1, string val2, string val3)
        {
            Console.WriteLine("{0}  {1}  {2}", val1, val2, val3);
        }

        static void DisplayTableRow(string val1, string val2, string val3, string val4)
        {
            Console.WriteLine("{0}  {1}  {2}  {3}", val1, val2, val3, val4);
        }

        static void DisplayTableRow(string val1, float val2, float val3, string val4)
        {
            Console.WriteLine("{0}  {1}  {2} {3}", val1, val2, val3, val4);
        }

        static float WeightedGrade(float grade, float PERCENT)
        {
            float finalValue = grade * PERCENT;
            return finalValue;
        }

        static string LetterGrade(float marks)
        {
            if (marks >= 95)
                return "A+";
            else if (marks < 95 && marks >= 90)
                return "A";
            else if (marks < 90 && marks >= 85)
                return "A-";
            else if (marks < 85 && marks >= 80)
                return "B+";
            else if (marks < 80 && marks >= 75)
                return "B";
            else if (marks < 75 && marks >= 70)
                return "B-";
            else if (marks < 70 && marks >= 65)
                return "C+";
            else if (marks < 65 && marks >= 60)
                return "C";
            else if (marks < 60 && marks >= 55)
                return "C-";
            else if (marks < 60 && marks >= 55)
                return "P";
            else
                return "F";
        }

    }
}