using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOfModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

            // way 1 of object intialization
            var obj = new Test
            {
                TestVar1 = 2,
                TestVar2 = 3
            };

            // way 2 of object initialization
            // Test obj = new Test();
            


            // calculation of two variables
            int sum = obj.Calculation();
            Console.WriteLine(sum);

            // demo of in, ref and out modifiers

            // usage of ref

            int r = 10;
            SumMethod(ref r);
            Console.WriteLine(r);


            // usage of in
            int i = 20;
            SumMethodIn(in i, ref r);
            Console.WriteLine(r);

            // usage of out
            int o;
            SumMethod(out o, ref r);
            Console.WriteLine(o);




            Console.ReadKey();

        }

        public static void SumMethod(ref int r)
        {
            r++;
        }

        // cannot name same method with ref and in as modifiers
        public static void SumMethodIn(in int i, ref int r)
        {
            r = i + r;
        }


        public static void SumMethod(out int o, ref int r)
        {
            o = r + 10;
        }

    }
}
