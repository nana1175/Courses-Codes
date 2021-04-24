using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshQuiz1
{
    class TipCalculator
    {
        public const double TAX_PER = 0.07, TIP_PER = 0.15;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tip Calculator App\n\n");

            // Getting the amount before tax
            Console.Write("Please enter the total charges for food purchases: ");
            double amountBeforeTax = double.Parse(Console.ReadLine());

            // Calculating total amount with Tax, Tip Amount and Total Amount with Tip and Tax
            double amountWithTax = CalculateBillWithTax(amountBeforeTax);
            double tipAmount = CalculateTip(amountWithTax);
            double totalAmount = amountWithTax + tipAmount; 

            // Output of the bill
            Console.WriteLine("Total Before Taxes and Tip:         ${0}", Math.Round(amountBeforeTax, 2));
            Console.WriteLine("After Tax (7%):                     ${0}", Math.Round(amountWithTax, 2));
            Console.WriteLine("Tip (15%):                          ${0}", Math.Round(tipAmount, 2));
            Console.WriteLine("Total Including Taxes with 15% Tip: ${0}", Math.Round(totalAmount, 2));


            Console.ReadKey();
        }

        static double CalculateBillWithTax(double amount)
        {
            // tax calculation 
            double totalAmountWithTax = TAX_PER * amount + amount;
            return totalAmountWithTax;
        }

        static double CalculateTip(double totalamount)
        {
            // tip calculation
            double totalTipAmount = totalamount * TIP_PER;
            return totalTipAmount;
        }
    }
}
