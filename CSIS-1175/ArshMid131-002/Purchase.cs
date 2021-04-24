using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArshMid131_002
{
    class Purchase
    {
        // constant declaration
        private const double SALES_TAX = 0.05;

        // variables declaration
        private int invoiceNbr, numberOfItems;
        private double salesAmt, salesTaxAmt, shippingCharges;

        // default constructor
        public Purchase()
        {

        }

        // paramterized constructor
        public Purchase(int inv, double salAmt, int numItems)
        {
            invoiceNbr = inv;
            salesAmt = salAmt;
            numberOfItems = numItems;
        }

        // getter and setters
        public int InvoiceNbr
        {
            get { return invoiceNbr; }
            set { invoiceNbr = value; }
        }

        public int NumberOfItems
        {
            get { return numberOfItems; }
            set { numberOfItems = value; }
        }

        public double SalesAmount
        {
            get { return salesAmt; }
            set { salesAmt = value; }
        }

        public double SalesTaxAmount
        {
            get { return salesTaxAmt; }
            set { salesTaxAmt = value; }
        }

        public double ShippingCharges
        {
            get { return shippingCharges; }
            set { shippingCharges = value; }
        }

        // method to calculate sales tax
        public void CalculateSalesTax()
        {
            SalesTaxAmount = SALES_TAX * SalesAmount;
        }

        // method to calculate Shipping charges
        public void CalculateShippingCharges()
        {
            if(NumberOfItems < 3)
            {
                ShippingCharges = 3.50;
            }
            else if (NumberOfItems > 2 && NumberOfItems < 7)
            {
                ShippingCharges = 5.00;
            }
            else if (NumberOfItems > 6 && NumberOfItems < 11)
            {
                ShippingCharges = 7.00;
            }
            else
            {
                ShippingCharges = 10.00;
            }
        }

        // overriding tostring method to format the object output
        public override string ToString()
        {
            CalculateSalesTax();
            CalculateShippingCharges();
            double totalAmt = SalesAmount + SalesTaxAmount + ShippingCharges;
            return "Invoice number : " + InvoiceNbr + "\nSales amount : $" + Math.Round(SalesAmount,2) + "\nSales tax : " + SALES_TAX * 100 + "% \nSales tax amount : $" + Math.Round(SalesTaxAmount,2) + "\nShipping charges : $" + Math.Round(ShippingCharges,2) + "\nTotal Amount : $" + Math.Round(totalAmt,2) + "\n";
        }


    }
}
