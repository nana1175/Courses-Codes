using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques1
{
    class Program
    {
        static void Main(string[] args)
        {
            // try-catch-finally clause to handle exceptions
            try
            {
                Console.WriteLine("Enter first integer value: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second integer value: ");
                int num2 = int.Parse(Console.ReadLine());
                int product = num1 * num2;
                Console.WriteLine("The product of two integers is : {0}", product);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Error Message = {0}", e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error Message = {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("That’s it for today!!");
            }

            Console.ReadKey();
        }
    }
}
