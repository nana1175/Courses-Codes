using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            Trying obj = new Trying();
            
            // using object to initialize multiple times
            for(int i=1; i<3; i++)
            {
                Console.WriteLine("enter test 1 score: ");
                obj.Test1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter test 2 score: ");
                obj.Test2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter test 3 score: ");
                obj.Test3 = int.Parse(Console.ReadLine());
                int sum = obj.SumCalculator();
                Console.WriteLine("Sum of scores entered is {0}",sum);
            }

            Console.Write(obj.Test1);
            // for using parameterised constructor
            for(int i=0; i<3; i++)
            {

                Console.WriteLine("enter test 1 score: ");
                int test1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter test 2 score: ");
                int test2 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter test 3 score: ");
                int test3 = int.Parse(Console.ReadLine());
                Trying newobj = new Trying
                {
                    Test1 = test1,
                    Test2 = test2,
                    Test3 = test3
                };
                int sum = newobj.SumCalculator();
                Console.WriteLine("Sum of scores entered is {0}",sum);
            }



            // Using variables with single setter i.e. Test1
            obj.Test4 = 10;
            // If we enable below statement it will give error as Test4 cannot be get in this code
            //Console.WriteLine(obj.Test4); 

            // Similarly for getter
            Console.WriteLine("Test 5 value is {0}",obj.Test5);
            // cannot use below statement
            //obj.Test5 = 12;

            




            int a = 10;
            int b = 10;
            Minus(ref a);
            Console.WriteLine(a);
            Plus(ref a, in b);
            Console.WriteLine(a);


            Console.ReadKey();


        }

        public static void Minus(ref int a)
        {
            a+=10; // a = a + 10
        }



        public static void Plus(ref int a, in int b)
        {
            a = a + b;
        }
    }
}
