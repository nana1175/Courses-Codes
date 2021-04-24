using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques4
{
    class FractionApp
    {
        static void Main(string[] args)
        {
            var obj = new Fraction();

            try
            {
                // prompting user for input
                Console.WriteLine("Enter the numerator : ");
                obj.Num = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the denominator : ");
                obj.Denom = double.Parse(Console.ReadLine());

                // calculating fraction
                double frac = obj.FractionCalculator();

                Console.WriteLine($"The value of fraction is {frac} \n");
                
                // printing of the object
                Console.WriteLine(obj);
                
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine($"Error Message : {d.Message}");
            }
            catch(FormatException f)
            {
                Console.WriteLine($"Error Message : {f.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error Message : {e.Message}");
            }
            finally
            {
                Console.WriteLine("The execution of program is compeleted");
            }

            Console.ReadKey();

        }
    }
}
