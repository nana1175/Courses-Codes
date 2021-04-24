using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puru_Query_1
{
    class LoanApp
    {

        private string id, loanAmt;
        private string make;
        private double loanYrs;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string LoanAmt
        {
            get { return loanAmt; }
            set { loanAmt = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }


        public double LoanYrs
        {
            get { return loanYrs; }
            set { loanYrs = value; }
        }



        public static void Main()
        {

            LoanApp app = new LoanApp();
            int id_int;
            double loanAmt_dbl;

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Enter Car Loan Details");
                Console.Write("Enter Id: ");
                app.Id = Console.ReadLine();
                while (true)
                {
                    if (int.TryParse(app.Id, out id_int) && id_int > 0 && id_int < 10000)
                    {
                        Console.WriteLine("Enter make: ");
                        app.Make = Console.ReadLine();
                        Console.WriteLine("Enter Loan Amount: ");
                        app.LoanAmt = Console.ReadLine();

                        while (true)
                        {
                            if (double.TryParse(app.LoanAmt, out loanAmt_dbl) && loanAmt_dbl >= 0)
                            {
                                Console.WriteLine("Enter Loan Years: ");
                                app.LoanYrs = double.Parse(Console.ReadLine());
                                Console.WriteLine("Car #{0} Loan Details", i);
                                AutomobileLoan obj = new AutomobileLoan(id_int, app.Make, loanAmt_dbl, app.LoanYrs);
                                Console.WriteLine(obj);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid loan amount.");
                                Console.WriteLine("Enter Loan Amount again: ");
                                app.LoanAmt = Console.ReadLine();
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Data entered for id");
                        Console.WriteLine("Enter ID again: ");
                        app.Id = Console.ReadLine();
                    }
                }
            }
            Console.ReadKey();
            
        }

    }
}
