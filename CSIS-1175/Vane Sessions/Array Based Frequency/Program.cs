using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Based_Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables and array
            var arrNum = new int[100];
            var dimArr = new int[2, 100];
            
            // counter declaration
            var counter1 = 0;
            //var counter2 = 0;

            //getting input from user
            Console.Write("Input any number between 0 and 10 (-1 to stop): ");

            // running infinite loop to get user input until -1 is entered
            while(true)
            {
                // checking whether the entered value is int and within range
                if (int.TryParse(Console.ReadLine(), out int val) && val >= 0 && val <= 10)
                {
                    arrNum[counter1] = val;
                    counter1++;
                    Console.Write("Input any number between 0 and 10 (-1 to stop): ");
                }
                // break loop if value entered is -1
                else if (val == -1)
                {
                    break;
                }
                // keep prompting the user for value is incorrect value is entered
                else
                {
                    Console.WriteLine("Invalid Number");
                    Console.Write("Input any number between 0 and 10 (-1 to stop): ");
                }
                
            }

            // getting an array of distinct elements
            var distinctArrNum = arrNum.Distinct().ToArray();

            // getting index of first occurence of zero
            int inZero = Array.IndexOf(arrNum, 0);


            // to check if zero value is entered by the user or not
            if (inZero >= counter1)
            {
                // if no zero value entered so to remove the zero element at the last position of the array and then updating it
                distinctArrNum = distinctArrNum.Take(distinctArrNum.Count() - 1).ToArray();

                // updating the length of two dimensional arrray
                dimArr = new int[2, distinctArrNum.Length];
                    
            }
            else
                dimArr = new int[2, distinctArrNum.Length];


            

            // using two dimensional array to store data and occurences
            for (int i = 0; i < counter1; i++)
            {
                for (int j = 0; j < distinctArrNum.Length; j++)
                {
                    if (distinctArrNum[j] == arrNum[i])
                    {
                        if (dimArr[0, j] == distinctArrNum[j])
                        {
                            dimArr[1, j] = dimArr[1, j] + 1;
                        }
                        else
                        {
                            dimArr[0, j] = distinctArrNum[j];
                            dimArr[1, j] = 1;
                        }
                    }
                }

            }


            // calling method to print distribution chart
            FrequencyDistributionMethod(dimArr);
            

            Console.ReadKey();
        }

        // method to make frequency distribution chart
        public static void FrequencyDistributionMethod(int[,] dimArr)
        {
            Console.WriteLine("\n FREQUENCY DISTRIBUTION CHART");
            for(int i = 0; i < dimArr.GetLength(1); i++)
            {
                string str = "";
                if (dimArr[1,i] != 0)
                    str = string.Concat(Enumerable.Repeat("*", dimArr[1,i]));
                else
                    str = "";

                Console.WriteLine($"| {dimArr[0,i]} \t {str}");
            }
        }
    }
}
