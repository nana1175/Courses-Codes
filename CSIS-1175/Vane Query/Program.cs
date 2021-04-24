using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vane_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = GetStr(Console.ReadLine());
            Console.WriteLine("Enter Favorite saying: ");
            string favSay = GetStr(Console.ReadLine());

            PrintData(name, favSay);


            Console.ReadKey();
        }

        static string GetStr(string val)
        {
            return val;
        }

        static void PrintData(string name, string favsay)
        {
            string updatedName = name.PadRight((2 * favsay.Length) - 1);
            string updateFavSay = favsay.PadRight((2 * favsay.Length) - 1);
            Console.WriteLine(string.Concat(Enumerable.Repeat("<>", favsay.Length + 2)));
            Console.WriteLine("<> {0}<>", updatedName);
            Console.WriteLine("<> {0}<>", updateFavSay);
            Console.WriteLine(string.Concat(Enumerable.Repeat("<>", favsay.Length + 2)));
        }

    }
}
