using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puru_Query_1
{
    class AutomobileLoan
    {
        private const double INTEREST = 0.0299;
        private string make;
        private int id;
        private double loanAmt, loanYrs, monthlyPmt;

        public AutomobileLoan()
        {

        }
        
        public AutomobileLoan(int id_in, string make_in, double loanAmt_in, double loanYrs_in)
        {
            id = id_in;
            make = make_in;
            loanAmt = loanAmt_in;
            loanYrs = loanYrs_in;
        }

        // getter and setters
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double LoanAmt
        {
            get { return loanAmt; }
            set { loanAmt = value; }
        }

        public double LoanYrs
        {
            get { return loanYrs; }
            set { loanYrs = value; }
        }

        public double MonthyPmt
        {
            get { return monthlyPmt; }
            set { monthlyPmt = value; }
        }

        public void DetermineMonthlyPayment()
        {
            double numberOfPayments = 12.0 * LoanYrs;
            double term;
            term = Math.Pow((1 + (INTEREST / 12.0)), numberOfPayments);
            MonthyPmt = LoanAmt * (INTEREST / 12.0) * term * (term - 1.0);
        }

        public override string ToString()
        {
            DetermineMonthlyPayment();
            return "Id : " + Id + "\nMake : " + Make + "\nLoan Amount : " + LoanAmt + "\nLoan Years : " + LoanYrs + "\nInterest Rate : " + INTEREST + "\nMonthly Payment is : $" + Math.Round(MonthyPmt,2);
        }
    }
}
