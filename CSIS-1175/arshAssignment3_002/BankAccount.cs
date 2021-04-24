using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arshAssignment3_002
{
    class BankAccount
    {
        // variables declaration
        string name;
        double amount, balance;
        
        // default constructor
        public BankAccount() { }

        // parameterised constructor
        public BankAccount(string name, double amount, double balance)
        {
            this.name = name;
            if(amount >= 0)
                this.amount = amount;
  
            if(balance >= 0)
                this.balance = balance;
        }

        // implementing getter and setters
        public string Name { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }

        // implementing deposit method
        public double DepositAmount()
        {
            return Math.Round(Amount + Balance,2);
        }

        // implementing withdraw method
        public double WithdrawAmount()
        {
            if (Balance >= Amount)
                return Math.Round(Balance - Amount, 2);
            else
                return -1;
            
        }

        // method to format the object output
        public override string ToString()
        {
            return "Name: " + Name + "\nAccount Balance: " + Balance;
        }

    }
}
