using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshMid131_002
{
    class PurchaseApp
    {
        // variables declaration
        private string inv, salesAmt;
        private int numberOfItems;

        // getter and setters
        public string Inv
        {
            get { return inv; }
            set { inv = value; }
        }

        public string SalesAmt
        {
            get { return salesAmt; }
            set { salesAmt = value; }
        }

        public int NumberOfItems
        {
            get { return numberOfItems; }
            set { numberOfItems = value; }
        }


        // main method
        public static void Main()
        {
            // declaration of object
            PurchaseApp app = new PurchaseApp();


            // loop usage for creating two objects
            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Enter Purchase Details");
                Console.WriteLine("Enter invoice number : ");
                app.Inv = Console.ReadLine();

                // loop used to constantly push the customer to enter correct invoice number
                while (true)
                {
                    // validating conditions on the invoice number
                    if (int.TryParse(app.Inv, out int inv_int) && inv_int >= 1000 && inv_int < 9000)
                    {
                        Console.WriteLine("Enter the sales amount : ");
                        app.SalesAmt = Console.ReadLine();

                        // loop used to constantly push the customer to enter correct sales amount
                        while (true)
                        {

                            // validating conditions on the sales amount
                            if (double.TryParse(app.SalesAmt, out double salesAmt_dbl) && salesAmt_dbl >= 0)
                            {
                                Console.WriteLine("Enter number of items purchased : ");
                                app.NumberOfItems = int.Parse(Console.ReadLine());
                                Console.WriteLine("Purchase #{0} details", i);

                                // declaration of object 
                                Purchase obj = new Purchase(inv_int, salesAmt_dbl, app.NumberOfItems);
                                Console.WriteLine(obj);
                                // after successful completion inner while loop will break
                                break;
                            }

                            // execute if the sales amount is not valid
                            else
                            {
                                Console.WriteLine("Invalid data entered for sales amount, please enter a nonnegative value.");
                                app.SalesAmt = Console.ReadLine();
                            }
                        }
                        // after successful completion outer while loop will break
                        break;
                    }

                    // execute if invoice number is invalid
                    else
                    {
                        Console.WriteLine("Invalid data entered for invoice");
                        Console.WriteLine("Enter a invoice number between 1000 and 9000 : ");
                        app.Inv = Console.ReadLine();
                    }
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
