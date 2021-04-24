using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopSession
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 10; i < 14; i++)
            {
                if(i < 12)
                {
                     Console.WriteLine("Hello David");
                }
                else
                {
                    Console.WriteLine("Hello Arsh");
                }
            }

            Console.ReadKey();
        }
    }
}
