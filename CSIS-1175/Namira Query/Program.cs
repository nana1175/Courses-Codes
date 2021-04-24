using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namira_Query
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SALES_PER = 0.07;
            const double FED_TAX = 0.18;
            const double RET_CONT = 0.15;
            const double SOC_SEC_TAX = 0.09;


            Console.WriteLine("Enter Name of Employee: ");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Enter the sales amount of week: ");
            double salesAmount = double.Parse(Console.ReadLine());

            // Calculating commission for employee
            double salesCommission = salesAmount * SALES_PER;

            // Calculating federal tax
            double federalTax = salesCommission * FED_TAX;

            // Calculating retirement contribution
            double retContribution = salesCommission * RET_CONT;

            // Calculation social security tax
            double socialSecTax = salesCommission * SOC_SEC_TAX;

            // Calculating total deductions
            double totalDeductions = federalTax + retContribution + socialSecTax;

            // Calculating take home pay of employee
            double homePay = salesCommission - totalDeductions;

            Console.WriteLine("The amount of commission is ${0}", Math.Round(salesCommission, 2));
            Console.WriteLine("The name of employee is {0} and the pay he takes home is ${1}", employeeName, Math.Round(homePay, 2));

            Console.WriteLine("Total deductions are ${0}", Math.Round(totalDeductions, 2));
            Console.WriteLine("The separate value of each deduction are:");
            Console.WriteLine("The Federal Tax - ${0} \nThe Retirement Contribution - ${1} \nThe Social Security Tax - ${2}", Math.Round(federalTax, 2), Math.Round(retContribution, 2), Math.Round(socialSecTax, 2));

            Console.ReadKey();

        }
    }
}
