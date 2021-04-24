using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanSession1
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputUser = new int[10];
            int counter2 = 0;

            // for loop
            while (counter2 < 4)                 //for(int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"Value of counter2 on entering while loop {counter2}");
                Console.WriteLine("Enter value for the main for loop {0}: ",counter2); //comes back here when the value is correct and the loop is complete per each index or loop.
                // int val = int.Parse(Console.ReadLine());

                while (true) // infinite loop it will comes here again infinite times until the correc value is input and then out thiswhile loop to for loop.
                {
                    if (int.TryParse(Console.ReadLine(), out int val))
                    {
                        inputUser[counter2] = val;
                        break;
                    }
                    else
                        Console.WriteLine("Enter value {0}: ", counter2);

                }

                //string v = Console.ReadLine();

                //while (int.TryParse(v, out int val) == false)
                //{
                //    Console.WriteLine("Enter value {0}: ", i);

                //        inputUser[i] = val;
                //        Console.WriteLine(inputUser[i]);


                //}

                //inputUser[i] = int.Parse(v);



                

                // input into array
                // inputUser[i] = val;
                //  Console.WriteLine(inputUser);
                counter2++;
                Console.WriteLine($"Value of counter2 on exiting while loop {counter2}");
            }

          //  Console.WriteLine(counter2);

            int count = 0;
            foreach(int l in inputUser) //Foreach will always take the whole size of the array.
            {
                Console.WriteLine($"The value at index {count} is {l}");
                count++;
                if (count >= counter2)
                    break;
            }



            Console.ReadKey();
        }
    }
}
