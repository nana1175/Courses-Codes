using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques3
{
    class BMIApp
    {
        static void Main(string[] args)
        {
            var obj = new BMI();
            Console.WriteLine("Enter the height in feet & inches like 5 feet 7 inches:");
            try
            {
                string val = Console.ReadLine();
                string[] actVal = val.Split(' ');
                double valFeet = double.Parse(actVal[0]);
                double valInch = double.Parse(actVal[2]);

                // converting feet into meters
                double m1 = valFeet * 0.3048;

                // converting inches into parameterised
                double m2 = valInch * 0.0254;

                // allocating value to height
                obj.Height = m1 + m2;

                Console.WriteLine("Enter the weight in kg: ");
                obj.Weight = double.Parse(Console.ReadLine());

                // calculating BMI
                obj.BMIVal = obj.CalculateBMI();

                Console.WriteLine(obj);


            }
            catch (FormatException f)
            {
                Console.WriteLine("Error Message = {0}", f.Message);
            }
            catch(ArithmeticException a)
            {
                Console.WriteLine("Error Message = {0}", a.Message);
            }
            finally
            {
                Console.WriteLine("The code exection is complete");
            }

            Console.ReadKey();
        }
    }
}
