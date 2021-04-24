/*
 * Programmer: [Arsh Sharma]
 * Date: Winter 2020
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
            assignments = GetUserInput("Assignments");
            midtermExam = GetUserInput("Midterm Exam");
            quiz1 = GetUserInput("Quiz1");
            quiz2 = GetUserInput("Quiz2");
            finalExam = GetUserInput("Final Exam");

            WriteLine("\n");

            // Total Weighted Avergae is sum of products of grades and their weight
            totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

            DisplayTableRow("Assessment", "Percentage", "Your Grade");
            DisplayTableRow("--------------", " -----------", "----------");

            DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments);
            DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam);
            DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1);
            DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2);
            DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam);

            WriteLine("----------------------------------------");

            // change the following line of code such that the Floor value of totalWeightedAverage is displayed on Console
            DisplayTableRow("Weighted Total", "1", Convert.ToString(Math.Floor(Convert.ToDouble(totalWeightedAverage)))); //** Change only this line **//

            WriteLine("\n");

            weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
            weightedExams /= 0.8f;

            // change the following line of code such that the Ceiling value of weightedExams is displayed on Console
            WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0}", Math.Ceiling(weightedExams)); //** Change only this line **//
            WriteLine("If WAT-on-Exams is less than 50, the student fails the course.");

            ReadKey();
        }

        //  your method definitions are written here (out of Main method). A method cannot be defined inside another method
        
        static float GetUserInput(string textMessage)
        {
            Console.WriteLine("Enter a value for {0} :", textMessage);
            float grade = float.Parse(Console.ReadLine());
            return grade;
        }

        static void DisplayBanner(string textMessage)
        {
            Console.WriteLine("{0}", textMessage);
        }

        static void DisplayTableRow(string val1, string val2, string val3)
        {
            Console.WriteLine("{0}  {1}  {2}", val1, val2, val3);
        }

        static void DisplayTableRow(string val1, float val2, float val3)
        {
            Console.WriteLine("{0}  {1}  {2}", val1, val2, val3);
        }

        static float WeightedGrade(float grade, float PERCENT)
        {
            float finalValue = grade * PERCENT;
            return finalValue;
        }



    }
}
