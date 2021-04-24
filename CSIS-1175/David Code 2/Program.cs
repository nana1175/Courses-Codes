using System;
using static System.Console;
using System.Windows;



namespace Lab6_CLASSWORK
{
    class Program
    {



        static void Main(string[] args)
        {
            // EX2-------------------------
            //    //int[] vault = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            //    var vault1 = new int[10] { 11, 23, 34, 44, 35, 60, 70, 80, 90, 100 };



            //    Array.Sort(vault1);



            //    foreach (var vault in vault1)
            //    {
            //        Write(vault + "\t");
            //    }



            //    Array.Reverse(vault1);
            //    WriteLine("");



            //    foreach (var vault in vault1)
            //    {
            //        Write(vault + "\t");
            //    }



            WriteLine("NEW TRY \n");
            int[] store = new int[8] { 2, 4, 5, 7, 4, 12, 52, 20 };
            int[] store2 = new int[5];
            Array.Copy(store, store2,4);
            foreach(int element in store2)
            {
                Console.WriteLine(element);
            }
            

            DisplayAll(store);
            DisplayReverse(store);

            



            
            

            double avg = DisplayAvg(store);
            Write("\nThe avg is : {0}",avg);
            string minus = DisplayIf(store);
            string valuesHighAvg = DisplayIf(store, avg);

            WriteLine("\nValues that are LESS than 10 : {0}", minus);

            WriteLine("\nValues that are Higher than Average : {0}", valuesHighAvg);

            string m = "My name is " + minus;
            Write(m);


            //
            //

            ReadKey();
        }



        //display
        public static void DisplayAll(int[] store)
        {
            WriteLine("ALL is : ");
            foreach (var vault in store)
            {
                Write(vault + "\t");
            }
        }
        //reverse
        public static void DisplayReverse(int[] store)
        {
            WriteLine("\nREVERSE is :");
            Array.Reverse(store);
            foreach (var vault in store)
            {
                Write(vault + "\t");
            }
        }
        //sum
        public static double DisplayAvg(int[] store)
        {
            int sum = 0;
            
            for (int i = 0; i < store.Length; i++)
            {
                sum += store[i]; // sum of variables in ana array
            }

            double avgArr = sum / store.Length;

            return avgArr;
        }
        //IF
        public static string DisplayIf(int[] store)
        {
            string minus = "";
            foreach (int vault in store)
                if (vault < 10)
                    minus += vault + "\t";

            return minus;

        }

        public static string DisplayIf(int[] store, double avg)
        {
            string minus = "";
            foreach (int vault in store)
                if (vault > avg)
                    minus += vault + "\t";

            return minus;
        }
    }
}