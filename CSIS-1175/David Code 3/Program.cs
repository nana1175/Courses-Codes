using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace David_Code_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] waterDepth = { 45, 19, 2, 16.8, 190, 0.8, 510, 6, 18 };
            double[] w = new double[5];



            DisplayOutput(waterDepth, "\nwaterDepth Array\n\n");



            Array.Copy(waterDepth, 2, w, 0, 5);

            Console.WriteLine(w);

            Array.Sort(w);

            Console.WriteLine(w);

            DisplayOutput(w, "\nArray w Sorted\n\n");



            Array.Reverse(w);



            DisplayOutput(w, "\nArray w Reversed\n\n");

            Console.ReadKey();
        }

        public static void DisplayOutput(double[] anArray, string msg)
        {
            foreach (double wVal in anArray)
                if (wVal > 0)
                    msg += wVal + "\n";
            Console.WriteLine(msg);
            //MessageBox.Show(msg, caption);
        }
    }
}
