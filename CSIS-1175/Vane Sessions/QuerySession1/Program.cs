using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySession1
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables

            // creating a list
            var valList = new List<int>();

            // creating a dictionary
            var eleDict = new Dictionary<int, int>();

            //getting input from user
            Console.Write("Input any number between 0 and 10 (-1 to stop): ");

            // running infinite loop to get user input until -1 is entered
            while(true)
            {
                // checking whether the entered value is int and within range
                if(int.TryParse(Console.ReadLine(), out int val) && val >= 0 && val <= 10)
                {
                    valList.Add(val);
                    Console.Write("Input any number between 0 and 10 (-1 to stop): ");
                }
                // break loop if value entered is -1
                else if(val == -1)
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

            // sorting the list
            valList.Sort();

            // adding the count of number of times a value was added in a list
           foreach (int num in valList)
            {
                if (eleDict.ContainsKey(num))
                    eleDict[num]++;
                else
                    eleDict.Add(num, 1);
            }

            
            Console.WriteLine("\nFREQUENCY DISTRIBUTION CHART\n");
            
           // creating a frequency distribution chart
           foreach(KeyValuePair<int, int> kvp in eleDict)
            {
                string str = "";
                if (kvp.Value != 0)
                    str = string.Concat(Enumerable.Repeat("*", kvp.Value));
                else
                    str = "";

                Console.WriteLine($"| {kvp.Key} \t {str}"); 
            }


            Console.ReadKey();
        }
    }
}
