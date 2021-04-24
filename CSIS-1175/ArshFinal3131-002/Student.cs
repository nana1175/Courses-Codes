
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ArshFinal3131_002
{
    class Student
    {
        // constant declaration
        const double BREAKFAST_COST = 100;
        // declaring variables
        string stuName, stuEmail, dormInfo, mealInfo, status;
        UInt64 stuId;

        // default constructor
        public Student() { }

        // parameterised constructor
        public Student(string stuName, string stuEmail, UInt64 stuId, string dormInfo, string mealInfo, string status)
        {
            this.stuName = stuName;
            this.stuEmail = stuEmail;
            this.stuId = stuId;
            this.dormInfo = dormInfo;
            this.mealInfo = mealInfo;
            this.status = status;
        }

        // declaring getter and setters
        public string StuName { get; set; }
        public string StuEmail { get; set; }
        public UInt64 StuId { get; set; }
        public string DormInfo { get; set; }
        public string MealInfo { get; set; }
        public string Status { get; set; }

        // method to calculate the total cost and returning the final string for the text box
        public string CalculateCost(string breakStatus)
        {
            double dormCost = 0;
            double mealCost = 0;
            double totalCost = 0;
            string finalStr = "";

            // getting dorm cost
            if (DormInfo.Equals("Simon Hall"))
                dormCost = 1500;
            else if (DormInfo.Equals("SFU Hall"))
                dormCost = 1600;
            else if (DormInfo.Equals("Douglas Hall"))
                dormCost = 1800;
            else
                dormCost = 2500;

            // getting meal cost
            if (MealInfo.Equals("7 meals per week"))
                mealCost = 600;
            else if (MealInfo.Equals("14 meals per week"))
                mealCost = 1200;
            else
                mealCost = 1700;
            
            // checking breakfast status
            if(breakStatus.Equals("Yes"))
            {
                if (Status.Equals("Grade"))
                {
                    totalCost = dormCost + mealCost + BREAKFAST_COST - 200;
                    finalStr = $"Dorm Price is ${dormCost} meal price is ${mealCost} breakfast price is ${BREAKFAST_COST} discount is $200 total is ${totalCost}";
                }
                else
                {
                    totalCost = dormCost + mealCost + BREAKFAST_COST;
                    finalStr = $"Dorm Price is ${dormCost} meal price is ${mealCost} breakfast price is ${BREAKFAST_COST} total is ${totalCost}";
                }
            }
            else
            {
                if (Status.Equals("Grade"))
                {
                    totalCost = dormCost + mealCost - 200;
                    finalStr = $"Dorm Price is ${dormCost} meal price is ${mealCost} discount is $200 total is ${totalCost}";
                }
                else
                {
                    totalCost = dormCost + mealCost;
                    finalStr = $"Dorm Price is ${dormCost} meal price is ${mealCost} total is ${totalCost}";
                }
                    
            }


            return finalStr;
        }

        // method to save data into the file
        public void FileDataSaver(string finalCost, string filePath)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"{StuName}    {StuEmail}    {StuId}    {finalCost}");
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show($"Error Message : {ioe.Message}");
            }
        }


        // method for formatting the object
        public override string ToString()
        {
            return StuName + " " + StuEmail + " " + StuId + " ";
        }
    }
}
