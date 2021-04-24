using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David_Code_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            var frNames = new String[10];
            var frBday = new String[10];

            // used for index of array
            int counter = 0;

            // to store names and bday
            while(true)
            {
                string str;
                Console.WriteLine("Enter Friend's Name : ");
                str = Console.ReadLine();

                if (str == "ZZZ")
                    break;
                else
                    frNames[counter] = str;

                Console.WriteLine("Enter Friend's Bday: ");
                str = Console.ReadLine();

                if (str == "ZZZ")
                    break;
                else
                    frBday[counter] = str;


                counter++;


                if (counter == 10)
                    break;
                
                
            }

            // presentation
            Console.WriteLine("The number of values entered {0}", counter + 1);
            for (int i = 0; i < frNames.Length; i++)
            {
                Console.WriteLine(frNames[i]);
            }


            // find and give output
            while (true) // infinite loop
            {
                Console.WriteLine("Enter a name of your friend: ");
                string name = Console.ReadLine();

                if (name == "ZZZ")
                    break;

                for (int i = 0; i < frNames.Length; i++)
                {
                    if (frNames[i] == name)
                    {
                        if (frBday[i] != "") // validation for null string
                            Console.WriteLine("Name: {0} & BirthDate: {1}", frNames[i], frBday[i]);
                        else
                            Console.WriteLine("Name: {0} & BirthDate is not stored", frNames[i]);
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
